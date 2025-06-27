using Microsoft.EntityFrameworkCore;
using Fiber.Api.Models;

namespace Fiber.Api.Data
{
    public class FiberDbContext : DbContext
    {
        public FiberDbContext(DbContextOptions<FiberDbContext> options)
            : base(options)
        {
        }

        // Add your DbSet properties here
         public DbSet<Gecko> Geckos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize entity mappings here if needed
        }
    }
}
