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
        public Order Get(int id)
        {
            return new Order();
        }

        [HttpPost]
        public Order Post([FromBody] Order value)
        {
            return new Order();
        }

        [HttpPut("{id}")]
        public Order UpdateStatus(int id, [FromBody] OrderStatus orderStatus)
        {
            return new Order();
        }

        [HttpDelete("{id}")]
        public Order Delete(int id)
        {
            return new Order();
        }

    }
}
