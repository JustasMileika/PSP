using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        [HttpPost("login")]
        public string Login(string email, string password)
        {
            return "";
        }
    }
}
