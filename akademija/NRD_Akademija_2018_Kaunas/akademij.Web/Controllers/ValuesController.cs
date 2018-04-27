using akademij.EF.repositories;
using Microsoft.AspNetCore.Mvc;

namespace akademij.Web.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        protected readonly IEmployeeRepository _employeeRepository;
        public ValuesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        // GET api/values
        [HttpGet]
        public void Get()
        {
            _employeeRepository.GetEmployees();
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
