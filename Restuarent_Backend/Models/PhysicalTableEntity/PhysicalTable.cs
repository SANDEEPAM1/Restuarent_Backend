using Restuarent_Backend.Models.ReservationEntity;
using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Models.PhysicalTableEntity
{
    public class PhysicalTable
    {
        [Key]
        public int TableId { get; set; }
        [Required]
        public int TableNumber { get; set; }
        [Required]
        public int Seats { get; set; }
        [Required]
        public string Location { get; set; }
        public bool? IsAvailable { get; set; }
        public DateTime? ReservationStartDateTime { get; set; }
        public DateTime? ReservationEndDateTime { get; set; }
        public string? SpecialFeature { get; set; }

        //navigation prop
        public ICollection<Reservation> Reservations { get; set; }
    }
}
