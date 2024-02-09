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

    public class UserCredentials
    {
        public string username { get; set; }
        public string password { get; set; }

    }

    private readonly string jsonFilePath = "DataBase.json";
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


    private void WriteDataToFile()
    {
        var options = new JsonSerializerOptions {WriteIndented = true };
        string json = JsonSerializer.Serialize(Items, options);
        System.IO.File.WriteAllText(jsonFilePath, json);
    }

    [HttpPost]
    [Route("/store/add")]
    public IActionResult Add([FromBody] Product newProduct)
    { 
        Items.Add(newProduct);
        WriteDataToFile();
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


    //1. **Класс `Program`**:
//   - **Поля**:
//     - `IsAuthorized`: Статическое булево поле, указывающее, авторизован ли пользователь.
//   - **Методы**:
//     - `Main(string[] args)`: Основной метод программы, который представляет консольное меню и управляет действиями пользователя.
//     - `DisplayProducts()`: Метод для получения и вывода списка продуктов с сервера.
//     - `SendProduct()`: Метод для отправки информации о продукте на сервер.
//     - `Auth()`: Метод для аутентификации пользователя на сервере.

    [HttpPost]
    [Route("/store/authorize")]
    public IActionResult Authorize([FromBody] UserCredentials user)
    { 
        //создать 2 метода: метод отправки объекта и метод авторизации
//- в методе отправки объекта создать объект который будет отправляться в самой функции
//- указать ссылку апи (для метода добавления объекта который у вас должен быть прописан в контроллере)
//- указать код из презентации

        if((user.username == "IvanIvanovich") && (user.password == "12234"))
        {
            
            return Ok($"{user.username} авторизован");
        }
        else
        {
            return NotFound($"{user.username} не найден");
        }

    }
}