using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

    [Route("api")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private List<string> productList = new List<string> { "Alma", "Heyva", "Nar", "Banan", "Gilas" };

        [HttpGet("products")]
        public List<string> GetProductList()
        {
            return Ok(productList);
        }

        [HttpGet("test")]
        public ActionResult<string> Test()
        {
            return Ok("Product endpoint is alive");
        }
    }

