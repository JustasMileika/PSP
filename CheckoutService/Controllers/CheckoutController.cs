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
        public Payment CheckoutWithCash(int orderId, Price pricePayed)
        {
            return new Payment();
        }
    }
}
