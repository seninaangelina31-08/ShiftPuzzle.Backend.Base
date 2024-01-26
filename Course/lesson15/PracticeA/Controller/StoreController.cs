using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace YourProjectNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private static List<string> _products = new List<string>();

        [HttpPost("add")]
        public IActionResult AddProduct(string productName)
        {
            _products.Add(productName);
            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult DeleteProduct(string productName)
        {
            _products.Remove(productName);
            return Ok();
        }

        [HttpGet("list")]
        public IActionResult GetProductList()
        {
            return Ok(_products);
        }
    }
}