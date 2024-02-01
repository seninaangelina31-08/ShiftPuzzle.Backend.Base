using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace PrB.Controllers
public class Product
{
    public string _name { get; set; }
    public int _price { get; set; }
    public int _isAvalible { get; set; }
    public Product(){}
    public Product(string a,int b, int c ){this._name=a; this._price=b;this._isAvalible=c;}
}
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private static List<Product> productList = new List<Product>();

        [HttpPost("add")]
        public Product AddProduct(Product product)
        {
            productList.Add(product);
            return product;
        }

        [HttpPost("delete")]
        public Product DeleteProduct(string productName)
        {
            var product = productList.FirstOrDefault(p => p._name == productName);
            if (product != null)
            {
                productList.Remove(product);
                return product;
            }
            else
            {
                return null;
            }
        }

        [HttpGet("list")]
        public List<Product> GetProductList()
        {
            return productList;
        }
    }
}

