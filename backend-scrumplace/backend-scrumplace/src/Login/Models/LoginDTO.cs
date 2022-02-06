using System.ComponentModel.DataAnnotations;

namespace backend_scrumplace.src.Login.Models
{
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
