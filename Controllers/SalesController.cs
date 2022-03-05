using XCompany_api.Services;
using XCompany_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace XCompany_api.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class SalesController : ControllerBase {

    SalesService _service;

    public SalesController(SalesService service){
        _service = service;
    }

    [HttpGet]
    public IEnumerable<Sale> GetAll(){
        return _service.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Sale> GetById(int id){

        var sale = _service.GetById(id);
        if (sale is not null){
            return sale;
        }
        else {
            return NotFound();
        }
    }
    
    [HttpPost]
    public IActionResult CreateReport(Sale newSale){
        var sale = _service.Record(newSale);
        return CreatedAtAction(nameof(GetById), new { id = sale!.Id }, sale);
    }

}