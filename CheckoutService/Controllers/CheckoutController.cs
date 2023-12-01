using Microsoft.AspNetCore.Mvc;
using Commons;
using CheckoutService.Model;

namespace CheckoutService.Controllers
{
    [Route("api/checkout")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        [HttpPost("cash/{orderId}")]
        public Payment CheckoutWithCash(Guid orderId, [FromBody] Price pricePayed)
        {
            return new Payment();
        }

        [HttpPost("card/{orderId}")]
        public Payment CheckoutWithCard(Guid orderId)
        {
            return new Payment();
        }

        [HttpPost("gift/{orderId}")]
        public Payment CheckoutWithGiftCard(Guid orderId, [FromBody] Guid giftCardId)
        {
            return new Payment();
        }

        [HttpPost("loyalty/{orderId}")]
        public Payment CheckoutWithLoyaltyPoints(Guid orderId)
        {
            return new Payment();
        }
    }
}
