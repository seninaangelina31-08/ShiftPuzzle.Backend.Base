namespace PracticeABC;

using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;


//# Практика B:
//1. Создать метод авторизации и логику авторизации.
// подсказка : используйте bool свойство IsAuthorized, которая перерключается в True после POST метода авторизации


//# Практика C:
//1. Переделай методы `UpdateName` и `Delete` в POST методы
[ApiController]
public class StoreController : ControllerBase
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
    public class NameUpdateModel
    {
        public string CurrentName { get; set; }
        public string NewName { get; set; }
    }


    private static readonly List<Product> Items = new List<Product>();

    [HttpGet]
    [Route("/store/updateprice")]
    public IActionResult UpdatePrice(string name, double newPrice)
    {
        var product = Items.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            product.Price = newPrice;
            return Ok($"{name} обновлен с новой ценой: {newPrice}");
        }
        else
        {
            return NotFound($"Продукт {name} не найден");
        }
    }

    [HttpPost]
    [Route("/store/updatename")]
    public IActionResult UpdateName([FromBody] NameUpdateModel model)
    {
        var product = Items.FirstOrDefault(p => p.Name == model.CurrentName);
        if (product != null)
        {
            product.Name = model.NewName;
            return Ok($"Имя продукта изменено с {model.CurrentName} на {model.NewName}");
        }
        else
        {
            return NotFound($"Продукт {model.CurrentName} не найден");
        }
    }


    [HttpGet]
    [Route("/store/outofstock")]
    public IActionResult OutOfStock()
    {
        var outOfStockItems = Items.Where(p => p.Stock == 0).ToList();
        if (outOfStockItems.Any())
        {
            return Ok(outOfStockItems);
        }
        else
        {
            return Ok("Все продукты в наличии");
        }
    }




    //Измени GET метод для добавления продукта на POST метод
    //2. Запусти проверь с помощью http://localhost:5087/store/show     5087 = порт


    [HttpPost]
    [Route("/store/add")]
    public IActionResult Add([FromBody] Product newProduct)
    {
        
        Items.Add(newProduct);
        return Ok(Items);
    }


    [HttpPost]
    [Route("/store/delete")]
    public IActionResult Delete([FromBody] string name)
    {
        var product = Items.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            Items.Remove(product);
            return Ok($"{name} удален");
        }
        else
        {
            return NotFound($"{name} не найден");
        }
    }


    [HttpGet]
    [Route("/store/show")]
    public IActionResult Show()
    {
        return Ok(Items);
    }

}