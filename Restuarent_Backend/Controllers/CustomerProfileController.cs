using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restuarent_Backend.Data;
using Restuarent_Backend.Dtos;
using Restuarent_Backend.Models;

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


        //[HttpGet("{menuItemId}")]
        //[Route("/getComments/{menuItemId}")]
        //public async Task<IActionResult> GetComments(string menuItemId)
        //{
        //    try
        //    {
        //        // Get the comments related to the specified menuItemId
        //        var commentTexts = await _dbContext.comments
        //            .Where(c => c.MenuItemId == menuItemId)
        //            .Select(c => c.Comments)
        //            .ToListAsync(); // Ensure DbContext is configured properly and comments is DbSet

        //        if (commentTexts == null || !commentTexts.Any())
        //        {
        //            return NotFound("No comments found for the specified menu item ID.");
        //        }

        //        return Ok(commentTexts);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Capture any exception that might be thrown and return a server error.
        //        return StatusCode(500, $"Internal server error: {ex.Message}");
        //    }
        //}

        [HttpPost]
        public async Task<IActionResult> AddComment([FromBody] CommentDto request)
        {
            var newComment = new Comment
            {
                MenuItemId = request.MenuItemId,
                Comments = request.Comments
            };
            _dbContext.comments.Add(newComment);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }


}
