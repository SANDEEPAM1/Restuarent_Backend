using Restuarent_Backend.Models.CustomerEntity;
using Restuarent_Backend.Models.PhysicalTableEntity;
using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Models.ReservationEntity
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public DateOnly ReservationDate { get; set; }
        [Required]
        public TimeOnly ReservationTime { get; set; }

         [Required]
         public int ReservationDuration { get; set; }
        [Required]
        public int NumberOfGuests { get; set; }
        
        public string? Occation {  get; set; }
        public string? SpecialRequest { get; set; }

        //customerId forign key
        public string CustomerId { get; set; }
        public CustomerProfile CustomerProfile { get; set; }

        //TableId forign  key

       public int TableId { get; set; }
       public PhysicalTable PhysicalTable { get; set; }
        

    }
}
