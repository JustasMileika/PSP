using Microsoft.AspNetCore.Mvc;

namespace NotificationService.Controllers
{
    [Route("api/notification")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        [HttpPost("orderPayed")]
        public void HandleOrderPayed()
        {
            
        }

        [HttpPost("orderCompleted")]
        public void HandleOrderCompleted()
        {

        }

        [HttpPost("orderPrepared")]
        public void HandleOrderPrepared()
        {

        }
    }
}
