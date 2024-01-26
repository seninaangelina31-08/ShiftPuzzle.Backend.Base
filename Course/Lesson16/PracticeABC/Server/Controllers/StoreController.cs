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

    private static readonly List<User> Users = new List<User>();
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
    public IActionResult UpdateName(string currentName, string newName)
    {
        foreach (var el in Items)
        {
            if (el.Name == currentName)
            {
                el.Name = newName;
                return Ok(Items);
            }
        }
        return NotFound("Продукт не найден в базе.");
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
    public IActionResult Add([FromBody] Product product)
    {
        Items.Add(product);
        return Ok(Items);
    }


    [HttpDelete]
    [Route("/store/delete")]
    public IActionResult Delete(string name)
    {
        foreach (var el in Items)
        {
            if (el.Name == name)
            {
                Items.Remove(el);
                return Ok(Items);
            }
        }
        return NotFound("Продукт не найден в базе");
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
        return Ok($"User {user.Login} added.");

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
                    return Ok("Successfully logged in.");
                }
            }
        }
        return NotFound("Wrong login or password.");
    }


    [HttpGet]
    [Route("/store/user_info")]
    public IActionResult UserInfo()
    {
        return Ok(Users);
    }
}