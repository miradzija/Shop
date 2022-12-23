using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class ShopList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
    }
}
