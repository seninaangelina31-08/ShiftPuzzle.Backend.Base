using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;



public class Product
{
    public string _name { get; set; }
    public decimal _price { get; set; }
    public bool _isAvalible { get; set; }
}
namespace YourProjectNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private static List<Product> productList = new List<Product>();

        [HttpPost("add")]
        public IActionResult AddProduct(Product product)
        {
            productList.Add(product);
            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult DeleteProduct(string productName)
        {
            var product = productList.FirstOrDefault(p => p._name == productName);
            if (product != null)
            {
                productList.Remove(product);
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
            return Ok(productList);
        }

        [HttpPost("updateprice")]
        public IActionResult UpdatePrice(string productName, decimal newPrice)
        {
            var product = productList.FirstOrDefault(p => p._name == productName);
            if (product != null)
            {
                product._price = newPrice;
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
            var product = productList.FirstOrDefault(p => p._name == productName);
            if (product != null)
            {
                product._name = newName;
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
            var outOfStockProducts = productList.Where(p => !p._isAvalible).ToList();
            return Ok(outOfStockProducts);
        }
    }
}



