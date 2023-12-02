using Microsoft.AspNetCore.Mvc;
using TaxService.Model;

namespace TaxService.Controllers
{
    [Route("api/tax")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        [HttpPost]
        public Tax AddReservation([FromQuery] Tax tax)
        {
            return new Tax();
        }

        [HttpGet("{taxId}")]
        public Tax GetReservation(Guid taxId)
        {
            return new Tax();
        }

        [HttpGet]
        public IEnumerable<Tax> GetAllTaxes() 
        {
            return new Tax[] {};
        }

        [HttpPut("{taxId}")]
        public Tax EditReservation(Guid taxId)
        {
            return new Tax();
        }

        [HttpDelete("{taxId}")]
        public void DeleteReservation(Guid taxId)
        {
        }
    }
}
