using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        //dbContext connection
        private readonly ResturantDBContext _dbContext;
        public AuthController(ResturantDBContext dbContext)
        {
            _dbContext = dbContext;
        }




        }
}
