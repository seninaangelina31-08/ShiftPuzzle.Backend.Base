namespace PracticeA;

using System.Text;
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

    public class UpdateNameRequest
    {
        public string CurrentName { get; set; }
        public string NewName { get; set; }
    }
    public class DeleteRequest
    {
        public string Name { get; set; }
    }

    public class Useer {
        public string login {get; set;}
        public string password {get; set;}


        public Useer() {}


        public Useer (string login, string password) {
            this.login = login;
            this.password = password;
        }


    }
    private static readonly List<Useer> users = new List<Useer>();
    private static readonly List<Product> Items = new List<Product>();

    [HttpPost]
    [Route("/store/login")]
    public IActionResult Login(string login, string password) {
        if (login != null && password != null) {
            users.Add(new Useer(login, password));
            return Ok("Added a user");
        } else {
            return NotFound("Didn't find a user");
        }

    }


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
    public IActionResult UpdateName([FromBody] UpdateNameRequest request)
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
            return Ok("Все продукты в наличии");
        }
    }






    [HttpPost]
    [Route("store/add")]
    public IActionResult AddProduct([FromBody] Product product)
    {
        if (product != null) {
            Items.Add(product);
            return Ok(product);
        } else {
            return NotFound("Не найден");
        }

    }


    [HttpPost]
    [Route("/store/delete")]
    public IActionResult Delete([FromBody] DeleteRequest request)
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


}