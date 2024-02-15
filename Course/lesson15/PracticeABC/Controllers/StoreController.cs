using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


namespace PracticeABC.Controllers;

[ApiController]
[Route("api/")]
public class StoreController : ControllerBase
{
    // Список продуктов
    private static readonly ProductList productList = new ProductList(
        [
            new Product("Pineapple", 250.99, true),
            new Product("Apple", 25.99, true),
            new Product("FruitNotPen", 666.666, false),
        ]
    );

    // Метод добавления продукта в список
    [HttpGet("store/add")]
    public ActionResult<ProductList> Add(string name, double price, bool availability)
    {   
        // Добавляем в список новый объект продукта с соответствующими параметрами
        productList.Items.Add(new Product(name, price, availability));
        return productList;
    }

    // Метод удаления продукта из списка
    [HttpGet("store/delete")]
    public ActionResult<ProductList> Delete(string name)
    {
        // Пробегаемся по списку продуктов и ищем тот, который нужно удалить
        foreach (var item in productList.Items)
        {
            // Проверяем название продукта на соответствие тому, что мы ищем
            if (item.Name == name)
            {
                // Если нужный продукт нашелся, то его удаляем
                productList.Items.Remove(item);
                return productList;                
            }
        }
        // Если не нашлось то, что нужно было удалить :(
        return BadRequest(productList);
    }
    
    // Метод получения спсика продуктов
    [HttpGet("store/get")]
    public ActionResult<ProductList> GetInfo()
    {
        // Просто возвращаем список продуктов )
        return productList;
    }

    // Метод изменения цены продукта
    [HttpGet("store/reprice")]
    public ActionResult<ProductList> Reprice(string name, double newPrice)
    {
        // Вызываем у продукта метод изменения цены
        productList.Reprice(name, newPrice);
        return productList;
    }

    // Метод изменения названия продукта
    [HttpGet("store/rename")]
    public ActionResult<ProductList> Rename(string oldName, string newName)
    {
        // Вызываем у продукта метод изменения названия
        productList.Rename(oldName, newName);
        return productList;
    }

    // Метод вывода списка тех продуктов, которых нет на складе
    [HttpGet("store/nonavailable")]
    public ActionResult<ProductList> GetNonAvailableProducts()
    {
        // С помощью метода получаем список тех продуктов, которых нет на складе
        return new ProductList(productList.GetNonAvailableProducts());
    }

}