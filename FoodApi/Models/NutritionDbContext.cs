using Microsoft.EntityFrameworkCore;
using FoodApi.Models;

namespace FoodApi.Models
{
    public class NutritionDbContext : DbContext
    {
        public NutritionDbContext(DbContextOptions<NutritionDbContext> options) : base(options)
        {
        }

        public DbSet<FoodItem> FoodItems { get; set; } = null!;
        public DbSet<FoodApi.Models.MealItems> MealItems { get; set; } = default!;
        public DbSet<FoodApi.Models.Meals> Meals { get; set; } = default!;
        public DbSet<FoodApi.Models.TempUsers> TempUsers { get; set; } = default!;
    }
}
