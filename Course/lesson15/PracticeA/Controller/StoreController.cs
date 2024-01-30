using Microsoft.AspNetCore.Mvc;

namespace PracticeA.Controller;

[ApiController]
[Route("api/")]
public class StoreController : ControllerBase
{
    public static readonly List<string> products = new List<string>();

    public static bool ShowProductList(List<string> List)
    {
        foreach (var prod in List)
        {
            Console.WriteLine(prod);
        }
        return true;
    }


    [HttpGet]
    [Route("/store/add")]

    public string Add(string product)
    {
        products.Add(product);
        Console.WriteLine(ShowProductList(products));
        return $"{product} не добавлен";
    }

    [HttpDelete]
    [Route("/store/delete")]

    public IActionResult Delete(string prodct)
    {
        products.Remove(prodct);
        foreach (string item in products)
        {
            if (item == prodct)
            {
                products.Remove(item);
                return Ok($"{item} удален");
            }
        }
        return NotFound($"{prodct} не найден");
    }
    // public IActionResult Delete(string name)
    // {
        
    //     if (prodct != null)
    //     {
    //         Items.Remove(prodct);
    //         return Ok($"{name} удален");
    //     }
    //     else
    //     {
    //         return NotFound($"{name} не найден");
    //     }
    // }
}
