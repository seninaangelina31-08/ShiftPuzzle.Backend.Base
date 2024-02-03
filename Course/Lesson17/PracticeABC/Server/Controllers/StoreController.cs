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

    public class RenameProduct
    {
        public string Name { get; set; }
        public string NewName { get; set; }
    }


    private List<Product> Items = new List<Product>();

    private readonly string jsonFilePath = "DataBase.json";

    public StoreController()
    {
       ReadDataFromFile();
    }



    [HttpPost]
    [Route("/store/updateprice")]
    public IActionResult UpdatePrice([FromBody] Product product)
    {
        foreach (var el in Items){
            if (el.Name == product.Name)
            {
                double old_price = el.Price;
                el.Price = product.Price;
                WriteDataToFile();
                return Ok($"Цена продукта {el.Name} изменена с {old_price} на {el.Price}");
            }
        }
        return NotFound($"Продукт {product.Name} не найден");
        }
    }

    [HttpPost]
    [Route("/store/updatename")]
    public IActionResult UpdateName([FromBody] RenameProduct product)
    {
        foreach (var el in Items){
            if (el.Name == product.Name)
            {
                string old_name = el.Name;
                el.Name = product.NewName;
                WriteDataToFile();
                return Ok($"Имя продукта изменено с {old_name} на {product.NewName}");
            }
        }
        return NotFound($"Продукт {product.Name} не найден");
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
        if (System.IO.File.Exists(jsonFilePath))
        {
            string json = System.IO.File.ReadAllText(jsonFilePath);
            Items = JsonSerializer.Deserialize<List<Product>>(json);
        }
    }

    private void WriteDataToFile()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(Items, options);
        System.IO.File.WriteAllText(jsonFilePath, json);
    }