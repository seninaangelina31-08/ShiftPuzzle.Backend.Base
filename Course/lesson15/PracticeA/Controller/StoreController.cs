using Microsoft.AspNetCore.Mvc;

namespace PractoiceA.Controllers;


[ApiController] 
public class StoreController : ControllerBase
{
    private static List<string> Products = new List<string>()
    {
        "first", "second", "third"
    };

    [HttpGet]
    [Route("store/add")]
    public List<string> Add(string item)
    {
        Products.Add(item);

        return Products;
    }

    [HttpGet]
    [Route("store/del")]
    public List<string> Del(string item)
    {
        Products.Remove(item);

        return Products;
    }

    [HttpGet]
    [Route("store/view")]
    public List<string> Get()
    {
        return Products;
    }
}