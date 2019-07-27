using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyClientWeb2.Api.Models;

namespace MyClientWeb2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Cost = 10.50M },
                new Product { Id = 2, Name = "Product 2", Cost = 5.50M }
            };
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return new Product {Id = 1, Name = "Product 1", Cost = 10.50M};
        }

        // POST api/products
        [HttpPost]
        public void Post([FromBody] Product value)
        {
        }

        // PUT api/products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
        }

        // DELETE api/products/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
