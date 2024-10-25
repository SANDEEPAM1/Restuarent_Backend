using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restuarent_Backend.Data;
using Restuarent_Backend.Dtos;

namespace Restuarent_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryPersonController : ControllerBase
    {
        private readonly ResturantDBContext _dbContext;
        private readonly ILogger<DeliveryPersonController> _logger;

        public DeliveryPersonController(ResturantDBContext dbContext, ILogger<DeliveryPersonController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet]
        [Route("getProfileDetails/{id:int}")]
        public async Task <IActionResult> getProfile([FromRoute] int id)
        {
            
            try
            {
                var person = await _dbContext.DeliveryPersons.FindAsync(id);
                if (person == null)
                {
                    return NotFound();
                }
                var dto = new AdminDeliveryPersonDto
                {
                    DeliveryPersonId = person.DeliveryPersonId,
                    FullName = person.FullName,
                    PhoneNumber = person.PhoneNumber,
                    IsAvailable = person.IsAvailable,
                };
                _logger.LogInformation("sent the details");
                return Ok(dto);
                

            }
            catch (Exception ex)
            {
                _logger.LogError("error occured");
                return BadRequest(ex.Message);   
            }
        }

        [HttpPatch]
        [Route("changeStatus/{id:int}")]
        public async Task<IActionResult> changeStatus([FromRoute]int id, [FromBody] UpdateDeliveryPersonDto dto)
        {
            try
            {
                var person = await _dbContext.DeliveryPersons.FindAsync(id);
                if(person == null)
                {
                    return NotFound();
                }
                person.IsAvailable = dto.IsAvailable;
                await _dbContext.SaveChangesAsync();
                return Ok(dto);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            

        }
    }
}
