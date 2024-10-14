using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Restuarent_Backend.Controllers
{
    [Authorize(Roles = "Customer")]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetReservatonInfor()
        {
            var resevation = "you accessed the reservation page";
            return Ok(resevation);
        }

    }
}
