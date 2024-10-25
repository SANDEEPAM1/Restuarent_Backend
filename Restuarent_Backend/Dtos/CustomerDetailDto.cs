using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Restuarent_Backend.Dtos
{
    public class CustomerDetailDto
    {
       
       
        public string UserName { get; set; }
        [Required, NotNull, EmailAddress]
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        public bool? IsActive { get; set; }

        public bool? IsLoggin { get; set; }
    }
}
