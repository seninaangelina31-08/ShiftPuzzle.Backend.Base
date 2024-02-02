namespace Server;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/store")]
public class StoreController : ControllerBase
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
        }

        public void ChangeName(string newName)
        {
            this.Name = newName;
        }
    }

    public class StoreUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAuthorized { get; set; }

        public StoreUser(string login, string password, bool isAuthorized = false)
        {
            this.Login = login;
            this.Password = password;
            this.IsAuthorized = isAuthorized;
        }
        public void Authorize()
        {
            this.IsAuthorized = true;
        }
    }

    private static readonly List<Product> Items = new List<Product>();
    private static readonly List<StoreUser> StoreUsers = new();

    [HttpGet]
    [Route("updateprice")]
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
    [Route("updatename")]
    public IActionResult UpdateName([FromBody] Product productOldName, string newName)
    {
        var product = Items.FirstOrDefault(p => p.Name == productOldName.Name);
        if (product != null)
        {
            product.ChangeName(newName);
            return Ok($"Имя продукта изменено с {productOldName.Name} на {newName}");
        }
        else
        {
            return NotFound($"Продукт {productOldName.Name} не найден");
        }
    }


    [HttpGet]
    [Route("outofstock")]
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
    [Route("add")]
    public IActionResult Add([FromBody] Product newProduct)
    {
        Items.Add(newProduct);
        return Ok(Items);
    }


    [HttpPost]
    [Route("CreateNewUser")]
    public IActionResult CreateNewUser([FromBody] StoreUser storeUser)
    {
        StoreUsers.Add(storeUser);
        return Ok(new {status = "Пользователь успешно создан"});
    }


    [HttpPost]
    [Route("Auth")]
    public IActionResult Auth ([FromBody] StoreUser storeUser)
    {
        if (storeUser.Login == "Akshin" && storeUser.Password == "MLtheBest")
        {
            storeUser.Authorize();
            return Ok(new {status = "Вы успешно зашли в систему!!!"});
        }
        return NotFound(new {status = "Неверный логин или пароль..."});
    }


    [HttpPost]
    [Route("delete")]
    public IActionResult Delete([FromBody] Product productToDelete)
    {
        var product = Items.FirstOrDefault(p => p.Name == productToDelete.Name);
        if (product != null)
        {
            Items.Remove(product);
            return Ok($"{productToDelete.Name} удален");
        }
        else
        {
            return NotFound($"{productToDelete.Name} не найден");
        }
    }


    [HttpGet]
    [Route("show")]
    public IActionResult Show()
    {
        return Ok(Items);
    }


}