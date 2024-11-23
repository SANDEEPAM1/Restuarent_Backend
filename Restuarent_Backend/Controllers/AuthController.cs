using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using Restuarent_Backend.Data;
using Restuarent_Backend.Dtos;
using Restuarent_Backend.Models;
using Restuarent_Backend.Models.CustomerEntity;
using Restuarent_Backend.Models.DeliveryPersonEntitiiy;
using Restuarent_Backend.Services;
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
        private readonly  IEmailService _emailService;
        //dbContext connection
        private readonly ResturantDBContext _dbContext;
        public AuthController(ResturantDBContext dbContext, UserManager<IdentityUser> userMangager, SignInManager<IdentityUser> signInManager, JwtTockenGenerator jwtTocken, ILogger<AuthController> logger, IEmailService emailService)
        {
            _dbContext = dbContext;

            _userManager = userMangager;
            _signInManager = signInManager;
            _jwtTocken = jwtTocken;
            _logger = logger;
            _emailService = emailService;
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
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                // Generate confirmation link
                var confirmationLink = Url.Action(
                    nameof(ConfirmEmail),
                    "Auth",
                    new { userId = user.Id, token },
                    Request.Scheme
                );

                // Send email
                var emailBody = $"Please confirm your email by clicking the following link: <a href='{confirmationLink}'>Confirm Email</a>";
                await _emailService.SendEmail(user.Email, "Email Confirmation", emailBody);

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

                return Ok(new {Customer, confirmationCode = token, userId= user.Id});
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
                return Ok(new { Token = token });
                //return Ok(new { user.Email, roles });
            }

            return Unauthorized(new {Message ="Invalid Login attempt."});
        }

        [HttpPost]
        [Route("/sendEmails")]
        public async Task<IActionResult> SendEmails(string receptor, string subject, string body)
        {
            await _emailService.SendEmail(receptor, subject, body);
            return Ok();
        }

        [HttpGet]
        [Route("/emailConfirmation")]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if(userId == null || token == null)
            {
                return BadRequest("Invalid Email confermation Request");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if(user == null)
            {
                return NotFound($"unable to find usre id '{userId}'");
            }
            var result = await _userManager.ConfirmEmailAsync(user, token);
            if(result.Succeeded)
            {
                return Ok("email confirmation is succeed");
            }
            return BadRequest("email confirmation faild");
        }



        [HttpPost]
        [Route("/registerUsersAdmin")]
        public async Task<IActionResult> registerUsers([FromBody] RegisterUserAdminDto request)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new IdentityUser { UserName = request.UserName, Email = request.Email };
            var result = await _userManager.CreateAsync(user, request.Password);

            if(result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, request.role);
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                // Generate confirmation link
                var confirmationLink = Url.Action(
                    nameof(ConfirmEmail),
                    "Auth",
                    new { userId = user.Id, token },
                    Request.Scheme
                );

                // Send email
                var emailBody = $"Please confirm your email by clicking the following link: <a href='{confirmationLink}'>Confirm Email</a>";
                await _emailService.SendEmail(user.Email, "Email Confirmation", emailBody);


                switch (request.role)
                {
                    case "Admin":
                        var Admin = new AdminEntity
                        {
                            FullName = request.fullName,
                            PhoneNumber = request.phoneNubmer,
                            UserId = user.Id,

                        };
                        await _dbContext.AddAsync(Admin);
                        await _dbContext.SaveChangesAsync();
                        
                        break;
                    case "Chef":
                        var Chef = new ChefEntity
                        {
                            FullName = request.fullName,
                            PhoneNumber = request.phoneNubmer,
                            UserId = user.Id,

                        };
                        await _dbContext.AddAsync(Chef);
                        await _dbContext.SaveChangesAsync();
                        break;
                    case "DeliveryPerson":
                        var DeliveryPerson = new DeliveryPerson
                        {
                            FullName = request.fullName,
                            PhoneNumber = request.phoneNubmer,
                            

                        };
                        await _dbContext.AddAsync(DeliveryPerson);
                        await _dbContext.SaveChangesAsync();
                        break;
                    case "Waiter":
                        var Waiter = new WaiterEntity
                        {
                            FullName = request.fullName,
                            PhoneNumber = request.phoneNubmer,
                            UserId = user.Id,

                        };
                        await _dbContext.AddAsync(Waiter);
                        await _dbContext.SaveChangesAsync();
                        break;
                   
                }

                return Ok(new { confirmationCode = token, userId = user.Id, role=request.role });

            }

            var errors = result.Errors.Select(e => e.Description).ToList();
            foreach (var error in result.Errors)
            {
                _logger.LogError("Registration Error : {Error}", error.Description);
            }

            return BadRequest(new { Errors = errors });

        }

        [HttpPost]
        [Route("forgotPassword")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgetPasswordDto request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                return NotFound("No user associated with this email.");
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var resetLink = $"http://localhost:5173/resetPassword?userId={user.Id}&token={Uri.EscapeDataString(token)}";

            await _emailService.SendEmail(
                user.Email,
                "Password Reset",
                $"Click <a href='{resetLink}'>here</a> to reset your password."
            );

            return Ok(new {token,user.Id});
        }


        [HttpPost]
        [Route("resetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto request)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user == null)
            {
                return NotFound("Invalid user ID.");
            }

            var result = await _userManager.ResetPasswordAsync(user, request.Token, request.NewPassword);
            if (result.Succeeded)
            {
                return Ok("Password reset successful.");
            }

            return BadRequest("Password reset failed.");
        }



    }
}
