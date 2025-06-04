namespace FoodApi.Models
{
    public class MealItems
    {
        public int id { get; set; } // Unique identifier for the meal item
        public int meal_id { get; set; } // Foreign key to Meals
        public int food_item_id { get; set; } // Foreign key to FoodItem
        public string? name { get; set; } // Name of the food item
        public double serving_size_grams { get; set; } // Serving size in grams
        public double calories { get; set; } // Calories for the serving size
        public double carbs { get; set; } // Carbohydrates for the serving size
        public double protein { get; set; } // Protein for the serving size
        public double fat { get; set; } // Fat for the serving size
    }
}
