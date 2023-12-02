using CheckoutService.Model;
using Microsoft.AspNetCore.Mvc;

namespace GiftCardService.Controllers
{
    [Route("api/giftcard")]
    [ApiController]
    public class GiftCardController : ControllerBase
    {
        [HttpPost]
        public GiftCard AddReservation([FromQuery] GiftCard giftCard)
        {
            return new GiftCard();
        }

        [HttpGet("{giftCardId}")]
        public GiftCard GetReservation(Guid giftCardId)
        {
            return new GiftCard();
        }

        [HttpPut("{giftCardId}")]
        public GiftCard EditReservation(Guid giftCardId)
        {
            return new GiftCard();
        }

        [HttpDelete("{giftCardId}")]
        public void DeleteReservation(Guid giftCardId)
        {
        }
    }
}
