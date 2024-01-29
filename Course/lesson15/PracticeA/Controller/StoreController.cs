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

    [HttpGet]
    [Route("store/change_price")]
    public IActionResult Change_price(string name, int new_price)
    {
        foreach (Product ar in Products)
        {
            if (ar.name == name)
            {   
                Products.Remove(ar);
                Product a = new Product(ar.name, new_price, ar.haveInStore);
                Products.Add(a);
                string json = JsonSerializer.Serialize(a);
                return Ok(json);
            } else
            {
                continue;
            }
        }
        return NotFound();
    }

    [HttpGet]
    [Route("store/change_name")]
    public IActionResult Change_name(string name, string new_name)
    {
        foreach (Product ar in Products)
        {
            if (ar.name == name)
            {   
                Products.Remove(ar);
                Product a = new Product(new_name, ar.price, ar.haveInStore);
                Products.Add(a);
                string json = JsonSerializer.Serialize(a);
                return Ok(json);
            } else
            {
                continue;
            }
        }
        return NotFound();
    }


    [HttpGet]
    [Route("store/viewno")]
    public IActionResult View_no()
    {
        List<string> lst = new List<string>{};

        foreach (Product ar in Products)
        {
            if (ar.haveInStore == false)
            {   
                lst.Add(ar.name);
            } else
            {
                continue;
            }
        }
        string json = JsonSerializer.Serialize(lst);
        return Ok(json);
    }
}

