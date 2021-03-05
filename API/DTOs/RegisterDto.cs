using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        [StringLength(8, MinimumLength = 2)]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 2)]
        public string Password { get; set; }
    }
}