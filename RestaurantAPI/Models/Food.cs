// Food.cs

using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{
    public class Food
    {
        [Key]
        public int foodId { get; set; }
        public required string foodName { get; set; }
        public int price { get; set; }
        public int stock { get; set; }
        public List<Transaction>? transactions { get; set; }
    }
}