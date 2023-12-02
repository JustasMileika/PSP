using Microsoft.AspNetCore.Mvc;
using Commons;
using CheckoutService.Model;

namespace CheckoutService.Controllers
{
    [Route("api/checkout")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        [HttpPost("{payementId}")]
        public Payment Checkout(Guid payementId, [FromQuery] int amount,[FromQuery] PaymentType paymentType, [FromQuery] List<GiftCard> giftCards)
        {
            return new Payment();
        }
        [HttpGet("{payementId}")]
        public Payment GetCheckout(Guid payementId)
        {
            return new Payment();
        }

        [HttpPut("{payementId}/{GiftCardId}")]
        public Payment ApplyGiftCard(Guid payementId, Guid giftCardId)
        {
            return new Payment();
        }
    }
}
