using XCompany_api.Services;
using XCompany_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace XCompany_api.Controllers;

// [Authorize(Roles = "Branch Manager,Main Office Manager,Sales Person")]
[ApiController]
[Route("[controller]")]
public class PlanController : ControllerBase {
    PlanService _service;

    public PlanController(PlanService service){
        _service = service;

    }

    [Authorize(Roles = "Sales Person")]
    [HttpPost("weekly")]

    public WeeklyPlan CreateWeeklyPlan(WeeklyPlan weeklyPlan){
        var username = User.FindFirstValue(ClaimTypes.Name);
        System.Console.WriteLine("--------------------" + username);
        return _service.CreateWeeklyPlan(weeklyPlan, username);
    }
        // [Route("weekly")]

    [Authorize(Roles = "Sales Person")]
    [HttpGet("weekly/{year}-{month}-{week}")]

    public WeeklyPlan? GetWeeklyPlan(int year, int month, int week){
        var username = User.FindFirstValue(ClaimTypes.Name);
        return _service.GetWeeklyPlan(username, year, month, week);
    }

    [Authorize(Roles = "Sales Person,Branch Manager")]
    [HttpPost("monthly")]
    public MonthlyPlan CreateMonthlyPlan(MonthlyPlan monthlyPlan){
        var username = User.FindFirstValue(ClaimTypes.Name);
        return _service.CreateMonthlyPlan(monthlyPlan, username);
    }

    [Authorize(Roles = "Sales Person,Branch Manager")]
    [HttpGet("monthly/{year}-{month}")]
    public MonthlyPlan? GetMonthlyPlan(int year, int month, int week){
        var username = User.FindFirstValue(ClaimTypes.Name);
        return _service.GetMonthlyPlan(username, year, month);
    }

    [Authorize(Roles = "Main Office Manager")]
    [HttpPost("yearly")]
    public YearlyPlan CreateYearlyPlan(YearlyPlan yearlyPlan){
        var username = User.FindFirstValue(ClaimTypes.Name);
        return _service.CreateYearlyPlan(yearlyPlan, username);
    }

    [Authorize(Roles = "Main Office Manager")]
    [HttpGet("yearly/{year}")]

    public YearlyPlan? GetYearlyPlan(int year){
        var username = User.FindFirstValue(ClaimTypes.Name);
        return _service.GetYearlyPlan(username, year);
    }
}