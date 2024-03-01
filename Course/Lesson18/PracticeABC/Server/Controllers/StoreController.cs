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

    private List<Product> Items = new List<Product>();

    private readonly string _jsonFilePath = "DataBase.json";

    public StoreController()
    {
        if (DBExist())
        {
            ReadDataFromFile();
        }
    }

    [HttpPost]
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
            return Ok($"Название продукта обновлено с {currentName} на {newName}");
        }
        else
        {
            return NotFound($"Продукт {currentName} не найден");
        }
    }

    [HttpPost]
    [Route("/store/addproduct")]
    public IActionResult AddProduct([FromBody] Product product)
    {
        if (ModelState.IsValid)
        {
            Items.Add(product);
            WriteDataToFile();
            return Ok("Продукт добавлен");
        }
        else
        {
            return BadRequest("Неверные данные продукта");
        }
    }

    private string ConvertDBtoJson()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        var json = JsonSerializer.Serialize(Items, options);
        return json;
    }

    private void WriteToDB(string json)
    {
        using (var writer = new StreamWriter(_jsonFilePath))
        {
            writer.Write(json);
        }
    }

    private void WriteDataToFile()
    {
        var json = ConvertDBtoJson();
        WriteToDB(json);
    }

    private bool DBExist()
    {
        return File.Exists(_jsonFilePath);
    }

    private string ReadDB()
    {
        using (var reader = new StreamReader(_jsonFilePath))
        {
            return reader.ReadToEnd();
        }
    }

    private List<Product> ConvertTextDBToList(string json)
    {
        return JsonSerializer.Deserialize<List<Product>>(json);
    }

    private void ReadDataFromFile()
    {
        var json = ReadDB();
        Items = ConvertTextDBToList(json);
    }
}
