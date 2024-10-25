using Restuarent_Backend.Models.CustomerEntity;
using Restuarent_Backend.Models.DeliveryPersonEntitiiy;
using Restuarent_Backend.Models.OrderItemEntity;
using Restuarent_Backend.Models.PaymentEntity;
using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Models.OrderEntitiy
{
    public class OrderTable
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderTime { get; set; } = DateTime.Now;
        public string Status { get; set; }
        [Required]
        public string DeliveryType { get; set; }
        public string? DeliveyAddress { get; set; }

        public string phoneNumber { get; set; }
        //public string ConfirmationCode { get; set; }

        //forign key 
        public string CustomerId { get; set; }
        public CustomerProfile CustomerProfile { get; set; }

         public int? DeliveryPerosnId { get; set; }
        public DeliveryPerson DeliveryPerson { get; set; }

        public ICollection<OrderItemTable> OrderItems { get; set; } 
        public Payment? Payment { get; set; }

    }
}
