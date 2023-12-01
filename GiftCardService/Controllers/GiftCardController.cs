using Microsoft.AspNetCore.Mvc;
using GiftCardService.Model;

namespace GiftCardService.Controllers
{
    [Route("api/discount")]
    [ApiController]
    public class GiftCardController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<GiftCard> Get()
        {
            return new GiftCard[] {};
        }

        [HttpGet("{id}")]
        public GiftCard Get(Guid id)
        {
            return new GiftCard();
        }

        [HttpGet("product")]
        public IEnumerable<GiftCard> ListStock([FromQuery] IEnumerable<Guid> productId)
        {
            return new GiftCard[1];
        }

        [HttpPost]
        public GiftCard Post([FromBody] GiftCard value)
        {
            return new GiftCard();
        }

        [HttpPut("{id}")]
        public GiftCard Put(Guid id, [FromBody] GiftCard value)
        {
            return new GiftCard();
        }

        [HttpDelete("{id}")]
        public GiftCard Delete(Guid id)
        {
            return new GiftCard();
        }
    }
}
