
//#Привет! Для интернет магазина "с баZARA" нужно написать серверную часть: 
//4. Создай в классе массив строкового типа для хранения списка продуктов 
//5. Cоздай 3 метода API:
//    - Метод добавляения элемента [Route("store/add")]
//    - Метод удаления элемента [Route("store/delate")] 
//    - метод вывода списка продуктов
    

//*Практика B:*


//1. Создать класс для описания продукта 
//2. Добавить стоимость товара и наличие на скаладе
//3. Возвращать  JSON для всех API
//4. Используй OK и NotFound для сериализации 


//*Практика C:*

//1. Создай метод для изменеия цены по названию продукта
//2. Создай метод для изменения имени товара по имени, т.е. измнение 
//3. Cоздай метод по выводу списка продуктов, которых нет на складе

using Microsoft.AspNetCore.Mvc;
using System;
namespace Example.Controllers;

[ApiController]
public class StoreController : ControllerBase
{
    private static Product[] prod;

        static StoreController()
        {
            prod = new Product[]
            {
                new Product { Name = "Помидоры", Price = 25, StockQuantity = 100 },
                new Product { Name = "Морковь", Price = 13, StockQuantity = 150 },
                new Product { Name = "Гаечный ключ", Price = 545, StockQuantity = 50 }
            };
        }

        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int StockQuantity { get; set; }
        }
    

    
    [HttpGet]
    [Route("store/add/{productName}")]
    public IActionResult AddProduct(string productName, [FromBody] Product product)
    {
        Array.Resize(ref prod, prod.Length + 1);
        prod[prod.Length - 1] = product;
        return Ok("Продукт создан");
    }

    [HttpDelete]
    [Route("store/delete/{productName}")]
    public IActionResult DeleteProduct(string productName)
    {
        var product = Array.Find(prod, p => p.Name == productName);
        if (product != null)
        {
            prod = Array.FindAll(prod, p => p.Name != productName);
            return Ok("Продукт успешно удален");
        }
        else
        {
            return NotFound("Продукт не найден");
        }
    }



    [HttpGet]
    [Route("store/products")]
    public IActionResult Getprod()
    {
        return Ok(prod);
    }


    
    [HttpGet]
    [Route("store/update/price/{productName}")]
    public IActionResult UpdateProductPrice(string productName, [FromBody] Product newProduct)
    {
        var product = Array.Find(prod, p => p.Name == productName);
        if (product != null)
        {
            product.Price = newProduct.Price;
            return Ok("Цена продукта успешно обновлена");
        }
        else
        {
            return NotFound("Продукт не найден");
        }
    }

    [HttpGet]
    [Route("store/netvnalichii")]
    public IActionResult GetOutOfStockprod()
    {
        var stockprod = prod.Where(p => p.StockQuantity == 0).ToList();
        return Ok(stockprod);
    }
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
}


