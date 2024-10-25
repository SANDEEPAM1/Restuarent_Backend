using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Restuarent_Backend.Data;
using Restuarent_Backend.Dtos;

namespace Restuarent_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebBackgroundController : ControllerBase
    {
        private readonly ResturantDBContext dBContext;
        private readonly ILogger<WebBackgroundController> logger;

        public WebBackgroundController(ResturantDBContext dBContext, ILogger<WebBackgroundController> logger)
        {
            this.dBContext = dBContext;
            this.logger = logger;
        }

        [HttpGet]
        [Route("/getCardDetails")]
        public async Task<IActionResult> getAllMenuDetails()
        {
            
            try
            {
                var items = await dBContext.MenuItems.ToListAsync();
                if(items.Count<1)
                {
                    logger.LogWarning("there is no menu item in the database");
                    return NotFound("menu items are not found");
                }
                var itemsDto = items.Select(item => new AddMenuItmDto
                {
                    MenuItemId = item.MenuItemId,
                    Title = item.Title,
                    Description = item.Description,
                    Price = item.Price,
                    Category = item.Category,
                    ImageUrl = item.ImageUrl,
                    IsAvailable = item.IsAvailable,

                });
                logger.LogInformation($"the data for the background running is sent{itemsDto}");
                return Ok(itemsDto);
            }
            catch (Exception ex)

            {
                logger.LogError("something went wrong in the server. we are working on it");
                  return BadRequest(ex.Message);

            }
        }

    }
}
