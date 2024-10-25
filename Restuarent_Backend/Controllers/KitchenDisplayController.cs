using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restuarent_Backend.Data;
using Restuarent_Backend.Dtos;

namespace Restuarent_Backend.Controllers
{
    public class KitchenDisplayController : ControllerBase
    {
        private readonly ResturantDBContext _dBContext;
        private readonly ILogger<KitchenDisplayController> _logger;

        public KitchenDisplayController(ResturantDBContext dBContext, ILogger<KitchenDisplayController> logger)
        {
            _dBContext = dBContext;
            _logger = logger;
        }

        [HttpGet]
        [Route("/kitchen")]
        public async Task<IActionResult> SendOrders()
        {
            // fetching the data that are pending from the orderTable
            try
            {
                var orderIdToCook = await _dBContext.OrderTables
                                    .Where(order => order.Status == "pending" || order.Status == "cooking")
                                    .Select(o => o.OrderId).ToListAsync();

                var ordersToCook = await _dBContext.OrderItemTables
                                                          .Where(oi => orderIdToCook.Contains(oi.OrderID))
                                                           .GroupBy(oi => oi.OrderID)  // Group by OrderID
                                                .Select(group => new
                                                {
                                                    OrderID = group.Key, // This is the OrderID
                                                    Items = group.Select(oi => new
                                                    {
                                                        oi.OrderItemId,
                                                        oi.MenuItemId,
                                                        oi.Quantity,
                                                        oi.Price,
                                                        oi.Title
                                                    }).ToList() // List of order items
                                                })
                                                .ToListAsync();


                if (ordersToCook.Count > 0)
                {
                    return Ok(ordersToCook);
                }
                else
                {
                    return NotFound("No orders at the moment");
                }


            }
            catch (Exception ex)
            {
                _logger.LogError($"some think went wrong in kitchen {ex.Message}");
                return BadRequest(ex.Message);
            }

        }


        [HttpPatch]
        [Route("/updateStatus/{id:int}")]
        public async Task<IActionResult> updateStatus([FromRoute] int id, string status)
        {
            var order = await _dBContext.OrderTables.FirstOrDefaultAsync(o => o.OrderId == id);
            if(order == null)
            {
                _logger.LogWarning("there is no order like that");
                return BadRequest("there is no oreder like that");
            }

            order.Status = status;
            await _dBContext.SaveChangesAsync();
            return Ok(order);
        }



    }   
}
