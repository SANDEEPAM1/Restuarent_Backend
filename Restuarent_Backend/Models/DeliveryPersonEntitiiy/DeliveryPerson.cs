using Restuarent_Backend.Models.OrderEntitiy;
using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Models.DeliveryPersonEntitiiy
{
    public class DeliveryPerson
    {
        [Key]
        public int DeliveryPersonId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public bool IsAvailable { get; set; }

        //navigation property
        public ICollection<OrderTable> OrderTables { get; set; }

    }
}
