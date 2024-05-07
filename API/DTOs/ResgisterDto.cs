//#38 Can do the  validation

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4)] //74
        public string Password { get; set; }
    }
}
