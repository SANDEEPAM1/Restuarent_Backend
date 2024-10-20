using Restuarent_Backend.Models.CustomerEntity;
using Restuarent_Backend.Models.DeliveryPersonEntitiiy;
using Restuarent_Backend.Models.OrderItemEntity;
using Restuarent_Backend.Models.PaymentEntity;
using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Dtos
{
    public class OrderDetailsDto
    {

    
        public string phoneNumber { get; set; }
        public string Status { get; set; }
        [Required]
        public string DeliveryType { get; set; }
        public string? DeliveyAddress { get; set; }
        //public string ConfirmationCode { get; set; }

        //forign key 
        public string CustomerId { get; set; }
       

        public int? DeliveryPerosnId { get; set; }
        

        public ICollection<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>();

       public Payment? Payment { get; set; }
    }
}
