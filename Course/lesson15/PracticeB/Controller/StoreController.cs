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
    public List<Product> add_item(string Name = "product", int Price = 0, int Stoke = 0)
    {
        Product item = new Product(Name, Price, Stoke);
        store_list.Add(item);
        return store_list;
    }

    [HttpGet("remove_item")]
    public List<Product> remove_item(string Name = "product")
    {
        foreach (Product item in store_list)
        {
            if (item.name == Name)
                store_list.Remove(item);
        }
        return store_list;
    }
}

public class Product
{
    public string name {get; set;}
    public int price {get; set;}
    public int stoke {get; set;}

    public Product(string Name, int Price, int Stoke)
    {
        name = Name;
        price = Price;
        stoke = Stoke;
    }
}