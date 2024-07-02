using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

    [Route("api")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [Route("hello")]
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello C# Api";
        }
    }

