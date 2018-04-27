using akademij.Application.main.employee;
using Microsoft.AspNetCore.Mvc;

namespace akademij.Web.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        protected readonly IEmployeeService _employeeService;
        public ValuesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var employees = _employeeService.GetAllEmployees();
            return Ok(employees);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
