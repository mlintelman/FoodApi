namespace FoodApi.Models
{
    public class Meals
    {
        public int id { get; set; } // Unique identifier for the meal
        public int user_id { get; set; } // Foreign key to TempUsers
        public string? name { get; set; } // Name of the meal
        public string? notes { get; set; } // Notes of the meal
        public DateTime date_time { get; set; } // Date of the meal
    }
}
