using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
}




[ApiController]
public class StoreController : ControllerBase
{
    private List<Product> productList = new List<Product>();

    [HttpPost]
    [Route("store/add")]
    public IActionResult AddProduct([FromBody] Product product)
    {
        if (product == null || string.IsNullOrWhiteSpace(product.Name) || product.Price <= 0 || product.StockQuantity < 0)
        {
            return BadRequest("Invalid product data.");
        }

        productList.Add(product);
        return Ok(product);
    }

    [HttpPost]
    [Route("store/remove")]
    public IActionResult RemoveProduct([FromBody] string productName)
    {
        Product productToRemove = productList.Find(p => p.Name == productName);

        if (productToRemove != null)
        {
            productList.Remove(productToRemove);
            return Ok(productToRemove);
        }
        else
        {
            return NotFound($"Product '{productName}' not found.");
        }
    }

    [HttpGet]
    [Route("store/list")]
    public IActionResult GetProductList()
    {
        return Ok(productList);
    }

        [HttpPost]
    [Route("store/update/price")]
    public IActionResult UpdateProductPrice([FromBody] Product updatedProduct)
    {
        Product productToUpdate = productList.Find(p => p.Name == updatedProduct.Name);

        if (productToUpdate != null)
        {
            productToUpdate.Price = updatedProduct.Price;
            return Ok(productToUpdate);
        }
        else
        {
            return NotFound($"Product '{updatedProduct.Name}' not found.");
        }
    }

    [HttpPost]
    [Route("store/update/name")]
    public IActionResult UpdateProductName([FromBody] Product updatedProduct)
    {
        Product productToUpdate = productList.Find(p => p.Name == updatedProduct.Name);

        if (productToUpdate != null)
        {
            productToUpdate.Name = updatedProduct.Name;
            return Ok(productToUpdate);
        }
        else
        {
            return NotFound($"Product '{updatedProduct.Name}' not found.");
        }
    }

    [HttpGet]
    [Route("store/out-of-stock")]
    public IActionResult GetOutOfStockProducts()
    {
        var outOfStockProducts = productList.Where(p => p.StockQuantity == 0).ToList();
        return Ok(outOfStockProducts);
    }
}