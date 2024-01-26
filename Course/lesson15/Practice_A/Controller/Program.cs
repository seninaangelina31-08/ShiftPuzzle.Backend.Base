using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

[ApiController]
public class StoreController : ControllerBase
{
    private List<string> productList = new List<string>();

    [HttpPost]
    [Route("store/add")]
    public IActionResult AddProduct([FromBody] string product)
    {
        if (string.IsNullOrWhiteSpace(product))
        {
            return BadRequest("Product cannot be empty.");
        }

        productList.Add(product);
        return Ok($"Product '{product}' added successfully.");
    }

    [HttpPost]
    [Route("store/remove")]
    public IActionResult RemoveProduct([FromBody] string product)
    {
        if (string.IsNullOrWhiteSpace(product))
        {
            return BadRequest("Product cannot be empty.");
        }

        if (productList.Contains(product))
        {
            productList.Remove(product);
            return Ok($"Product '{product}' removed successfully.");
        }
        else
        {
            return NotFound($"Product '{product}' not found.");
        }
    }

    [HttpGet]
    [Route("store/list")]
    public IActionResult GetProductList()
    {
        return Ok(productList);
    }
}