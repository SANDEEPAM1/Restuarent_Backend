using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Dtos
{
    public class AdminOnlineOrdersDto
    {
        public int OrderId { get; set; }
        public DateTime OrderTime { get; set; } = DateTime.Now;
        public string Status { get; set; }
        [Required]
        public string DeliveryType { get; set; }
        public string? DeliveyAddress { get; set; }

        public string phoneNumber { get; set; }
        public string CustomerId { get; set; }
        public int? DeliveryPerosnId { get; set; }
    }
}
