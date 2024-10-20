using Restuarent_Backend.Models.MenuEntity;
using Restuarent_Backend.Models.OrderEntitiy;

namespace Restuarent_Backend.Dtos
{
    public class OrderItemDto
    {
        
        public string Title { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        //navigation prop
        public int OrderID { get; set; }
        public string MenuItemId { get; set; }

        
     
    }
}
