using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
 
[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase{

    private readonly EmployeeService _service;

    public EmployeeController(EmployeeService service){
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(){
        var employees = await _service.GetAllEmployeesAsync();
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id){
        var employee = await _service.GetEmployeeByIdAsync(id);
        if(employee == null) return NotFound();
        return Ok(employee);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Employee employee){
        await _service.AddEmployeeAsync(employee);
        return CreatedAtAction(nameof(GetById), new {id = employee.PersonId}, employee);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Employee employee){
        if (id != employee.PersonId) return BadRequest();
        await _service.UpdateEmployeeAsync(employee);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id){
        await _service.DeleteEmployeeAsync(id);
        return NoContent()
    }
}