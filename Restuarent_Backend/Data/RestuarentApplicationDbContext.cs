using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Restuarent_Backend.Data
{
    public class RestuarentApplicationDbContext : DbContext
    {
        public RestuarentApplicationDbContext(DbContextOptions<RestuarentApplicationDbContext> options) : base(options)
        {

        }
    }
}
