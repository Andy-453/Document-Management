using System.ComponentModel.DataAnnotations;

namespace DocumentManagementBackend.DTOs
{
    public class LoginDTOs
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
