using Microsoft.AspNetCore.Mvc;

namespace PracticeA.Controller;

[ApiController]
public class StoreController : ControllerBase
{
    public static readonly List<string> products = new List<string>();

    public static void ShowProductList(List<string> List)
    {
        foreach (var prod in List)
        {
            Console.WriteLine(prod);
        }
    }


    [HttpGet]
    [Route("/store/add")]

    public string Add(string product)
    {
        products.Add(product);
        ShowProductList(products);
        return $"{product} добавлен";
    }

    [HttpGet]
    [Route("/store/delete")]

    public IActionResult Delete(string name)
    {
        foreach (string item in products)
        {
            if (item == name)
            {
                products.Remove(name);
                ShowProductList(products);
                return Ok($"{name} удален");
            }
        }
        return NotFound($"{name} не найден");
    }

    [HttpGet]
    [Route("/store/showproducts")]

    public string ShowList()
    {
        string list = string.Join(", ", products);
        Console.WriteLine(list);
        return list;
    }
}
