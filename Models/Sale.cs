using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XCompany_api.Models;

public class Sale
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public ICollection<ItemQuantity>? ItemQuantity { get; set; }

    [Required]
    public DateTime? Date { get; set; }

    [Required]
    [ForeignKey("Employee")]
    public int? EmployeeId { get; set; }
    [ForeignKey("Customer")]
    public int? CustomerId { get; set; }
    [ForeignKey("Unit")]
    public int? unitId { get; set; }
    
    //public ICollection<Topping>? Toppings { get; set; }
}