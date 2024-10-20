using Microsoft.AspNetCore.Mvc;
using Restuarent_Backend.Data;
using Restuarent_Backend.Dtos;
using Restuarent_Backend.Models.OrderEntitiy;
using Restuarent_Backend.Models.OrderItemEntity;

namespace Restuarent_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineOrderHandleController : ControllerBase
    {
        private readonly ResturantDBContext _dbContext;
        private readonly ILogger _logger;
        public OnlineOrderHandleController(ResturantDBContext dbContext, ILogger<OnlineOrderHandleController> logger)
        {  
            _dbContext = dbContext;
            _logger = logger;
        }



        [HttpPost]
        [Route("orderData")]
        public async Task<IActionResult> ReceiveData([FromBody] OrderDetailsDto dto)
        {

            try
            {
                var orderDetails = new OrderTable()
                {

                    Status = dto.Status,
                    DeliveryType = dto.DeliveryType,
                    DeliveyAddress = dto.DeliveyAddress,
                    CustomerId = dto.CustomerId,
                    phoneNumber = dto.phoneNumber,
                };

                await _dbContext.OrderTables.AddAsync(orderDetails);
                await _dbContext.SaveChangesAsync();
                _logger.LogInformation("details for the order tabel saved");

                var OrderItems = dto.OrderItems.Select(order => new OrderItemTable
                {
                    Title = order.Title,
                    Quantity = order.Quantity,
                    Price = order.Price,
                    OrderID = orderDetails.OrderId,
                    MenuItemId = order.MenuItemId,

                }).ToList();

                await _dbContext.OrderItemTables.AddRangeAsync(OrderItems);
                await _dbContext.SaveChangesAsync();
                _logger.LogInformation("details for OrderItem table saved");
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError("something went wrong", ex.Message);
                return BadRequest(ex.Message);  
            }
            
        }

    }
}
