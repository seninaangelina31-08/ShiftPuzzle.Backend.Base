namespace PracticeA;

using Microsoft.AspNetCore.Mvc;

[ApiController]
public class StoreController : ControllerBase
{

    private static readonly List<Product> Items = new List<Product>();
    private static readonly List<User> Users = new List<User>();

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
    public IActionResult UpdateName(string currentName, string newName)
    {
        var product = Items.FirstOrDefault(p => p.Name == currentName);
        if (product != null)
        {
            product.Name = newName;
            return Ok($"Имя продукта изменено с {currentName} на {newName}");
        }
        else
        {
            return NotFound($"Продукт {currentName} не найден");
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

    [HttpPost]
    [Route("/store/add")]
    public IActionResult Add([FromBody] Product newProduct)
    {
        Items.Add(newProduct);
        return Ok(Items);
    }


    [HttpPost]
    [Route("/store/delete")]
    public IActionResult Delete([FromBody] Product delProd)
    {
        var product = Items.FirstOrDefault(p => p.Name == delProd.Name);
        if (product != null)
        {
            Items.Remove(product);
            return Ok($"{delProd.Name} удален");
        }
        else
        {
            return NotFound($"{delProd.Name} не найден");
        }
    }


    [HttpGet]
    [Route("/store/show")]
    public IActionResult Show()
    {
        return Ok(Items);
    }


    [HttpPost]
    [Route("/store/add_user")]
    public IActionResult Add_user([FromBody] User newUser)
    {
        Users.Add(newUser);
        return Ok($"Пользователь {newUser.Name} успешно зарегистрирован!");
    }

    [HttpPost]
    [Route("/store/login")]
    public IActionResult Login_user([FromBody] User newUser)
    {
        foreach (var us in Users)
        {
            if (us.Loggin == newUser.Loggin && us.Password == newUser.Password)
            {
                us.IsAuthorized = true;
                return Ok($"Добро пожаловать, {us.Name}!");
            }
        }
        return NotFound($"Пользователь не найден");
    }
}