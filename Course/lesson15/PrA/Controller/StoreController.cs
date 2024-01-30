using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PrA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private static List<string> productsList = new List<string>();

        [HttpPost("add")]
        public IActionResult AddProduct(string productName)
        {
            productsList.Add(productName);
            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult DeleteProduct(string productName)
        {
            productsList.Remove(productName);
            return Ok();
        }

        [HttpGet("list")]
        public IActionResult GetProductList()
        {
            return Ok(productsList);
        }
    }
}