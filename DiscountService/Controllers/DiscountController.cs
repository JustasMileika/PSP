using DiscountService.Model;
using Microsoft.AspNetCore.Mvc;

namespace DiscountService.Controllers
{
    [Route("api/Discount")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Discount> Get()
        {
            return new Discount[] { };
        }

        // TODO: ADD ENDPOINT TO CHECK Offering QUANTITIES - USED BY ORDER SERVICE

        [HttpGet("{discountId}")]
        public Discount Get(Guid id)
        {
            return new Discount();
        }

        [HttpPost]
        public Discount Post([FromBody] Discount value)
        {
            return new Discount();
        }

        [HttpPut("{discountId}")]
        public Discount Put(Guid id, [FromBody] Discount value)
        {
            return new Discount();
        }

        [HttpDelete("{discountId}")]
        public Discount Delete(Guid id)
        {
            return new Discount();
        }
    }
}
