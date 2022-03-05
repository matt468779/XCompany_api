using XCompany_api.Models;
using XCompany_api.Data;
using Microsoft.EntityFrameworkCore;

namespace XCompany_api.Services;

public class PlanService
{
    private readonly CompanyContext _context;
    public PlanService(CompanyContext context)
    {
        _context = context;
    }

    public WeeklyPlan CreateWeeklyPlan(WeeklyPlan weeklyPlan){

        _context.WeeklyPlans.Add(weeklyPlan);
        _context.SaveChanges();

        return weeklyPlan;
    }

    public MonthlyPlan CreateMonthlyPlan(MonthlyPlan monthlyPlan){

        _context.MonthlyPlans.Add(monthlyPlan);
        _context.SaveChanges();

        return monthlyPlan;
    }

    public YearlyPlan CreateYearlyPlan(YearlyPlan yearlyPlan){

        _context.YearlyPlans.Add(yearlyPlan);
        _context.SaveChanges();

        return yearlyPlan;
    }
}