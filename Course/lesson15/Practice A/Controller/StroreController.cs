using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class StoreController : ControllerBase
{
    private List<string> products = new List<string>();

    [HttpPost]
    [Route("store/add")]
    public IActionResult AddProduct(string product)
    {
        products.Add(product);
        return product;
    }

    [HttpPost]
    [Route("store/delete")]
    public IActionResult DeleteProduct(string product)
    {
        products.Remove(product);
        return Ok();
    }

    [HttpGet]
    [Route("list")]
    public IActionResult GetProductList()
    {
        return Ok(products);
    }
}
