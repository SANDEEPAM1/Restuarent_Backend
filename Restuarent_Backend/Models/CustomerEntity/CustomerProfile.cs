using Restuarent_Backend.Models.LoginHistoryEntity;
using Restuarent_Backend.Models.OrderEntitiy;
using Restuarent_Backend.Models.ReservationEntity;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Restuarent_Backend.Models.CustomerEntity
{
    public class CustomerProfile
    {
        [Key,Required]
        public string CustomerId { get; set; }
        [Required,NotNull]
        public string UserName { get; set; }
        [Required,NotNull]
        public string Password { get; set; }
        [Required,NotNull,EmailAddress]
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        public bool? IsActive { get; set; }

        public bool? IsLoggin { get; set; }

        //navigation properties
        public LoginHistoryTable LoginHistoryTable { get; set; }
        public ICollection<OrderTable> OrderTables { get; set; }

        public ICollection<Reservation> Reservations { get; set; }


    }
}
