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
            Afoldingroom = afoldingroom;
        }
    }

    public class Productupdate
    {
        public string CurrentName { get; set; }
        public string NewName { get; set; }
    }
    public class DeleteProductRequest
    {
        public string Name { get; set; }
    }

    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAuthorized { get; set; }

        public User(){}
        public User(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
            this.IsAuthorized = false;
        }
    }   
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
            return Ok($"{name} обновлен : {newPrice}");
        }
        else
        {
            return NotFound($"Продукт {name} не найден");
        }
    }

    [HttpPost]
    [Route("/store/updatename")]
    public IActionResult UpdateName([FromBody] Productupdate request)
    {
        var product = Items.FirstOrDefault(p => p.Name == request.CurrentName);
        if (product != null)
        {
            product.Name = request.NewName;
            return Ok($"Имя продукта изменено с {request.CurrentName} на {request.NewName}");
        }
        else
        {
            return NotFound($"Продукт {request.CurrentName} не найден");
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
            return Ok(" продукты в наличии");
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
    public IActionResult Delete([FromBody] DeleteProductRequest request)
    {
        var product = Items.FirstOrDefault(p => p.Name == request.Name);
        if (product != null)
        {
            Items.Remove(product);
            return Ok($"{request.Name} удален");
        }
        else
        {
            return NotFound($"{request.Name} не найден");
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
    public IActionResult AddUser([FromBody] User user)
    {
        Users.Add(user);
        return Ok($"Пользователь {user.Login} добавлен.");

    }

    [HttpPost]
    [Route("store/logining_user")]
    public IActionResult LoginingUser([FromBody] User user)
    {
        foreach (var el in Users)
        {
            if (el.Login == user.Login)
            {
                if (el.Password == user.Password)
                {   
                    el.IsAuthorized = true;
                    return Ok(" вошел в систему.");
                }
            }
        }
        return NotFound("Неправильный логин или пароль.");
    }


    [HttpGet]
    [Route("/store/user_info")]
    public IActionResult UserInfo()
    {
        return Ok(Users);
    }

}