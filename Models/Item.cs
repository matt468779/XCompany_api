using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XCompany_api.Models;

public class Item
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    public double? Price { get; set; }
    
    public String? description { get; set; }
    
    //public ICollection<Topping>? Toppings { get; set; }
}

public class ItemQuantity
{
    public int Id { get; set; }
    [ForeignKey("Item")]
    public int? ItemId { get; set; }

    public int? quantity { get; set; }
}