using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public class Product
{
    public string name { get; set; }
    public int price { get; set; }
    public bool InStock { get; set; }
    public Product(){}
    public Product(string name, int price, bool InStock)
    {
        this.name = name;
        this.price = price;
        this.inStock = InStock;
    }
}

[ApiController]
[Route("api/[controller]")]
public class StoreController : ControllerBase
{
    private List<string> products = new List<string>();

    [HttpPost]
    [Route("add")]
    public IActionResult AddProduct(string product)
    {
        products.Add(product);
        return Ok();
    }

    [HttpPost]
    [Route("delete")]
    public IActionResult DeleteProduct(string product)
    {
        Product product = productList.Find(p => p.Name == name);
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

    [HttpGet]
    [Route("list")]
    public IActionResult GetProductList()
    {
        if (products.Count == 0)
            return NotFound();

        return Ok(products);
    }

      [HttpPut("updatePrice")]
        public ActionResult<Product> UpdatePrice(string name, decimal price)
        {
            Product product = productList.Find(p => p.Name == name);
            if (product != null)
            {
                product.Price = price;
                return Ok(product);
            }
            else
            {
                return NotFound("Product not found");
            }
        }

        [HttpPut("updateName")]
        public ActionResult<Product> UpdateName(string oldName, string newName)
        {
            Product product = productList.Find(p => p.Name == oldName);
            if (product != null)
            {
                product.Name = newName;
                return Ok(product);
            }
            else
            {
                return NotFound("Product not found");
            }
        }

        [HttpGet("outOfStock")]
        public ActionResult<List<Product>> GetOutOfStockProducts()
        {
            List<Product> outOfStockProducts = productList.FindAll(p => !p.InStock);
            return Ok(outOfStockProducts);
        }
}
