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
        public string userName;
        public string password;

        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }

    private static readonly List<Product> Items = new List<Product>();
    private static readonly List<User> Users = new List<User>() 
    { new User("bezlikiy", "123") };

    [HttpGet]
    [Route("/user/auth")]
    public User UserAuth(string userName, string password)
    {
        User user = Users.FirstOrDefault(p => p.userName == userName);
        if (user != null)
        {
            if(user.password == password)
            {
                return user;
            }
        }
        return user;
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

    [HttpPut]
    [Route("/store/updatename")]
    public IActionResult UpdateName(int id, string newName)
    {
        var product = Items.ElementAt(id);
        if (product != null)
        {
            product.Name = newName;
            return Ok($"Имя продукта изменено с {product.Name} на {newName}");
        }
        else
        {
            return NotFound($"Продукт с id {id} не найден");
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


    [HttpDelete]
    [Route("/store/delete")]
    public IActionResult Delete(int id)
    {
        var product = Items.ElementAt(id);
        if (product != null)
        {
            Items.Remove(product);
            return Ok($"{product.Name} удален");
        }
        else
        {
            return NotFound($"id {id} не найден");
        }
    }


    [HttpGet]
    [Route("/store/show")]
    public IActionResult Show()
    {
        return Ok(Items);
    }
}