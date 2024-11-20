using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Models
{
    public class WaiterEntity
    {

        [Key]
        public int WaiterId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]

        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
