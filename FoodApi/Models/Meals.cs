using System.ComponentModel.DataAnnotations.Schema;

namespace FoodApi.Models
{
    [Table("meals")]
    public class Meals
    {
        [Column("id")]
        public int Id { get; set; } // Unique identifier for the meal

        [Column("user_id")]
        public int UserId { get; set; } // Foreign key to TempUsers

        [Column("name")]
        public string? Name { get; set; } // Name of the meal

        [Column("notes")]
        public string? Notes { get; set; } // Notes of the meal

        [Column("date_time")]
        public DateTime DateTime { get; set; } // Date of the meal
    }
}
