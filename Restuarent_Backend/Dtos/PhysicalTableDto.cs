using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Dtos
{
    public class PhysicalTableDto
    {
       
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
    }
}

