using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XCompany_api.Models;

public class EmployeeWeeklyPlan
{
    public int? id { get; set; }
    [ForeignKey("Employee")]
    public int? EmployeeId { get; set; }
    [ForeignKey("WeeklyPlan")]

    public int? WeeklyPlanId { get; set; }
}

public class EmployeeMonthlyPlan
{
    public int? id { get; set; }
    [ForeignKey("Employee")]
    public int? EmployeeId { get; set; }
    [ForeignKey("MonthlyPlan")]
    public int? MonthlyPlanId { get; set; }
}

public class EmployeeYearlyPlan
{
    public int? id { get; set; }
    [ForeignKey("Employee")]
    public int? EmployeeId { get; set; }
    [ForeignKey("YearlyPlan")]
    public int? YearlyPlanId { get; set; }
}