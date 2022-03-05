using XCompany_api.Services;
using XCompany_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace XCompany_api.Controllers;

// [Authorize(Roles = "Branch Manager,Main Office Manager,Sales Person")]
[ApiController]
[Route("[controller]")]
public class PlanController : ControllerBase {
    PlanService _service;

    public PlanController(PlanService service){
        _service = service;
    }

    
}