using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfferingService.Model;

namespace OfferingService.Controllers
{
    [Route("api/inventory")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Inventory> Index()
        {
            return new Inventory[] { };
        }

        [HttpGet("{inventoryId}")]
        public Inventory Create()
        {
            return new Inventory();
        }

        [HttpPost]
        public Inventory Create([FromQuery] Inventory inventory)
        {
            return new Inventory();
        }

        [HttpPut("{inventoryId}")]
        public Inventory Edit(Guid id)
        {
            return new Inventory();
        }

        [HttpDelete("{inventoryId}")]
        public Inventory Delete(Guid id)
        {
            return new Inventory();
        }
    }
}
