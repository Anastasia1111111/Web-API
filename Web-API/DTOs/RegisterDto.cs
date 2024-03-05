using System.ComponentModel.DataAnnotations;

namespace Web_API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username {get; set;}
        [Required]
        public string Password { get; set;}
    }
}
