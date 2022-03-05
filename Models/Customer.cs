using System.ComponentModel.DataAnnotations;

namespace XCompany_api.Models;

public class Customer
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    public string? Email { get; set; }

    [Required]
    public String? Address { get; set; }

    //public ICollection<Topping>? Toppings { get; set; }
}