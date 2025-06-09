using System.ComponentModel.DataAnnotations.Schema;

namespace FoodApi.Models
{
    [Table("temp_users")]
    public class TempUsers
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }
    }
}
