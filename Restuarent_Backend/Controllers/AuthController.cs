using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restuarent_Backend.Data;
using Restuarent_Backend.Dtos;
using Restuarent_Backend.Models.CustomerEntity;
using Restuarent_Backend.Utilities;
using System.Runtime.InteropServices;

namespace Restuarent_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //dbContext connection
        private readonly ResturantDBContext _dbContext;
        public AuthController(ResturantDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // receiving sign up data
        [HttpPost]
        public IActionResult RegisterCustomer([FromBody] CustomerRegisterDto regiertDto)
        {
            var CustomerId = GenerateCustomerId.customIdGenerator(regiertDto.UserName, regiertDto.Email);

            var customer = new CustomerProfile()
            {
                CustomerId = CustomerId,
                UserName = regiertDto.UserName,
                Password = regiertDto.Password,
                Email = regiertDto.Email,
                IsActive = true,
                IsLoggin = false,
                RegistrationDate = DateTime.Now,
            };
             _dbContext.Add(customer);
             _dbContext.SaveChanges();
              return Ok(customer);


            
        }
    }
}
