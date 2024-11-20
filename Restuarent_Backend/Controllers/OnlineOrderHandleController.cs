using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restuarent_Backend.Data;
using Restuarent_Backend.Dtos;
using Restuarent_Backend.Models.OrderEntitiy;
using Restuarent_Backend.Models.OrderItemEntity;
using Restuarent_Backend.Models.PaymentEntity;

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

            using (var transaction = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var cusId = await _dbContext.CustomerProfiles
                                        .Where(c => c.UserId == dto.UserId)
                                        .Select(c => c.CustomerId)
                                        .FirstOrDefaultAsync();
                    // 1. Create the order details
                    var orderDetails = new OrderTable
                    {
                        OrderTime = DateTime.Now,
                        Status = dto.Status,
                        DeliveryType = dto.DeliveryType,
                        DeliveyAddress = dto.DeliveyAddress,
                        CustomerId = cusId,
                        phoneNumber = dto.phoneNumber,
                    };

                    await _dbContext.OrderTables.AddAsync(orderDetails);
                    await _dbContext.SaveChangesAsync();
                    _logger.LogInformation("Order details saved");

                    // 2. Create the order items
                    var orderItems = dto.OrderItems.Select(order => new OrderItemTable
                    {
                        Title = order.Title,
                        Quantity = order.Quantity,
                        Price = order.Price,
                        OrderID = orderDetails.OrderId,
                        MenuItemId = order.MenuItemId,
                    }).ToList();

                    await _dbContext.OrderItemTables.AddRangeAsync(orderItems);
                    await _dbContext.SaveChangesAsync();
                    _logger.LogInformation("Order items saved");

                    // 3. Create the payment record
                    var payment = new Payment
                    {
                        Amount = dto.Payment.Amount,
                        PaymentMethod = dto.Payment.PaymentMethod,
                        PaymentDate = DateTime.Now,
                        OrderId = orderDetails.OrderId,
                    };

                    await _dbContext.Payments.AddAsync(payment);
                    await _dbContext.SaveChangesAsync();
                    _logger.LogInformation("Payment details saved");

                    // Commit the transaction
                    await transaction.CommitAsync();
                    return Ok();
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if anything fails
                    await transaction.RollbackAsync();
                    _logger.LogError("Error occurred while processing the order", ex.Message);
                    return BadRequest(ex.Message);
                }
            }

        }
    }
}
