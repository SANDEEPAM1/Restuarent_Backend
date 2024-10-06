using Restuarent_Backend.Models.CustomerEntity;
using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Models.LoginHistoryEntity
{
    public class LoginHistoryTable
    {
        [Key]
        public int LoginHistoryId { get; set; }
        [Required]
        public string CustomerId { get; set; }
        public CustomerProfile CustomerProfile { get; set; }
        public DateTime LastLoginDate { get; set; }

        public string OrderFoods { get; set; }

        public bool? IsActiveAccount { get; set; }
    }
}
