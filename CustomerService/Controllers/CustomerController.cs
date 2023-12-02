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

        // TODO: ADD ENDPOINT TO CHECK Offering QUANTITIES - USED BY ORDER SERVICE

        [HttpGet("{customerId}")]
        public Customer Get(Guid customerId)
        {
            return new Customer();
        }

        [HttpPost]
        public Customer Post([FromBody] Customer value)
        {
            return new Customer();
        }

        [HttpPut("{customerId}")]
        public Customer Put(Guid customerId, [FromBody] Customer value)
        {
            return new Customer();
        }

        [HttpPut("{customerId}/{ReservationId}")]
        public Customer AddRezervation(Guid customerId, Guid reservationId)
        {
            return new Customer();
        }

        [HttpPut("{customerId}/{OrderId}")]
        public Customer AddOrder(Guid customerId, Guid orderId)
        {
            return new Customer();
        }

        [HttpDelete("{customerId}")]
        public void Delete(int id)
        {
        }
    }
}
