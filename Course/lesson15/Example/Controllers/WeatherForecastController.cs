using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace PracticeA
{
    public class Product
    {
        public string Gamepad { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }

    public class StoreController : ControllerBase
    {
        private List<Product> _products = new List<Product>();

        [HttpPost("store/add")]
        [Produces("application/json")]
        
        public IActionResult AddProduct([FromBody] Product product)
        {
            _products.Add(product);
            return Ok();
        }
        
        [HttpDelete("store/delete/{GamepadName}")]
        [Produces("application/json")]
        public IActionResult DeleteProduct(string mouseName)
        {
            var product = _products.FirstOrDefault(p => p.Gamepad == GamepadName);
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

        [HttpGet("store/products")]
        [Produces("application/json")]
        public ActionResult<List<Product>> GetProducts()
        {
            return _products;
        }
    }
}