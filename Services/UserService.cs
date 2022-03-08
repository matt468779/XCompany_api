using XCompany_api.Models;
using XCompany_api.Data;
using Microsoft.EntityFrameworkCore;

namespace XCompany_api.Services;

public class UserService
{
    private readonly CompanyContext _context;
    public UserService(CompanyContext context)
    {
        _context = context;
    }
    public Employee CompleteProfile(string username, Employee employee){
        employee.Username = username;
        _context.Employees.Add(employee);
        _context.SaveChanges();
        return employee;

    }
    public Employee UpdateProfile(string username, Employee employee){
        employee.Username = username;
        _context.Employees.Update(employee);
        _context.SaveChanges();
        return employee;
    }
    public Employee DeleteProfile(string username, Employee employee){
        employee.Username = username;
        _context.Employees.Remove(employee);
        _context.SaveChanges();
        return employee;
    }
}