namespace PracticeA;

using Microsoft.AspNetCore.Mvc;

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

public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Avtorisation { get; set; }

        public User(){}
        public User(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
            this.Avtorisation = false;
        }
    }


    private static readonly List<Product> Items = new List<Product>();
    private static readonly List<User> Users = new List<User>();

    [HttpPut]
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

    [HttpPut]
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


    [HttpPut]
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
    public IActionResult Add(string name, double price, int stock)
    {
        var product = new Product(name, price, stock);
        Items.Add(product);
        return Ok(Items);
    }

    [HttpPost]
    [Route("/store/add_user")]
    public IActionResult AddUser([FromBody] User user)
    {
        Users.Add(user);
        return Ok($"Пользователь {user.Login} добавлен.");
    }

    [HttpPost]
    [Route("store/logining_user")]

    public IActionResult LoginingUser([FromBody] User user)
    {
        foreach (var i in Users)
        {
            if (i.Login == user.Login)
            {
                if (i.Password == user.Password)
                {   
                    i.Avtorisation = true;
                    return Ok("Добро Пожаловать!");
                }
            }
        }
        return NotFound("Неправильный логин или пароль.");
    }

    [HttpPost]
    [Route("/store/delete")]

    public IActionResult Delete(string name)
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

    [HttpGet]
    [Route("/store/user_info")]
    public IActionResult UserInfo()
    {
        return Ok(Users);
    }
}