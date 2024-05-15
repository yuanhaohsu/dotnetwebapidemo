namespace API.Controllers
{
    

    public class AccountController : BaseApiController
    {
            private readonly DataContext _context;

            private readonly ITokenService _tokenService; //added 43

            private readonly IMapper _mapper; //#148
            public AccountController(DataContext context, ITokenService tokenService, IMapper mapper) //added 43 / #148
            {
                _context = context;
                _tokenService = tokenService;
                _mapper = mapper;
            }

            [HttpPost("register")] //POST:  api/account/register
            public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto) //(string Username, string Password)//~36
            {
                if (await UserExists(registerDto.Username)) return BadRequest("Username is taken"); //#37

                var user = _mapper.Map<AppUser>(registerDto); //#148

                using var hmac = new HMACSHA512();

                    //#148
                user.UserName = registerDto.Username.ToLower();
                user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password));
                user.PasswordSalt = hmac.Key;

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return new UserDto
                {
                    Username = user.UserName,
                    //#148
                    Token = _tokenService.CreateToken(user),
                    KnownAs = user.KnownAs

                };
            }

            [HttpPost("login")] //POST:  api/account/login  //#39
            public async Task<ActionResult<UserDto>> Login(LoginDto loginDto) //#39
            {
                var user = await _context.Users
                    .Include(p => p.Photos) //#134
                    .SingleOrDefaultAsync(x => x.UserName == loginDto.Username); //#39

                if (user == null) return Unauthorized("Invalid username"); //#39; when the user is not existed in database will show error message

                using var hmac = new HMACSHA512(user.PasswordSalt); //#39 check the password;

                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password)); //#39; Compare Salted and Hash Password

                for (int i = 0; i < computedHash.Length; i++) //#39
                {
                    if (computedHash[i] != user.PasswordHash[i]) return Unauthorized("Invalid password"); //#39
                }

                 return new UserDto
                {
                    Username = user.UserName,
                    Token = _tokenService.CreateToken(user)         //added 43
                    PhotoUrl = user.Photos.FirstOrDefault(x => x.IsMain)?.Url,
                     KnownAs = user.KnownAs
                }; //#39
            }

            private async Task<bool> UserExists(string username) //#37
            {
                return await _context.Users.AnyAsync(x => x.UserName == username.ToLower()); //.ToLower() 
            }

    }
}
