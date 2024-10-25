using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restuarent_Backend.Data;
using Restuarent_Backend.Dtos;

namespace Restuarent_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerProfileController : ControllerBase
    {
        private readonly ResturantDBContext _dbContext;
        private readonly ILogger<CustomerProfileController> _logger;

        public CustomerProfileController(ResturantDBContext dbContext, ILogger<CustomerProfileController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet]
        [Route("sedCustomerDetails/{id}")]

        public async Task<IActionResult> sendCustomerDetails([FromRoute] string id)
        {
            try
            {
                var customer = await _dbContext.CustomerProfiles.FindAsync(id);
                if(customer == null)
                {
                    return NotFound();
                }

                var customdto = new CustomerDetailDto
                {
                    Email = customer.Email,
                    UserName = customer.UserName,
                    IsActive = customer.IsActive,
                    IsLoggin = customer.IsLoggin,
                };
                _logger.LogInformation("customer detail send:", customdto.UserName);
                return Ok(customdto);
            }catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
