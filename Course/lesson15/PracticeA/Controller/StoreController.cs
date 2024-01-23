using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers;

[ApiController]
[Route("store")]
public class StoreController : ControllerBase
{
    List<string> store_list = new List<string>{"Томат", "Морковь", "Свекла"};

    [HttpGet("get_item")]
    public List<string> get_item()
    {
        return store_list;
    }

    [HttpGet("add_item")]
    public List<string> add_item(string item)
    {
        store_list.Add(item);
        return store_list;
    }

    [HttpGet("remove_item")]
    public List<string> remove_item(string item)
    {
        if (store_list.Remove(item));
            return store_list;
    }
}