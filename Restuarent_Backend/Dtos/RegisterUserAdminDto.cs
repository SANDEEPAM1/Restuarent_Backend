using System.ComponentModel.DataAnnotations;



namespace Restuarent_Backend.Dtos
{
    public class RegisterUserAdminDto
    {
        public string fullName { get; set; }
        public string phoneNubmer { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string role { get; set; }
    }
}
