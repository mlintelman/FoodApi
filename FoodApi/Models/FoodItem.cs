namespace FoodApi.Models
{
    public class FoodItem
    {
        public int id {  get; set; }
        public string? name { get; set; }
        public string? description { get; set; } = null;
        public double serving_size_grams { get; set; } // in grams
        public double calories {  get; set; }
        public double carbs { get; set; }
        public double protein { get; set; }
        public double fat { get; set; }
    }
}
