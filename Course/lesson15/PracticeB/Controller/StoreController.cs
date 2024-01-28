using Microsoft.AspNetCore.Mvc;

namespace PractoiceB.Controllers;


[ApiController] 
public class StoreController : ControllerBase
{
    private static readonly List<Product> Products = new List<Product>()
    {
        new Product("First", 1000, true),
        new Product("Second", 20, false),
        new Product("Third", 12451, true)
    };

    [HttpGet]
    [Route("product/add")]
    public IActionResult Add(string name, int price, bool isOnStorage)
    {
        Products.Add(new Product(name, price, isOnStorage));

        return Ok($"{name} Added");
    }

    [HttpGet]
    [Route("product/del")]
    public IActionResult Del(string name)
    {
        var product = Products.FirstOrDefault(p => p.name == name);
        if(product != null)
        {
            Products.Remove(product);
            return Ok($"{name} delited");
        }
        else
        {
            return NotFound($"{name} not found");
        }
    }

    [HttpGet]
    [Route("product/view")]
    public IActionResult Get()
    {
        string response = "";
        foreach(var product in Products)
        {
            response += "{" + $"name: \"{product.name}\", price: {product.price}, isOnStorage: {product.isOnStorage}" + "}";
        }
        return Ok(response);
    }
}

public class Product
{
    public string name;
    public float price;
    public bool isOnStorage;

    public Product(string name, float price, bool isOnStorage)
    {
        this.name = name;
        this.price = price;
        this.isOnStorage = isOnStorage;
    }
}