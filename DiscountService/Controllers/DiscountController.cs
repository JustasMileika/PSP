using Microsoft.AspNetCore.Mvc;
using DiscountService.Model;

namespace DiscountService.Controllers
{
    [Route("api/discount")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Discount> Get()
        {
            return new Discount[] {};
        }

        [HttpGet("{id}")]
        public Discount Get(Guid id)
        {
            return new Discount();
        }

        [HttpGet("product")]
        public IEnumerable<Discount> ListStock([FromQuery] IEnumerable<Guid> productId)
        {
            return new Discount[1];
        }

        [HttpPost]
        public Discount Post([FromBody] Discount value)
        {
            return new Discount();
        }

        [HttpPut("{id}")]
        public Discount Put(Guid id, [FromBody] Discount value)
        {
            return new Discount();
        }

        [HttpDelete("{id}")]
        public Discount Delete(Guid id)
        {
            return new Discount();
        }
    }
}
