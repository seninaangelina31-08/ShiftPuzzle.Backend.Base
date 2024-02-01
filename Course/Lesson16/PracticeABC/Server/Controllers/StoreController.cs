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

    public class UpdateNameBody
    {
        public string CurrentName { get; set; }
        public string NewName { get; set; }

        public UpdateNameBody(string currentName, string newName)
        {
            this.CurrentName = currentName;
            this.NewName = newName;
        }
    }

    public class DeleteProduct
    {
        public string Name { get; set; }

        public DeleteProduct(string name)
        {
            this.Name = name;
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

    [HttpPost]
    [Route("/store/updatename")]
    public IActionResult UpdateName([FromBody] UpdateNameBody newName)
    {
        var product = Items.FirstOrDefault(p => p.Name == newName.CurrentName);
        if (product != null)
        {
            product.Name = newName.NewName;
            return Ok($"Имя продукта изменено с {newName.CurrentName} на {newName.NewName}");
        }
        else
        {
            return NotFound($"Продукт {newName.CurrentName} не найден");
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
    public IActionResult Delete([FromBody] DeleteProduct newProduct)
    {
        var product = Items.FirstOrDefault(p => p.Name == newProduct.Name);
        if (product != null)
        {
            Items.Remove(product);
            return Ok($"{newProduct.Name} удален");
        }
        else
        {
            return NotFound($"{newProduct.Name} не найден");
        }
    }


    [HttpGet]
    [Route("/store/show")]
    public IActionResult Show()
    {
        return Ok(Items);
    }


}