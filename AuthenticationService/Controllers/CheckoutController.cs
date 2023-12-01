using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        [HttpPost("login")]
        public string Login([FromBody] string email, [FromBody] string password)
        {
            return "";
        }
    }
}
