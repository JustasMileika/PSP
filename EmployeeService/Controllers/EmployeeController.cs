using EmployeeService.Model;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.Controllers
{
    [Route("api/Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        public Employee AddReservation([FromQuery] Employee tax)
        {
            return new Employee();
        }

        [HttpGet("{EmployeeId}")]
        public Employee GetReservation(Guid EmployeeId)
        {
            return new Employee();
        }

        [HttpGet]
        public IEnumerable<Employee> GetAllTaxes()
        {
            return new Employee[] { };
        }

        [HttpPut("{EmployeeId}")]
        public Employee EditReservation(Guid EmployeeId)
        {
            return new Employee();
        }

        [HttpDelete("{EmployeeId}")]
        public void DeleteReservation(Guid EmployeeId)
        {
        }
    }
}
