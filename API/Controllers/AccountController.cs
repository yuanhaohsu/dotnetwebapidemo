namespace API.Controllers
{
    

    public class AccountController : BaseApiController
    {
            private readonly DataContext _context;

            private readonly ITokenService _tokenService; //added 43
            public AccountController(DataContext context, ITokenService tokenService) : base(context, tokenService //added 43
            {
                _context = context;
            }

            [HttpPost("register")] //POST:  api/account/register
            public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto) //(string Username, string Password)//~36
            {
                if (await UserExists(registerDto.Username)) return BadRequest("Username is taken"); //#37

                using var hmac = new HMACSHA512();

                var user = new AppUser
                {
                    UserName = registerDto.Username.ToLower(),
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                    PasswordSalt = hmac.Key
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return new UserDto
                {
                    Username = user.UserName,
                    Token = _tokenService.CreateToken(user) //added 43
                };
            }

            [HttpPost("login")] //POST:  api/account/login  //#39
            public async Task<ActionResult<UserDto>> Login(LoginDto loginDto) //#39
            {
                var user = await _context.Users.SingleOrDefaultAsync(x => x.UserName == loginDto.Username); //#39

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
                    Token = _tokenService.CreateToken(user) //added 43
                }; //#39
            }

            private async Task<bool> UserExists(string username) //#37
            {
                return await _context.Users.AnyAsync(x => x.UserName == username.ToLower()); //.ToLower() 
            }

    }
}