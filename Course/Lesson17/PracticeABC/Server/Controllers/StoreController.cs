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
# Практика А:

//1. Добавить чтение и запись (функция WriteToFile / ReadFile)
//1. Добавить графическией интрефейс для клиента с возможность выбора 3 функций (1. авторизация 2. Добавление продукта 3. Вывод спика 4. Выход)

//> Подсказка

//1. **Класс `Program`**:
//   - **Поля**:
//     - `IsAuthorized`: Статическое булево поле, указывающее, авторизован ли пользователь.
//   - **Методы**:
//     - `Main(string[] args)`: Основной метод программы, который представляет консольное меню и управляет действиями пользователя.
//     - `DisplayProducts()`: Метод для получения и вывода списка продуктов с сервера.
//     - `SendProduct()`: Метод для отправки информации о продукте на сервер.
//     - `Auth()`: Метод для аутентификации пользователя на сервере.

//2. **Класс `Product`**:
//   - **Свойства**:
//     - `name`: Строковое свойство, представляющее имя продукта.
//     - `price`: Свойство с плавающей точкой двойной точности, представляющее цену продукта.
//     - `stock`: Свойство целочисленного типа, представляющее количество продукта на складе.

//3. **Взаимодействие с внешними системами**:
//   - Класс использует `HttpClient` для отправки HTTP-запросов к серверу.
//   - Осуществляется взаимодействие с сервером посредством HTTP-запросов для аутентификации пользователя, отправки и получения информации о продуктах.
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

    // поле с путем до базы данных 

    public StoreController()
    {
       // чтение
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
        Items.Add(newProduct);
        // запись
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
        // опишу логику
    }

    private void WriteDataToFile()
    {
        // опишу логику
    }


}