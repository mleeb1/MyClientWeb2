using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MyClientWeb2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET api/products
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "product1", "product2" };
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "product1";
        }

        // POST api/products
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/products/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
