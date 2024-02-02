using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers;

[ApiController]
[Route("store")]
public class StoreController : ControllerBase
{
    private static readonly List<Product> store_list = new List<Product>{new Product("Томат", 150, 10), new Product("Морковь", 80, 35), new Product("Свекла", 190, 0)};

    [HttpGet("get_item")]
    public List<Product> get_item()
    {
        return store_list;
    }

    [HttpGet("add_item")]
    public List<Product> add_item(string Name = "product", int Price = 0, int Stock = 0)
    {
        Product item = new Product(Name, Price, Stock);
        store_list.Add(item);
        return store_list;
    }

    [HttpGet("remove_item")]
    public IActionResult remove_item(string Name = "product")
    {
        var product = store_list.FirstOrDefault(p => p.name == Name);
        if (product != null)
        {
            store_list.Remove(product);
            return Ok($"{Name} удалён");
        }
        else
            return NotFound($"{Name} не найден");
    }
    [HttpGet("change_price")]
    public IActionResult change_price(string Name = "product", int Price = 0)
    {
        var product = store_list.FirstOrDefault(p => p.name == Name);
        int index = store_list.IndexOf(product);
        if (product != null)
        {
            store_list[index].price = Price;
            return Ok($"У {Name} цена изменена на {Price}");
        }
        else
            return NotFound($"{Name} не найден");
    }
    [HttpGet("change_name")]
    public IActionResult change_name(string Name = "product", string newName = "product2")
    {
        var product = store_list.FirstOrDefault(p => p.name == Name);
        int index = store_list.IndexOf(product);
        if (product != null)
        {
            store_list[index].name = newName;
            return Ok($"У {Name} название изменено на {newName}");
        }
        else
            return NotFound($"{Name} не найден");
    }
    [HttpGet("get_null_item")]
    public List<Product> get_null_item()
    {
        return store_list.FindAll(p => p.stock == 0);
    }
}

public class Product
{
    public string name {get; set;}
    public int price {get; set;}
    public int stock {get; set;}

    public Product(string Name, int Price, int Stock)
    {
        name = Name;
        price = Price;
        stock = Stock;
    }
}