using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restuarent_Backend.Data;
using Restuarent_Backend.Dtos;
using Restuarent_Backend.Models.MenuEntity;
using Restuarent_Backend.Models.PhysicalTableEntity;
using Microsoft.Extensions.Logging;

namespace Restuarent_Backend.Controllers
{

   
   
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ResturantDBContext dbContext;
        private readonly ILogger<AdminController> logger;

        public AdminController(ResturantDBContext _dbContext, ILogger<AdminController> _logger)
        {
            dbContext = _dbContext;
            logger = _logger;
        }



        [HttpPost]
        [Route("/addMenu")]
       public async Task<IActionResult> CreateFood([FromBody] AddMenuItmDto dto)
        {
           if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var menuItem = new MenuTable
            {
                MenuItemId = dto.MenuItemId,
                Title = dto.Title,
                Description = dto.Description,
                Price = dto.Price,
                Category = dto.Category,
                ImageUrl = dto.ImageUrl,
                IsAvailable = dto.IsAvailable,

            };
           
            await dbContext.AddAsync(menuItem);
            await dbContext.SaveChangesAsync();

            var menuItemDto = new AddMenuItmDto
            {
                MenuItemId = menuItem.MenuItemId,
                Title = menuItem.Title,
                Description = menuItem.Description,
                Price = menuItem.Price,
                Category = menuItem.Category,
                ImageUrl = menuItem.ImageUrl,
                IsAvailable = menuItem.IsAvailable,

            };
            return Ok(menuItemDto);

        }

        [HttpGet]
        [Route("/   getMenu")]
        public async Task<IActionResult> GetAllMenuItems()
        {
            var menuItems = await dbContext.MenuItems.ToListAsync();

            if (!menuItems.Any())
            {
                return NotFound(new { Message = "No menu items found." });
            }

            var menuItemDtos = menuItems.Select(item => new AddMenuItmDto
            {
                MenuItemId = item.MenuItemId,
                Title = item.Title,
                Description = item.Description,
                Price = item.Price,
                Category = item.Category,
                ImageUrl = item.ImageUrl,
                IsAvailable = item.IsAvailable,

            }).ToList();

            return Ok(menuItemDtos);   
        }

        [HttpPut]
        [Route("/menuUpdate/{id}")]
        public async Task<IActionResult> UpdatemenuItem([FromRoute]string id, [FromBody]UpdateMenuItemDto dto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(new {message="error occured"});
            } 
            
            var menuItem = await dbContext.MenuItems.FirstOrDefaultAsync(item => item.MenuItemId==id);
            if (menuItem == null)
            {
                return NotFound();
            }
           
            menuItem.Title = dto.Title;
            menuItem.Description = dto.Description; 
            menuItem.Price = dto.Price;

            if (!string.IsNullOrEmpty(dto.ImageUrl))
            {
                menuItem.ImageUrl = dto.ImageUrl;
            }

            if (dto.IsAvailable.HasValue)
            {
                menuItem.IsAvailable = dto.IsAvailable;   
            }

            await dbContext.SaveChangesAsync();

            var updteDto = new UpdateMenuItemDto
            {
                Title = menuItem.Title,
                Description = menuItem.Description,
                Price = menuItem.Price,
                ImageUrl = menuItem.ImageUrl,
                IsAvailable = menuItem.IsAvailable,
            };
            return Ok(updteDto);
        }
            
        [HttpDelete]
        [Route("/deleteMenu/{id}")]
        public async Task<IActionResult> DeleteMenuItem([FromRoute] string id)
        {
            var menuItem = await dbContext.MenuItems.FirstOrDefaultAsync(item => item.MenuItemId==id);  
            if(menuItem == null)
            {
                return NotFound();
            }
             dbContext.MenuItems.Remove(menuItem);
            await dbContext.SaveChangesAsync();
            return Ok(new {message = "Menu item deleted successfully"});

        }



        //Physical class curds

        [HttpPost]
        [Route("/createTable")]
        public async Task<IActionResult> CreatTable(PhysicalTableDto dto)
        {
            var existingTable = dbContext.PhysicalTables.FirstOrDefault(tb =>tb.TableId==dto.TableId);  
            if (existingTable != null)
            {
                return BadRequest(new { message = "the tableId is already in the table" });
            }
            if(!ModelState.IsValid)
            {
                return BadRequest(new {message = "details are not valid"});
            }
            var table = new PhysicalTable
            {
                
                TableNumber = dto.TableNumber,
                Seats = dto.Seats,
                Location = dto.Location,
                IsAvailable = dto.IsAvailable,
                ReservationStartDateTime = dto.ReservationStartDateTime,
                ReservationEndDateTime = dto.ReservationEndDateTime,
                SpecialFeature = dto.SpecialFeature,
            };
            
            await dbContext.PhysicalTables.AddAsync(table);
            await dbContext.SaveChangesAsync();
            
            var tabledto = new PhysicalTableDto
            {
                TableId = table.TableId,
                TableNumber = table.TableNumber,
                Seats = table.Seats,
                Location = table.Location,
                IsAvailable = table.IsAvailable,
                ReservationStartDateTime = table.ReservationStartDateTime,
                ReservationEndDateTime = table.ReservationEndDateTime,
                SpecialFeature = table.SpecialFeature,
            };

            return Ok(tabledto);
        }

        [HttpGet]
        [Route("/getAllTables")]
        public async Task<IActionResult> GetAllTables()
        {
            try
            {
                var tables = await dbContext.PhysicalTables.ToListAsync();

                // Log the fetched tables
                logger.LogInformation("Fetched tables: {@tables}", tables);

                if (tables == null || !tables.Any())
                {
                    logger.LogWarning("No tables found in the database.");
                    return NotFound(new { Message = "No tables found." });
                }

                var tablesDto = tables.Select(t => new PhysicalTableDto
                {
                    TableId = t.TableId,
                    TableNumber = t.TableNumber,
                    Seats = t.Seats,
                    Location = t.Location,
                    IsAvailable = t.IsAvailable,
                    ReservationStartDateTime = t.ReservationStartDateTime,
                    ReservationEndDateTime = t.ReservationEndDateTime,
                    SpecialFeature = t.SpecialFeature
                }).ToList();

                return Ok(tablesDto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while fetching tables.");
                return StatusCode(StatusCodes.Status500InternalServerError, new { Message = "An error occurred while processing your request." });
            }
        }

        [HttpPut]
        [Route("/updteTable/{id:int}")]
        public async Task<IActionResult> updateTable([FromRoute] int id, [FromBody] UpdatePhysicalTableDto dto)
        {
            var table = await dbContext.PhysicalTables.SingleOrDefaultAsync(t => t.TableId == id);
            if (table == null)
            {
                return BadRequest(new { message = "there is no table in that nubmer" });
            }

            table.SpecialFeature = dto.SpecialFeature;
            table.Location = dto.Location;
            table.TableNumber = dto.TableNumber;

           await dbContext.SaveChangesAsync();

            var updatetableDto = new UpdatePhysicalTableDto
            {
                SpecialFeature = table.SpecialFeature,
                Location = table.Location,
                TableNumber = table.TableNumber,
            };

            return Ok(updatetableDto);
        }

        [HttpPut]
        [Route("/updateReservations/{id:int}")]
        public async Task<IActionResult> updateReservationDetails([FromRoute] int id, [FromBody] UpdateReservationsDto dto)
        {
            var table = await dbContext.PhysicalTables.SingleOrDefaultAsync(t=>t.TableId == id);
            if (table == null)
            {
                return BadRequest(new { message = "there is no table" });
            }

            table.ReservationStartDateTime = dto.ReservationStartDateTime;
            table.ReservationEndDateTime = dto.ReservationEndDateTime;  
            table.IsAvailable = dto.IsAvailable;    
            await dbContext.SaveChangesAsync();

            var reservedDto = new UpdateReservationsDto
            {
                ReservationStartDateTime = table.ReservationStartDateTime,
                ReservationEndDateTime = table.ReservationEndDateTime,
                IsAvailable = table.IsAvailable

            };
            return Ok(reservedDto);
        }

        [HttpDelete]
        [Route("/deletePhyTable/{id:int}")]
        public async Task<IActionResult> DeletePhyTable([FromRoute] int id)
        {
            var table = await dbContext.PhysicalTables.SingleOrDefaultAsync(tb=>tb.TableId == id);
            if (table == null)
            {
                return BadRequest(new { message = "there is no table in that id" });
            }

            dbContext.PhysicalTables.Remove(table);
            await dbContext.SaveChangesAsync();

            return Ok(new {message= "delete the table",table.TableId});
        }



        [HttpGet]
        [Route("/getOnlineOrders")]
        public async Task<IActionResult> getOnlineOrders()
        {
            var orders = await dbContext.OrderTables.ToListAsync();
            if (orders == null || orders.Count<=0)
            {
                logger.LogInformation("there is no online orders in current time");
                return BadRequest(new { message = "there is no any order in the queue" });
            }

            var onlineOrders = orders.Select(o => new AdminOnlineOrdersDto
            {
                OrderId = o.OrderId,
                OrderTime = o.OrderTime,
                Status = o.Status,
                DeliveryType = o.DeliveryType,
                DeliveryPerosnId = o.DeliveryPerosnId,
                DeliveyAddress = o.DeliveyAddress,
                phoneNumber = o.phoneNumber,
                CustomerId = o.CustomerId,
            });
            logger.LogInformation("sending current online orders to admin");
            return Ok(onlineOrders);
        }

        [HttpGet]
        [Route("/getDeliveryPersons")]
        public async Task<IActionResult> getAllDeliveryPersons()
        {
            var deliveryPersons = await dbContext.DeliveryPersons.ToListAsync();
            if (deliveryPersons == null || deliveryPersons.Count <= 0)
            {
                return BadRequest(new { message = "no delivery Persons" });
            }

            var deliveryPersonList = deliveryPersons.Select(d => new AdminDeliveryPersonDto
            {
                   DeliveryPersonId = d.DeliveryPersonId,
                   PhoneNumber = d.PhoneNumber,
                   FullName = d.FullName,
                   IsAvailable = d.IsAvailable
            }).ToList();

            logger.LogInformation("data is sent to Admin");
            return Ok(deliveryPersonList);


        }

        [HttpDelete]
        [Route("/deleteOrder/{id:int}")]
        public async Task<IActionResult> DeleteOrder([FromRoute] int id)
        {
            try
            {

                var order = await dbContext.OrderTables.Include(o => o.OrderItems)
                          .Include(o => o.Payment).FirstOrDefaultAsync(o => o.OrderId == id);
                if(order == null)
                {
                    logger.LogWarning($"order Id {id} not found");
                    return NotFound();
                }

                dbContext.OrderTables.Remove(order);
                await dbContext.SaveChangesAsync();
                return Ok("order and the related orderItems deleted successfully");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
