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

    [HttpPost("update/{id}")]
    public IActionResult UpdateName(int id, [FromBody] string newName)
    {
        // Логика обновления имени продукта
        return Ok(); // или возврат обновлённого объекта, если требуется
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






    [HttpGet]
    [Route("/store/add")]
    public IActionResult Add(string name, double price, int stock)
    {
        var product = new Product(name, price, stock);
        Items.Add(product);
        return Ok(Items);
    }


    [HttpPost("delete/{id}")]
    public IActionResult Delete(int id)
    {
        // Логика удаления продукта
        return Ok(); // или возврат подтверждения удаления
    }


    [HttpGet]
    [Route("/store/show")]
    public IActionResult Show()
    {
        return Ok(Items);
    }


}

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private bool IsAuthorized = false;

    [HttpPost]
    public IActionResult Authorize()
    {
        // Логика авторизации
        IsAuthorized = true;
        return Ok();
    }
}