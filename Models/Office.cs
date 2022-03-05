using System.ComponentModel.DataAnnotations;

namespace XCompany_api.Models;

public class Office
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    [Required]
    public string? Role { get; set; }
    
    //public ICollection<Topping>? Toppings { get; set; }
}