using System.ComponentModel.DataAnnotations;

namespace XCompany_api.Models;

public class WeeklyPlan
{
    [Key]
    public int? Id { get; set; } 

    public string? Username { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Week { get; set; }
    public double? Total { get; set; }

    public int? Customers { get; set; }

    public ICollection<ItemQuantity>? ItemQuantities { get; set; }

}

public class MonthlyPlan
{
    [Key]
    public int? Id { get; set; } 

    public string? Username { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public double? Total { get; set; }

    public int? Customers { get; set; }

    public int? UnitId { get; set; }

    public ICollection<ItemQuantity>? ItemQuantities { get; set; }

}

public class YearlyPlan
{
    [Key]
    public int? Id { get; set; } 

    public string? Username { get; set; }

    public int? Year { get; set; }

    public double? Total { get; set; }

    public int? Customers { get; set; }

    public int? BranchId { get; set; }

    public ICollection<ItemQuantity>? ItemQuantities { get; set; }

}

