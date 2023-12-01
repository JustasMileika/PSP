using Microsoft.AspNetCore.Mvc;
using OrderService.Model;

namespace OrderService.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return new Order[] {};
        }

        [HttpGet("{id}")]
        public Order Get(Guid id)
        {
            return new Order();
        }

        [HttpGet("{customerId}")]
        public Order GetCustomerOrders(Guid customerId)
        {
            return new Order();
        }

        [HttpPost]
        public Order Post([FromBody] Order value)
        {
            return new Order();
        }

        [HttpPut("{id}")]
        public Order UpdateStatus(Guid id, [FromBody] OrderStatus orderStatus)
        {
            return new Order();
        }

        [HttpDelete("{id}")]
        public Order Delete(Guid id)
        {
            return new Order();
        }

    }
}
