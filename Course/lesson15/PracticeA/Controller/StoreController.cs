using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace PracticeA.Controllers;


[ApiController] 
public class StoreController : ControllerBase
{
    private static readonly List<Product> Products = new List<Product>{};

    private readonly ILogger<StoreController> _logger;

    public StoreController(ILogger<StoreController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("store/add")]
    public IActionResult Add_product(string name, int price, bool storehave)
    {   
        Product prod = new Product(name, price, storehave);
        Products.Add(prod);
        string json1 = JsonSerializer.Serialize(prod);
        return Ok(json1);
    }

    [HttpGet]
    [Route("store/delete")]
    public IActionResult Del_product(string name)
    {
        foreach (Product ar in Products)
        {
            if (ar.name == name)
            {
                Products.Remove(ar);
                string json = JsonSerializer.Serialize(Products);
                return Ok(json);
            } else
            {
                continue;
            }
        }
        return NotFound();
    }

    [HttpGet]
    [Route("store/view")]
    public IActionResult View_products()
    {
        string json = json = JsonSerializer.Serialize(Products);
        return Ok(json);
    }
}

