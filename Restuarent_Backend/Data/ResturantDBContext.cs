using Microsoft.EntityFrameworkCore;
using Restuarent_Backend.Models.CustomerEntity;
using Restuarent_Backend.Models.LoginHistoryEntity;
using Restuarent_Backend.Models.MenuEntity;

namespace Restuarent_Backend.Data
{
    public class ResturantDBContext : DbContext
    {
        public ResturantDBContext(DbContextOptions<ResturantDBContext> options) :base(options)
        {
            
        }

        public DbSet<MenuTable> MenuItems { get; set; }
        public DbSet<CustomerProfile> CustomerProfiles { get; set; }
        public DbSet<LoginHistoryTable> LoginHistorys { get; set; }
        
    }
}
