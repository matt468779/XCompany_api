using XCompany_api.Models;
using XCompany_api.Data;
using Microsoft.EntityFrameworkCore;

namespace XCompany_api.Services;

public class ReportService
{
    private readonly CompanyContext _context;
    public ReportService(CompanyContext context)
    {
        _context = context;
    }

    public IEnumerable<Sale> GetAll()
    {
        return _context.Sales.AsNoTracking().ToList();
    }
    
    public IEnumerable<Sale> weeklyReportUnit(int year, int month, int week, int unitId){
        DateOnly firstMonday = new DateOnly(year, month, 1);
        firstMonday = firstMonday.AddDays((int)DayOfWeek.Monday - (int)firstMonday.DayOfWeek);
        DateOnly weekMonday = firstMonday.AddDays((week-1)*7);
        DateOnly weekSunday = weekMonday.AddDays(6);

        
        return _context.Sales
            .Include(s => s.ItemQuantity)
            .AsNoTracking()
            .Where(s => s.unitId == unitId && weekMonday <= DateOnly.FromDateTime((DateTime)s.Date!)  && weekSunday >= DateOnly.FromDateTime((DateTime)s.Date!))
            .ToList();
    }

    private int compareDate(DateOnly firstDate, DateOnly secondDate){
        return firstDate.CompareTo(secondDate);
    }

    public IEnumerable<IEnumerable<Sale>> monthlyReportUnit(int year, int month, int unitId){
        List<List<Sale>> report = new List<List<Sale>>{};
        for (int i = 1; i <= 4; i++){
            report.Add(weeklyReportUnit(year, month, i, unitId).ToList());
        }
        return report;
    }
    
    public IEnumerable<IEnumerable<IEnumerable<Sale>>> yearlyReportUnit(int year, int unitId){
        List<IEnumerable<IEnumerable<Sale>>> report = new List<IEnumerable<IEnumerable<Sale>>>{};
        for (int i = 1; i <= 12; i++){
            report.Add(monthlyReportUnit(year, i, unitId));
        }
        return report;
    }

    public IEnumerable<Sale> GetByEmployee(int employeeId){
        return _context.Sales
            .Include(s => s.ItemQuantity)
            .AsNoTracking()
            .Where(s => s.EmployeeId == employeeId)
            .ToList();
    }

    public IEnumerable<Sale> GetByDate(DateOnly date){
        return _context.Sales
            .Include(s => s.ItemQuantity)
            .AsNoTracking()
            .Where(s => date.CompareTo(s.Date) == 0)
            .ToList();
    }

}
