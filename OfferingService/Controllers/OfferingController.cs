using Microsoft.AspNetCore.Mvc;
using OfferingService.Model;

namespace ProductService.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class OfferingController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Offering> Get()
        {
            return new Offering[] {};
        }

        // TODO: ADD ENDPOINT TO CHECK PRODUCT QUANTITIES - USED BY ORDER SERVICE

        [HttpGet("{id}")]
        public Offering Get(Guid id)
        {
            return new Offering();
        }

        [HttpGet("quantity")]
        public IEnumerable<Stock> ListStock([FromQuery] IEnumerable<Guid> productId)
        {
            return new Stock[1];
        }

        [HttpPost]
        public Offering Post([FromBody] Offering value)
        {
            return new Offering();
        }

        [HttpPut("{id}")]
        public Offering Put(Guid id, [FromBody] Offering value)
        {
            return new Offering();
        }

        [HttpDelete("{id}")]
        public Offering Delete(Guid id)
        {
            return new Offering();
        }
    }
}
