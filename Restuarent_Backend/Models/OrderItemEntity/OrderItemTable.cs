using Restuarent_Backend.Models.MenuEntity;
using Restuarent_Backend.Models.OrderEntitiy;
using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Models.OrderItemEntity
{
    public class OrderItemTable
    {
        [Key]
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        //navigation prop
        public int OrderID { get; set; }
        public OrderTable OrderTable { get; set; }

        public string MenuItemId { get; set; }
        public MenuTable MenuTable { get; set; }
    }
}
