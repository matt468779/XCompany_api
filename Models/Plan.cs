using System.ComponentModel.DataAnnotations;

namespace XCompany_api.Models;

public class WeeklyPlan
{
    public int? id { get; set; } 

    public int? Year { get; set; }

    public int? month { get; set; }

    public int? week { get; set; }
    public double? Total { get; set; }

    public int? Customers { get; set; }

    public ICollection<ItemQuantity>? ItemQuantities { get; set; }

}

public class MonthlyPlan
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public ICollection<WeeklyPlan>? WeeklyPlans { get; set; }
}

public class YearlyPlan
{
    [Key]
    public int? YearId { get; set; }

    public ICollection<MonthlyPlan>? MonthlyPlans { get; set; }
}

