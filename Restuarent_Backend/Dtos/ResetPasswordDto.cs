using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Dtos
{
    public class ResetPasswordDto
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        [Required]
        public string NewPassword { get; set; }
    }
}
