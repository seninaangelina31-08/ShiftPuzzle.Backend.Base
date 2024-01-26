using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace YourProjectNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private static List<Product> _products = new List<Product>();

        [HttpPost("add")]
        public IActionResult AddProduct(Product product)
        {
            _products.Add(product);
            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult DeleteProduct(string productName)
        {
            var product = _products.FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                _products.Remove(product);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("list")]
        public IActionResult GetProductList()
        {
            return Ok(_products);
        }
    }
}




public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
}