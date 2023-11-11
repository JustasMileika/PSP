using Microsoft.AspNetCore.Mvc;

namespace LoyaltyService.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class LoyaltyProgramController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<LoyaltyProgram> Get()
        {
            return new LoyaltyProgram[] {};
        }

        // TODO: ADD ENDPOINT TO CHECK PRODUCT QUANTITIES - USED BY ORDER SERVICE

        [HttpGet("{id}")]
        public LoyaltyProgram Get(int id)
        {
            return new LoyaltyProgram();
        }

        [HttpPost]
        public LoyaltyProgram Post([FromBody] LoyaltyProgram value)
        {
            return new LoyaltyProgram();
        }

        [HttpPut("{id}")]
        public LoyaltyProgram Put(int id, [FromBody] LoyaltyProgram value)
        {
            return new LoyaltyProgram();
        }

        [HttpDelete("{id}")]
        public LoyaltyProgram Delete(int id)
        {
            return new LoyaltyProgram();
        }
    }
}
