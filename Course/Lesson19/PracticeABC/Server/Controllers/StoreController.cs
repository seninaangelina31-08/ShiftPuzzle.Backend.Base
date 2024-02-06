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

    private readonly DBModel _productRepository;

    public StoreController(DBModel productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpPost]
    [Route("/store/updateprice")]
    public IActionResult UpdatePrice(string name, double newPrice)
    {
        var product = _productRepository.GetProductName(name);
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
        var product = _productRepository.GetProductName(currentName);
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
        var outOfStockItems = _productRepository.GetOutOfStock();
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
        _productRepository.ItemsAdd(newProduct);
        _productRepository.WriteDataToFile();
        return Ok(_productRepository.GetItems());
    }


    [HttpPost]
    [Route("/store/delete")]
    public IActionResult Delete(string name)
    {
        var product = _productRepository.GetProductName(name);
        if (product != null)
        {
            _productRepository.ItemsRemove(product);
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
        return Ok(_productRepository.GetItems());
    }

    [HttpGet]
    [Route("/store/backup")]
    public IActionResult BackUp()
    {
        _productRepository.SaveFilesInBackUp();
        return Ok("Файлы сохранены в резервную копиюы");
    }
}