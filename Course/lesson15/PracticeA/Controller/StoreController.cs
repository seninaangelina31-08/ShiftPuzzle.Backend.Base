using Microsoft.AspNetCore.Mvc;

namespace PracticeA.Controllers;

[ApiController] 
public class StoreController : ControllerBase
{
    private static readonly List<string> Products = new List<string>{};

    private readonly ILogger<StoreController> _logger;

    public StoreController(ILogger<StoreController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("store/add")]
    public List<string> Add_product(string name)
    {
        Products.Add(name);
        return Products;
    }

    [HttpGet]
    [Route("store/delete")]
    public List<string> Del_product(string name)
    {
        foreach (string ar in Products)
        {
            if (ar == name)
            {
                Products.Remove(ar);
                break;
            } else
            {
                continue;
            }
        }
        return Products;
    }

    [HttpGet]
    [Route("store/view")]
    public List<string> View_products()
    {
        return Products;
    }
}

