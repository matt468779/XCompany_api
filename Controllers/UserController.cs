using XCompany_api.Services;
using XCompany_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace XCompany_api.Controllers;

// [Authorize(Roles = "Branch Manager,Main Office Manager,Sales Person")]
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase {
    UserService _service;

    public UserController(UserService service){
        _service = service;
    }

    [Authorize(Roles = "Sales Person,Branch Manager,Main Office Manager")]
    [HttpPost]
    public Employee CompleteProfile(Employee employee){
        var username = User.FindFirstValue(ClaimTypes.Name);
        _service.CompleteProfile(username, employee);
        return employee;
    }

    [Authorize(Roles = "Sales Person,Branch Manager,Main Office Manager")]
    [HttpPut]
    public Employee UpdateProfile(Employee employee){
        var username = User.FindFirstValue(ClaimTypes.Name);
        _service.UpdateProfile(username, employee);
        return employee;
    }

    [Authorize(Roles = "Admin")]
    [HttpDelete]
    public void DeleteProfile(Employee employee, string username){
        _service.DeleteProfile(username, employee);
    }
}