namespace PracticeA;

using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.IO; 
using System.Net.Http;
using System.Text; 
using System.Threading.Tasks;
using System.Collections.Generic;
[ApiController]
public class StoreController : ControllerBase
{
    public class Product
    {
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; }

    [Range(0.01, 10000)]
    public double Price { get; set; }

    [Range(0, 10000)]
    public int Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }

    public class UserCredentials
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string User { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Pass { get; set; }

    }

    public class NewPrice
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        [Range(0.01, 10000)]
        public double Price { get; set; }
    }
    public class New_Name
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(100, MinimumLength = 3)]
        public string NewName { get; set; }
    }

    private List<Product> Items = new List<Product>();

    private readonly string _jsonFilePath = "DataBase.json";

    public StoreController()
    {
        ReadDataFromFile();
    }



    [HttpPost]
    [Route("/store/updateprice")]
    public IActionResult UpdatePrice([FromBody] NewPrice newPrice)
    {
        var product = Items.FirstOrDefault(p => p.Name == newPrice.Name);
        if (product != null)
        {
            product.Price = newPrice.Price;
            WriteDataToFile();
            return Ok($"{newPrice.Name} обновлен с новой ценой: {newPrice.Price}");
        }
        else
        {
            return NotFound($"Продукт {newPrice.Name} не найден");
        }
    }

    [HttpPost]
    [Route("/store/updatename")]
    public IActionResult UpdateName([FromBody] New_Name new_Name)
    {
        var product = Items.FirstOrDefault(p => p.Name == new_Name.Name);
        if (product != null)
        {
            product.Name = new_Name.NewName;
            WriteDataToFile();
            return Ok($"Имя продукта изменено с {new_Name.Name} на {new_Name.NewName}");
        }
        else
        {
            return NotFound($"Продукт {new_Name.Name} не найден");
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
    [Route("/store/auth")]
    public IActionResult Auth([FromBody] UserCredentials user)
    { 
        if((user.User == "admin") && (user.Pass == "123"))
        {
            
            return Ok($"{user.User} авторизован");
        }
        else
        {
            return NotFound($"{user.User} не найден");
        }

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

    private void ReadDataFromFile()
    {
        if (System.IO.File.Exists(_jsonFilePath))
        {
            string json = System.IO.File.ReadAllText(_jsonFilePath);
            Items = JsonSerializer.Deserialize<List<Product>>(json);
        }
    }

    private void WriteDataToFile()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(Items, options);
        System.IO.File.WriteAllText(_jsonFilePath, json);
    }


}