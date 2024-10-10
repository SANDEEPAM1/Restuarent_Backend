using Restuarent_Backend.Models.CustomerEntity;
using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Models.LoginHistoryEntity
{
    public class LoginHistoryTable
    {
        [Key]
        public int LoginHistoryId { get; set; }
       
        public DateTime LastLoginDate { get; set; }
        
        public int LoginCount { get; set; }

        //navigation
        public string CustomerId { get; set; }
        public CustomerProfile CustomerProfile { get; set; }
    }
}
