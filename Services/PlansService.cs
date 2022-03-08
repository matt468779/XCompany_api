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

    public WeeklyPlan? GetWeeklyPlan(string username, int year, int month, int week){
        return _context.WeeklyPlans
            .Include(i => i.ItemQuantities)
            .AsNoTracking()
            .Where(w => w.Username == username && w.Year == year && w.Month == month && w.Week == week)
            .SingleOrDefault();
    }

    public MonthlyPlan? GetMonthlyPlan(string username, int year, int month){
        return _context.MonthlyPlans
            .Include(i => i.ItemQuantities)
            .AsNoTracking()
            .Where(m => m.Username == username && m.Year == year && m.Month == month)
            .SingleOrDefault();
    }

    public YearlyPlan? GetYearlyPlan(string username, int year){
        return _context.YearlyPlans
            .Include(i => i.ItemQuantities)
            .AsNoTracking()
            .Where(w => w.Username == username && w.Year == year)
            .SingleOrDefault();
    }
    public WeeklyPlan CreateWeeklyPlan(WeeklyPlan weeklyPlan, string Username){

        weeklyPlan.Username = Username;
        _context.WeeklyPlans.Add(weeklyPlan);
        _context.SaveChanges();

        return weeklyPlan;
    }

    public MonthlyPlan CreateMonthlyPlan(MonthlyPlan monthlyPlan, string Username){
        monthlyPlan.Username = Username;
        _context.MonthlyPlans.Add(monthlyPlan);

        _context.SaveChanges();

        return monthlyPlan;
    }

    public YearlyPlan CreateYearlyPlan(YearlyPlan yearlyPlan, string Username){

        yearlyPlan.Username = Username;
        _context.YearlyPlans.Add(yearlyPlan);

        _context.SaveChanges();

        return yearlyPlan;
    }

    
}