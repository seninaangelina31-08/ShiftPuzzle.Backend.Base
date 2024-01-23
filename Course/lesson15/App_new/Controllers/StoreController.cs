using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


namespace App_new.Controllers;

[ApiController]
[Route("api/")]
public class StoreController : ControllerBase
{
    private static readonly ProductList list = new ProductList([new Product("Tomatoes", 100.00, true), new Product("Apples", 99.99, true)]);

    [HttpGet("store/add")]
    public ActionResult<ProductList> Add(string name, double price, bool availability)
    {   
        list.List.Add(new Product(name, price, availability));
        return list;
    }

    [HttpGet("store/delete")]
    public ActionResult<ProductList> Delete(string el)
    {
        foreach (var search in list.List)
        {
            if (search.Name == el)
            {
                list.List.Remove(search);
        return list;                
            }
        }
        return BadRequest(list);
    }
    
    [HttpGet("store/info")]
    public ActionResult<ProductList> Info()
    {
        return list;
    }

    [HttpGet("store/reprice")]
    public ActionResult<ProductList> RePrice(string name, double new_price)
    {
        list.RePrice(name, new_price);
        return list;
    }

    [HttpGet("store/rename")]
    public ActionResult<ProductList> Rename(string old_name, string new_name)
    {
        list.Rename(old_name, new_name);
        return list;
    }
    [HttpGet("store/nonavailable")]
    public ActionResult<ProductList> NonAvailable()
    {
        return new ProductList(list.NonAvailable());
    }
}