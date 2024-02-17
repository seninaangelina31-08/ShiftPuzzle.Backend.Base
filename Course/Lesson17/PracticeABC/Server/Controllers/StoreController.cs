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
    // Класс продукта
    public class Product
    {
        // Название продукта
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        // Цена продукта
        [Range(0.01, 10000)]
        public double Price { get; set; }

        // Количсетво продуктов на складе
        [Range(0, 10000)]
        public int Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }

    // Данные пользователя для авторизации
    public class UserCredentials
    {
        // Логин
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string User { get; set; }

        // Пароль
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Pass { get; set; }

    }

    // Данные для изменения названия продукта
    public class NewNameData
    {
        // Текущее название
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string CurrentName { get; set; }

        // Новое название продукта
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string NewName { get; set; }

        public NewNameData(string currentName, string newName)
        {
            CurrentName = currentName;
            NewName = newName;
        }
    }

    // Данные для изменения цены продукта
    public class NewPriceData
    {
        // Название продукта
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        // Новая цена продукта
        [Range(0.01, 10000)]
        public double NewPrice { get; set; }

        public NewPriceData(string name, double newPrice)
        {
            Name = name;
            NewPrice = newPrice;
        }
    }

    // Список продуктов
    private List<Product> Items = new List<Product>();

    // Путь к БД
    private readonly string jsonFilePath = "DataBase.json";

    public StoreController()
    {
        // Подгружаем данные из БД
       ReadDataFromFile();
    }

    // Получить те продукты, которых нет в наличии
    [HttpGet]
    [Route("/store/outofstock")]
    public IActionResult OutOfStock()
    {
        // Продукты, которых нет в наличии
        var outOfStockItems = Items.Where(p => p.Stock == 0).ToList();
        if (outOfStockItems.Any())
        {
            // Спсиок тех продуктов, которых нет в наличии
            return Ok(outOfStockItems);
        }
        else
        {
            // Все продукты в наличии
            return Ok("Все продукты в наличии");
        }
    }

    // Авторизация пользователя
    [HttpPost]
    [Route("/store/auth")]
    public IActionResult Auth([FromBody] UserCredentials user)
    { 
        if((user.User == "admin") && (user.Pass == "123"))
        {
            // Пользователь ввел корректные логин и пароль
            return Ok($"{user.User} авторизован");
        }
        else
        {
            // Пользователь ввел некорректные логин и пароль
            return NotFound($"{user.User} не найден");
        }

    }

    // Добавление продукта
    [HttpPost]
    [Route("/store/add")]
    public IActionResult Add([FromBody] Product newProduct)
    { 
        // Добавляем продукт в список
        Items.Add(newProduct);
        // Пишем изменения в файл
        WriteDataToFile();
        return Ok(Items);
    }

    // Удаление продукта
    [HttpPost]
    [Route("/store/delete")]
    public IActionResult Delete(string name)
    {
        // Получаем продукт
        var product = Items.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            // Удаляем продукт из спсика
            Items.Remove(product);
            // Пишем изменения в файл
            WriteDataToFile();
            return Ok($"{name} удален");
        }
        else
        {
            // Продукт не нашелся
            return NotFound($"{name} не найден");
        }
    }

    // Получение списка прордукта
    [HttpGet]
    [Route("/store/show")]
    public IActionResult Show()
    {
        // Получаем список продукта
        return Ok(Items);
    }

    // Изменение цены продукта
    [HttpPost]
    [Route("/store/updateprice")]
    public IActionResult UpdatePrice([FromBody] NewPriceData newPriceData)
    {
        // Получаем продукт
        var product = Items.FirstOrDefault(p => p.Name == newPriceData.Name);
        if (product != null)
        {
            // Меняем цену продукта
            product.Price = newPriceData.NewPrice;
            // Пишем изменения в БД
            WriteDataToFile();
            return Ok($"{newPriceData.Name} обновлен с новой ценой: {newPriceData.NewPrice}");
        }
        else
        {
            // Продукт не нашелся
            return NotFound($"Продукт {newPriceData.Name} не найден");
        }
    }

    // Изменение названия продукта
    [HttpPost]
    [Route("/store/updatename")]
    public IActionResult UpdateName([FromBody] NewNameData newNameData)
    {
        // Получаем продукт
        var product = Items.FirstOrDefault(p => p.Name == newNameData.CurrentName);
        if (product != null)
        {
            // Меняем название продукта
            product.Name = newNameData.NewName;
            // Пишем изменения в БД
            WriteDataToFile();
            return Ok($"Имя продукта изменено с {newNameData.CurrentName} на {newNameData.NewName}");
        }
        else
        {
            // Продукт не нашелся
            return NotFound($"Продукт {newNameData.CurrentName} не найден");
        }
    }

    // Чтение данных из БД
    private void ReadDataFromFile()
    {
        // Если путь к БД корректный
        if (System.IO.File.Exists(jsonFilePath))
        {
            // Считываем JSON
            string json = System.IO.File.ReadAllText(jsonFilePath);
            // Выполняем десериализацию
            Items = JsonSerializer.Deserialize<List<Product>>(json);
        }
    }

    private void WriteDataToFile()
    {
        // Выполнем сереализацию
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(Items, options);
        // Пишем полученный JSON в файл
        System.IO.File.WriteAllText(jsonFilePath, json);
    }


}