namespace FoodApi.Models
{
    public class FoodItem
    {
        public long id {  get; set; }
        public string? name { get; set; }
        public string? description { get; set; } = null;
        public float calories {  get; set; }
        public float carbs { get; set; }
        public float protein { get; set; }
        public float fat { get; set; }
    }
}
