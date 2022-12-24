using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class ShopList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Dreska")]
        public string ProductName { get; set; }
        public string Size { get; set; }
        [Range(1, 20000, ErrorMessage = "Mnogo to pare bate!!!")]
        public double Price { get; set; }
    }
}
