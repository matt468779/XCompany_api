using XCompany_api.Services;
using XCompany_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace XCompany_api.Controllers;

// [Authorize(Roles = "Branch Manager,Main Office Manager,Sales Person")]
[ApiController]
[Route("[controller]")]
public class ReportController : ControllerBase {
    ReportService _service;

    public ReportController(ReportService service){
        _service = service;
    }

    [HttpGet]
    public IEnumerable<Sale> GetAll(){
        return _service.GetAll();
    }

    [HttpGet("{unitId}/{year}-{month}-{week}")]
    public IEnumerable<Sale> GetWeeklyReportByUnit(int year, int month, int week, int unitId){
        var user = User.FindFirstValue(ClaimTypes.Name);
        return _service.weeklyReportUnit(year, month, week, unitId);
    }
    [HttpGet("{unitId}/{year}-{month}")]
    public IEnumerable<IEnumerable<Sale>> getMonthlyReportUnit(int year, int month, int unitId){
        return _service.monthlyReportUnit(year, month, unitId);
    }

    [HttpGet("{unitId}/{year}")]
    public IEnumerable<IEnumerable<IEnumerable<Sale>>> yearlyReportUnit(int year, int unitId){
        return _service.yearlyReportUnit(year, unitId);
    }


}