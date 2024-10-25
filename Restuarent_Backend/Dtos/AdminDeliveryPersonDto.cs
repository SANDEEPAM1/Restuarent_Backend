using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Dtos
{
    public class AdminDeliveryPersonDto
    {

        public int DeliveryPersonId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public bool IsAvailable { get; set; }
    }
}
