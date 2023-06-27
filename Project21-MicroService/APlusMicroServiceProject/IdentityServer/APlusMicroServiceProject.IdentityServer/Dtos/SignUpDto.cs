using System.ComponentModel.DataAnnotations;

namespace APlusMicroServiceProject.IdentityServer.Dtos
{
    public class SignUpDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserCity { get; set; }
        [Required]
        public string UserCountry { get; set; }
    }
}
