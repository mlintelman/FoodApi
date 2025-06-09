namespace FoodApi.Models
{
    public class Meals
    {
        public int Id { get; set; } // Unique identifier for the meal
        public int UserId { get; set; } // Foreign key to TempUsers
        public string? Name { get; set; } // Name of the meal
        public string? Notes { get; set; } // Notes of the meal
        public DateTime DateTime { get; set; } // Date of the meal
    }
}
