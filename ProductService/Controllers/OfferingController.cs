using Microsoft.AspNetCore.Mvc;
using OfferingService.Model;

namespace OfferingService.Controllers
{
    [Route("api/Offering")]
    [ApiController]
    public class OfferingController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Offering> Get()
        {
            return new Offering[] {};
        }

        [HttpGet("{OfferingId}")]
        public Offering Get(Guid id)
        {
            return new Offering();
        }

        [HttpPost]
        public Offering Post([FromBody] Offering value)
        {
            return new Offering();
        }

        [HttpPut("{OfferingId}/{DiscountId}")]
        public Offering ApplyDiscountToOffering(Guid OfferingId, Guid DiscountId)
        {
            return new Offering();
        }

        [HttpPut("{OfferingId}/{TaxId}")]
        public Offering ApplyTaxToOffering(Guid OfferingId, Guid taxId)
        {
            return new Offering();
        }

        [HttpPut("{OfferingId}")]
        public Offering Put(Guid id, [FromBody] Offering value)
        {
            return new Offering();
        }

        [HttpDelete("{OfferingId}")]
        public void Delete(Guid id)
        {
        }
    }
}
