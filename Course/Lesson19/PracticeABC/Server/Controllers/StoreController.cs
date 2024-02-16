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
<<<<<<< HEAD
    
=======
>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01
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
<<<<<<< HEAD
        
    }

    public class BackupDB
        {
            public List<Product> Products { get; set; }
        }
=======
    }

>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01
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
<<<<<<< HEAD
    private readonly string _backupJsonFilePath = "BackupDB.json";
=======
>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01

    public StoreController()
    {
        ReadDataFromFile();
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
            return Ok($"Имя продукта изменено с {currentName} на {newName}");
        }
        else
        {
            return NotFound($"Продукт {currentName} не найден");
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
<<<<<<< HEAD
        ReadDataFromFile();
=======
>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01
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
 

    private List<Product> ConvertTextDBToList(string json)
    {
<<<<<<< HEAD
        return JsonSerializer.Deserialize<List<Product>>(json);
=======
        return JsonSerializer.Deserialize<List<Product>>(json)
>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01
    }

    private string ReadDB()
    {
        return System.IO.File.ReadAllText(_jsonFilePath);
    }

    private bool DBExist()
    {
        return System.IO.File.Exists(_jsonFilePath);
    }

    private void ReadDataFromFile()
    {
        if (DBExist())
        { 
            Items =  ConvertTextDBToList(ReadDB());
        }
    }

<<<<<<< HEAD
   

    //Рефакторинг серверной части [Server/StoreController.cs] [Server/DBModel.cs]
    //создать класс модели и перенести работу с базой данных


    //Рефакторинг серверной части [Server/StoreController.cs] [Server/DBModel.cs]
    //прокинуть связь между контроллером и моделью
    //сделать вызов из контроллера


    //Рефакторинг серверной части [Server/StoreController.cs] [Server/DBModel.cs]
   //создать функцию бекапа для БД в отдельную базу ["BackupDB.json"]
    
    private BackupDB ConvertTextDBToBackup(string json)
    {
        return JsonSerializer.Deserialize<BackupDB>(json);
    }
    
    private string ReadBackupDB()
    {
        return System.IO.File.ReadAllText(_backupJsonFilePath);
    }
    
    private void ReadBackupDataFromFile()
    {
        if (BackupDBExist())
        {
            var backupDB = ConvertTextDBToBackup(ReadBackupDB());
            Items = backupDB.Products;
        }
    }
    private bool BackupDBExist()
    {
        return System.IO.File.Exists(_backupJsonFilePath);
    }

=======
    #endregion
 
>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01

    private string  ConvertDBtoJson()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
<<<<<<< HEAD
        return JsonSerializer.Serialize(Items, options);
=======
        retunr JsonSerializer.Serialize(Items, options);
>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01
    }

    private void WriteTiDB(string json)
    {
        System.IO.File.WriteAllText(_jsonFilePath, json);
    }

    private void WriteDataToFile()
    { 
        WriteTiDB(ConvertDBtoJson());
<<<<<<< HEAD

    }
 
=======
    }
 


>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01
}