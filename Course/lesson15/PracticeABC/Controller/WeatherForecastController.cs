using Microsoft.AspNetCore.Mvc;

namespace PractiveABC;

[ApiController]
[Route("store/")]
public class StoreController : ControllerBase
{
    public List<Product> items = new List<Product>{new Product { name = "tomato", price = 129, is_in = true }};

    [HttpGet("veiw-item")]
    public List<Product> get_items()
    {
        return items;
    }

    [HttpGet("delete-item")]
    public string del_item(Product item)
    {
        items.Remove(item);
        return "OK";
    }

    [HttpGet("add")]
    public string add(Product item)
    {
        items.Add(item);
        Console.WriteLine("Function worked successfully!");
        return "OK";
    }
    [HttpGet("update_price")]
    public string update_price(string name, int nem_price)
    {
        foreach (Product item in items)
        {
            if (item.name == name){
                item.price = nem_price;
                return "OK";
            }
        }
        return "NotFound";
    }
    [HttpGet("update_name")]
    public string update_name(string name, string nem_name)
    {
        foreach (Product item in items)
        {
            if (item.name == name){
                item.name = nem_name;
                return "OK";
            }
        }
        return "NotFound";
    }
    [HttpGet("get_not_in")]
    public List<Product> get_not_in()
    {
        List<Product> Not_in = new List<Product>{};
        foreach (Product item in items)
        {
            if (item.is_in == false){
                Not_in.Add(item);
            }
        }
        return Not_in;
    }
}

[System.Serializable] public class Product
{
    public string name { get; set; }

    public int price { get; set; }

    public bool is_in { get; set; }
    public Product() { }
    public Product(string name, int price, bool is_in)
    {
        this.name = name;
        this.price = price;
        this.is_in = is_in;
    }
}