using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XCompany_api.Models;

public class Employee
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    public string? Username { get; set; }

    [Required]
    public String? Role { get; set; }
    [ForeignKey("Office")]
    public int? OfficeId { get; set; }
    [ForeignKey("Unit")]
    public int? UnitId { get; set; }

    //public ICollection<Topping>? Toppings { get; set; }
}

public class Capability
{
    public int? Id { get; set; }
    public string? Role { get; set; }

    public string? Plans { get; set; }
}