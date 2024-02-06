using Microsoft.EntityFrameworkCore;

namespace DistributeurBoissons.Models
{
    public class DrinkDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DrinkDbContext(DbContextOptions<DrinkDbContext> options): base(options)
        {
        
        }
    }
}
