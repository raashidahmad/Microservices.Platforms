using Microsoft.EntityFrameworkCore;

namespace Microservices.Platforms.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<PlatformRepo> Platforms { get; set; }
    }
}
