using Microsoft.AspNetCore.Mvc;
using Service;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IServiceEmployee serviceEmployee;

        public EmployeeController(IServiceEmployee serviceEmployee)
        {
            this.serviceEmployee = serviceEmployee;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Get()
        {
            var employees = await serviceEmployee.GetAsync();

            return Ok(employees);
        }
    }
}
