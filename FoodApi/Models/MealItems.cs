namespace FoodApi.Models
{
    public class MealItems
    {
        public int Id { get; set; } // Unique identifier for the meal item
        public int MealId { get; set; } // Foreign key to Meals
        public int FoodItemId { get; set; } // Foreign key to FoodItem
        public string? Name { get; set; } // Name of the food item
        public double ServingSizeGrams { get; set; } // Serving size in grams
        public double Servings { get; set; } // Number of servings the user had
        public double Calories { get; set; } // Calories for the serving size
        public double Carbs { get; set; } // Carbohydrates for the serving size
        public double Protein { get; set; } // Protein for the serving size
        public double Fat { get; set; } // Fat for the serving size
    }
}
