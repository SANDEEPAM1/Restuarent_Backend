using Restuarent_Backend.Models.OrderEntitiy;
using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Models.PaymentEntity
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod {  get; set; }


        //navigations
        public int OrderId { get; set; }
        public OrderTable OrderTable { get; set; }
    }
}
