namespace PracticeABC;

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
    
    private readonly IProductRepository _productRepository;

    public StoreController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

        [HttpPost]
        [Route("/store/updateprice")]
        public async Task<IActionResult> UpdatePrice(string name, double newPrice)
        {
            var product = await _productRepository.GetProductByName(name);
            if (product != null)
            {
                product.Price = newPrice;
                _productRepository.UpdateProduct(product);
                return Ok($"{name} обновлен с новой ценой: {newPrice}");
            }
            else
            {
                return NotFound($"Продукт {name} не найден");
            }
        }

        [HttpPost]
        [Route("/store/updatename")]
        public async Task<IActionResult> UpdateName(string currentName, string newName)
        {
            var product = await _productRepository.GetProductByName(currentName);
            if (product != null)
            {
                product.Name = newName;
                _productRepository.UpdateProduct(product);
                return Ok($"Имя продукта изменено с {currentName} на {newName}");
            }
            else
            {
                return NotFound($"Продукт {currentName} не найден");
            }
        }

        [HttpGet]
        [Route("/store/outofstock")]
        public async Task<IActionResult> OutOfStock()
        {
            var outOfStockItems = await _productRepository.GetAllProducts();
            outOfStockItems = outOfStockItems.Where(p => p.Stock == 0).ToList();
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
        public async Task<IActionResult> Auth([FromBody] UserCredentials user)
        {
            if ((user.user == "admin") && (user.pass == "123"))
            {
                return Ok($"{user.user} авторизован");
            }
            else
            {
                return NotFound($"{user.user} не найден");
            }
        }

        [HttpPost]
        [Route("/store/add")]
        public async Task<IActionResult> Add([FromBody] Product newProduct)
        { 
            await _productRepository.AddProduct(newProduct);
            return Ok(await _productRepository.GetAllProducts());
        }

        [HttpPost]
        [Route("/store/delete")]
        public async Task<IActionResult> Delete(string name)
        {
            var product = await _productRepository.GetProductByName(name);
            if (product != null)
            {
                await _productRepository.DeleteProduct(name);
                return Ok($"{name} удален");
            }
            else
            {
                return NotFound($"{name} не найден");
            }
        }

        [HttpGet]
        [Route("/store/show")]
        public Task<IActionResult> Show()
        {
            return Ok(await _productRepository.GetAllProducts());
        }
      

}