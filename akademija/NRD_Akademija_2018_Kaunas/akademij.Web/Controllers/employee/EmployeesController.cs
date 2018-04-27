using akademij.Application.main.employee;
using Microsoft.AspNetCore.Mvc;

namespace akademij.Web.Controllers.employee
{
    [Route("/[controller]")]
    public class EmployeesController : Controller
    {
        protected readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employees = _employeeService.GetAllEmployees();
            return Ok(employees);
        }
    }
}
