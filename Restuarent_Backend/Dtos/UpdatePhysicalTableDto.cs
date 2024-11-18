using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Dtos
{
    public class UpdatePhysicalTableDto
    { 
        [Required]
        public int TableNumber { get; set; }
        public string Location { get; set; }
        public string? SpecialFeature { get; set; }
        public bool IsAvailable { get; set; }

    }
}
