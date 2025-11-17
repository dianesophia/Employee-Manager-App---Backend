using Employee_Manager_System_App.Model;
using Employee_Manager_System_App.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

//I tried to use the stored procedure here
public class EmployeeController : ControllerBase
{
    private readonly EmployeeService _employeeService;

    public EmployeeController(EmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var employees = await _employeeService.GetEmployeesAsync();
        return Ok(employees);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Employee employee)
    {
        await _employeeService.AddEmployeeAsync(employee);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Employee employee)
    {
        employee.Id = id;
        await _employeeService.UpdateEmployeeAsync(employee);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _employeeService.DeleteEmployeeAsync(id);
        return Ok();
    }
}
