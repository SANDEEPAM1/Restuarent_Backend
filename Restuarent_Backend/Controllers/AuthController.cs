using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly JwtTockenGenerator _jwtTocken;
        private readonly ILogger<AuthController> _logger;
        //dbContext connection
        private readonly ResturantDBContext _dbContext;
        public AuthController(ResturantDBContext dbContext, UserManager<IdentityUser> userMangager, SignInManager<IdentityUser> signInManager, JwtTockenGenerator jwtTocken, ILogger<AuthController> logger)
        {
            _dbContext = dbContext;

            _userManager = userMangager;
            _signInManager = signInManager;
            _jwtTocken = jwtTocken;
            _logger = logger;
        }


        //routes

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationDto request)
        {

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new IdentityUser { UserName = request.UserName, Email= request.Email };
            var result = await _userManager.CreateAsync(user, request.Password);


                
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Customer");

                var Customer = new CustomerProfile
                {
                    CustomerId = GenerateCustomerId.customIdGenerator(user.UserName, user.Email),
                    UserName = user.UserName,
                    Email = user.Email,
                    RegistrationDate = DateTime.Now,
                    IsActive = true,
                    IsLoggin = false,
                    UserId=user.Id,
                    
                };

                await _dbContext.AddAsync(Customer);
                await _dbContext.SaveChangesAsync();   

                return Ok(Customer);
            }
            var errors = result.Errors.Select(e=> e.Description).ToList();
            foreach (var error in result.Errors )
            {
                _logger.LogError("Registration Error : {Error}", error.Description);
            }

            return BadRequest(new {Errors = errors });
        }
            
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto request)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _signInManager.PasswordSignInAsync(request.UserName, request.Password, isPersistent: false, lockoutOnFailure: false);
            
            if(result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(request.UserName);
                var roles = await _userManager.GetRolesAsync(user);

                var token = _jwtTocken.GenerateJwtToken(user, roles);
                return Ok(new {Token = token});
            }

            return Unauthorized(new {Message ="Invalid Login attempt."});
        }



    }
}
