using System.ComponentModel.DataAnnotations.Schema;

namespace FoodApi.Models
{
    [Table("meal_items")]
    public class MealItems
    {
        [Column("id")]
        public int Id { get; set; } // Unique identifier for the meal item

        [Column("meal_id")]
        public int MealId { get; set; } // Foreign key to Meals

        [Column("food_item_id")]
        public int FoodItemId { get; set; } // Foreign key to FoodItem

        [Column("name")]
        public string? Name { get; set; } // Name of the food item

        [Column("serving_size_grams")]
        public double ServingSizeGrams { get; set; } // Serving size in grams

        [Column("servings")]
        public double Servings { get; set; } // Number of servings the user had

        [Column("calories")]
        public double Calories { get; set; } // Calories for the serving size

        [Column("carbs")]
        public double Carbs { get; set; } // Carbohydrates for the serving size

        [Column("protein")]
        public double Protein { get; set; } // Protein for the serving size

        [Column("fat")]
        public double Fat { get; set; } // Fat for the serving size
    }
}
