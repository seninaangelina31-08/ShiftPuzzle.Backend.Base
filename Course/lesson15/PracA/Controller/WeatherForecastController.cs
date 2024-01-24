using Microsoft.AspNetCore.Mvc;


namespace PracA;


[ApiController] 
public class StoreController : ControllerBase
{
    public List<string> shop_list = new List<string>{"potato", "bread", "milk"};

    [HttpGet("add-product")]
    public string add(string product)
    {
        shop_list.Add(product);
        return shop_list[4];
    }

    [HttpGet("delete-product")]
    public string delete(string product)
    {
        shop_list.Remove(product);
        return shop_list[-1];
    }

    [HttpGet("view-product")]
    public List<string> view()
    {
        return shop_list;
    }
}

