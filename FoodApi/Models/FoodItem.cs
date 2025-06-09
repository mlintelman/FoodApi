namespace FoodApi.Models
{
    public class FoodItem
    {
        public int Id {  get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; } = null;
        public double ServingSizeGrams { get; set; } // in grams
        public double Calories {  get; set; }
        public double Carbs { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
    }
}
