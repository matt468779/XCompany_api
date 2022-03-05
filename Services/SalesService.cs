using XCompany_api.Models;
using XCompany_api.Data;
using Microsoft.EntityFrameworkCore;

namespace XCompany_api.Services;

public class SalesService
{
    private readonly CompanyContext _context;
    public SalesService(CompanyContext context)
    {
        _context = context;
    }

    public IEnumerable<Sale> GetAll()
    {
        return _context.Sales.AsNoTracking().ToList();
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
    
    public Sale? GetById(int id){
        return _context.Sales
            .Include(s => s.ItemQuantity)
            .AsNoTracking()
            .SingleOrDefault( s => s.Id == id);
    }
    
    public Sale? Record(Sale newSale){
        _context.Sales.Add(newSale);
        _context.SaveChanges();

        return newSale;
    }

}
