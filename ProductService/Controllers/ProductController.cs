using Microsoft.AspNetCore.Mvc;
using ProductService.Model;

namespace ProductService.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new Product[] {};
        }

        // TODO: ADD ENDPOINT TO CHECK PRODUCT QUANTITIES - USED BY ORDER SERVICE

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return new Product();
        }

        [HttpPost]
        public Product Post([FromBody] Product value)
        {
            return new Product();
        }

        [HttpPut("{id}")]
        public Product Put(int id, [FromBody] Product value)
        {
            return new Product();
        }

        [HttpDelete("{id}")]
        public Product Delete(int id)
        {
            return new Product();
        }
    }
}
