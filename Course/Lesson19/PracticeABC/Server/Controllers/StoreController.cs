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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    
=======
>>>>>>> 2f0ac98b (Материалы 19-го урока)
=======
    
>>>>>>> 56c5f66f (feat: added answer to task 19)
=======
    
=======
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
>>>>>>> 240f7224 (feat: added answer to task 21)
=======
    
>>>>>>> 3fbbd12a (nothing)
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> 3fbbd12a (nothing)
        
    }
    public class BackupDB
        {
            public List<Product> Products { get; set; }
        }
=======
    }

<<<<<<< HEAD
>>>>>>> 2f0ac98b (Материалы 19-го урока)
=======
=======
>>>>>>> 240f7224 (feat: added answer to task 21)
        
    }

    public class BackupDB
        {
            public List<Product> Products { get; set; }
        }
<<<<<<< HEAD
>>>>>>> 56c5f66f (feat: added answer to task 19)
=======
=======
    }

>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
>>>>>>> 240f7224 (feat: added answer to task 21)
    public class UserCredentials
    {
        [Required]
=======
>>>>>>> 3fbbd12a (nothing)
        [StringLength(100, MinimumLength = 3)]
        public string User { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Pass { get; set; }

    }


    private List<Product> Items = new List<Product>();

    private readonly string _jsonFilePath = "DataBase.json";
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    private readonly string _backupJsonFilePath = "BackupDB.json";
=======
>>>>>>> 2f0ac98b (Материалы 19-го урока)
=======
    private readonly string _backupJsonFilePath = "BackupDB.json";
>>>>>>> 56c5f66f (feat: added answer to task 19)
=======
    private readonly string _backupJsonFilePath = "BackupDB.json";
=======
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
>>>>>>> 240f7224 (feat: added answer to task 21)
=======
    private readonly string _backupJsonFilePath = "BackupDB.json";
>>>>>>> 3fbbd12a (nothing)

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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 240f7224 (feat: added answer to task 21)
        ReadDataFromFile();
=======
<<<<<<< HEAD
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
        Items.Add(newProduct);
=======
=======
        ReadDataFromFile();
>>>>>>> 56c5f66f (feat: added answer to task 19)
        Items.Add(newProduct);
        WriteDataToFile();
        return Ok(Items);
>>>>>>> 2f0ac98b (Материалы 19-го урока)
=======
        Items.Add(newProduct);
>>>>>>> 3fbbd12a (nothing)
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
<<<<<<< HEAD
<<<<<<< HEAD
 

    private List<Product> ConvertTextDBToList(string json)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        return JsonSerializer.Deserialize<List<Product>>(json);
=======

    #region PRACTICE_B
=======
 
>>>>>>> ec9a1010 (Материалы 20-го урока)

    private List<Product> ConvertTextDBToList(string json)
    {
        return JsonSerializer.Deserialize<List<Product>>(json)
>>>>>>> 2f0ac98b (Материалы 19-го урока)
=======
        return JsonSerializer.Deserialize<List<Product>>(json);
>>>>>>> 56c5f66f (feat: added answer to task 19)
=======
        return JsonSerializer.Deserialize<List<Product>>(json);
=======
        return JsonSerializer.Deserialize<List<Product>>(json)
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
>>>>>>> 240f7224 (feat: added answer to task 21)
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 56c5f66f (feat: added answer to task 19)
=======
>>>>>>> 240f7224 (feat: added answer to task 21)
   

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

<<<<<<< HEAD
<<<<<<< HEAD
=======
    #endregion
<<<<<<< HEAD

    #region PRACTICE_A
>>>>>>> 2f0ac98b (Материалы 19-го урока)
=======
 
>>>>>>> ec9a1010 (Материалы 20-го урока)
=======
>>>>>>> 56c5f66f (feat: added answer to task 19)
=======
=======
    #endregion
 
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
>>>>>>> 240f7224 (feat: added answer to task 21)

    private string  ConvertDBtoJson()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        return JsonSerializer.Serialize(Items, options);
=======
        retunr JsonSerializer.Serialize(Items, options);
>>>>>>> 2f0ac98b (Материалы 19-го урока)
=======
        return JsonSerializer.Serialize(Items, options);
>>>>>>> 56c5f66f (feat: added answer to task 19)
=======
        return JsonSerializer.Serialize(Items, options);
=======
        retunr JsonSerializer.Serialize(Items, options);
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
>>>>>>> 240f7224 (feat: added answer to task 21)
    }

    private void WriteTiDB(string json)
    {
        System.IO.File.WriteAllText(_jsonFilePath, json);
    }

    private void WriteDataToFile()
    { 
        WriteTiDB(ConvertDBtoJson());
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 240f7224 (feat: added answer to task 21)

    }
 
=======
    }
 


<<<<<<< HEAD
>>>>>>> 2f0ac98b (Материалы 19-го урока)
=======

    }
 
>>>>>>> 56c5f66f (feat: added answer to task 19)
=======
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
>>>>>>> 240f7224 (feat: added answer to task 21)
}