using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Dtos
{
    public class ForgetPasswordDto
    {
        [Required]
        public string Email { get; set; }
    }
}
