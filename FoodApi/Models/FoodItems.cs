using System.ComponentModel.DataAnnotations.Schema;

namespace FoodApi.Models
{
    [Table("food_items")]
    public class FoodItems
    {
        [Column("id")]
        public int Id {  get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("description")]
        public string? Description { get; set; } = null;

        [Column("serving_size_grams")]
        public double ServingSizeGrams { get; set; } // in grams

        [Column("calories")]
        public double Calories {  get; set; }

        [Column("carbs")]
        public double Carbs { get; set; }

        [Column("protein")]
        public double Protein { get; set; }

        [Column("fat")]
        public double Fat { get; set; }
    }
}
