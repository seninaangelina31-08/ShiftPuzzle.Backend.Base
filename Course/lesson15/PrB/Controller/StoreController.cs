using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public class Product
{
    public string _name { get; set; }
    public int _price { get; set; }
    public int _isAvalible { get; set; }
    public Product(){}
    public Product(string a,int b, int c ){this._name=a; this._price=b;this._isAvalible=c;}
}

namespace PrB.Controllers
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
    }
}

