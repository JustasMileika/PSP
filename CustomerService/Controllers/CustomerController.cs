using CustomerService.Model;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return new Customer[] {};
        }

        // TODO: ADD ENDPOINT TO CHECK PRODUCT QUANTITIES - USED BY ORDER SERVICE

        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return new Customer();
        }

        [HttpPost]
        public Customer Post([FromBody] Customer value)
        {
            return new Customer();
        }

        [HttpPut("{id}")]
        public Customer Put(int id, [FromBody] Customer value)
        {
            return new Customer();
        }

        [HttpDelete("{id}")]
        public Customer Delete(int id)
        {
            return new Customer();
        }
    }
}
