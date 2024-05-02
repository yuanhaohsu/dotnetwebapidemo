namespace API.Controllers
{
    

    public class AccountController : BaseApiController
    {
            private readonly DataContext _context;
            public AccountController(DataContext context)
            {
                _context = context;
            }

            [HttpPost("register")] //POST:  api/account/register
            public async Task<ActionResult<AppUser>> Register(RegisterDto registerDto) //(string Username, string Password)//~36
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

                return user;
            }
            [HttpPost("login")] //POST:  api/account/login  //#39
            public async Task<ActionResult<AppUser>> Login(LoginDto loginDto) //#39
            {
                var user = await _context.Users.SingleOrDefaultAsync(x => x.UserName == loginDto.Username); //#39

                if (user == null) return Unauthorized("Invalid username"); //#39; when the user is not existed in database will show error message

                using var hmac = new HMACSHA512(user.PasswordSalt); //#39 check the password;

                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password)); //#39; Compare Salted and Hash Password

                for (int i = 0; i < computedHash.Length; i++) //#39
                {
                    if (computedHash[i] != user.PasswordHash[i]) return Unauthorized("Invalid password"); //#39
                }

                return user; //#39
            }

            private async Task<bool> UserExists(string username) //#37
            {
                return await _context.Users.AnyAsync(x => x.UserName == username.ToLower()); //.ToLower() 
            }

    }
}