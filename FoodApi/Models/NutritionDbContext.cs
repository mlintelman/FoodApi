using Microsoft.EntityFrameworkCore;

namespace FoodApi.Models
{
    public class NutritionDbContext : DbContext
    {
        public NutritionDbContext(DbContextOptions<NutritionDbContext> options) : base(options)
        {
        }

        public DbSet<FoodItem> FoodItems { get; set; } = null!;
    }
}
