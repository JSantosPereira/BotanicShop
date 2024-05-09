/* ###############################################################################################################
    ?? Bool to check if product is sellable
    
##################################################################################################################*/
using System.ComponentModel.DataAnnotations;
namespace BotanicShop.Models
{
    public class Product
    {
        // ###############################################################################################################
        
        [Required] 
        public string Id { get; set; } 

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string? Description { get; set; }

        [Required]
        public static int Quantity { get; set; } =0;
        
        [Required]
        public decimal Price { get; set; }

        public string? ImageURL { get; set; }

        public List<String>? ProductTag { get; set; }

        // ###############################################################################################################
        public Product(string name, string description, int quantity, decimal price, List<string> tags)
        {
            Id = Guid.NewGuid().ToString();
            this.Name = name;
            this.Description = description!=null ? this.Description : "";
            Quantity += quantity;
            this.Price = price;
            ProductTag = tags;
        }
    
        public Product(string name, string description) { 
            Id = Guid.NewGuid().ToString();
            this.Name=name;
            this.Description = description!=null ? this.Description : "";
        }
        // ###############################################################################################################
        public override string ToString()
        {
            return Name +"\n"+ Description;
        }
    }
}
