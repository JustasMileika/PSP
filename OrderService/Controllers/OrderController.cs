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

        [HttpGet("{orderId}")]
        public Order Get(int id)
        {
            return new Order();
        }

        [HttpPost]
        public Order Post([FromBody] Order value)
        {
            return new Order();
        }

        [HttpPut("{orderId}")]
        public Order UpdateStatus(Guid id, [FromBody] OrderStatus orderStatus)
        {
            return new Order();
        }

        [HttpPut("{OrderId}/{DiscountId}")]
        public Order ApplyDiscountToOrder(Guid orderId, Guid discountId)
        {
            return new Order();
        }

        [HttpPut("{OrderId}/{EmployeeId}")]
        public Order AddEmployeeToOrder(Guid orderId, Guid employeeId)
        {
            return new Order();
        }

        [HttpDelete("{orderId}")]
        public void Delete(int id)
        {
        }

        [HttpPut("{OrderId}/{PaymentId}")]
        public Order PayForOrder(Guid orderId, Guid paymentId)
        {
            return new Order();
        }

    }
}
