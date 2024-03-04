using anguarCrudBackend.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace anguarCrudBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly EmployeeRepository _employeeRepository;

        public EmployeeController(EmployeeRepository employeeRepository) 
        {
            _employeeRepository = employeeRepository;
        }

        [HttpPost]
        public async Task<ActionResult>  AddEmployee([FromBody] Employee model)
        {
           await _employeeRepository.AddEmployee(model);
           return Ok();


        }

    }
}
