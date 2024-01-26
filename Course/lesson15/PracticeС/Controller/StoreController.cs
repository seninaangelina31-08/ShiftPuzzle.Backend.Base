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

        [HttpPost("updateprice")]
        public IActionResult UpdatePrice(string productName, decimal newPrice)
        {
            var product = _products.FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                product.Price = newPrice;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("updatename")]
        public IActionResult UpdateName(string productName, string newName)
        {
            var product = _products.FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                product.Name = newName;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("outofstock")]
        public IActionResult GetOutOfStockProducts()
        {
            var outOfStockProducts = _products.Where(p => !p.IsAvailable).ToList();
            return Ok(outOfStockProducts);
        }
    }
}




public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
}