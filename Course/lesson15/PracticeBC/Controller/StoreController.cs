using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Net;


namespace PracticeB.Controller;

[ApiController]
public class StoreController : ControllerBase
{
    public static readonly List<Product> products = new List<Product>();

    public static void ShowProductList(List<Product> ListProduct)
    {
        foreach (Product prod in ListProduct)
        {
            Console.WriteLine(prod.name);
        }
    }


    // Практика B

    [HttpGet]
    [Route("/store/add")]

    public IActionResult Add(string name, int id, int price, bool available)
    {
        Product ObjProduct = new Product(name, id, price, available);
        foreach (Product prod in products)
        {
            if (prod.id == id)
            {
                return NotFound($"Продукт с id={id} уже существует");
            }
        }
        products.Add(ObjProduct);
        string JsonTo = JsonSerializer.Serialize(ObjProduct);
        return Ok($"Объект {JsonTo} добавлен в список");
    }

    [HttpGet]
    [Route("/store/delete")]

    public IActionResult Delete(string product_name)
    {
        foreach (Product item in products)
        {
            if (item.name == product_name)
            {
                products.Remove(item);
                ShowProductList(products);
                string JsonTo = JsonSerializer.Serialize(item);
                return Ok($"Объект {JsonTo} удален");
            }
        }
        return NotFound($"Объект с именем {product_name} не найден");
    }

    [HttpGet]
    [Route("/store/showproducts")]

    public IActionResult showproducts()
    {
        List<string> productList = new List<string>();
        foreach (Product prod in products)
        {
            string JsonTo = JsonSerializer.Serialize(prod);
            productList.Add(JsonTo);
        }
        return Ok(string.Join(", ", productList));
    }


    // Практика С

    [HttpGet]
    [Route("/store/changeprice")]
    public IActionResult ChangePrice(string name_product, int new_price)
    {
        foreach (Product prod in products)
        {
            if (prod.name == name_product)
            {
                prod.price = new_price;
                string JsonTo = JsonSerializer.Serialize(prod);
                return Ok($"Произошло изменение продукта {JsonTo}");
            }
        }
        return NotFound($"Не найден продукт с именем {name_product}");
    }

    [HttpGet]
    [Route("/store/changename")]
    public IActionResult ChangeName(int id_product, string new_name)
    {
        foreach (Product prod in products)
        {
            if (prod.id == id_product)
            {
                prod.name = new_name;
                string JsonTo = JsonSerializer.Serialize(prod);
                return Ok($"Произошло изменение продукта {JsonTo}");
            }
        }
        return NotFound($"Не найден продукт с id={id_product}");
    }

    [HttpGet]
    [Route("/store/productsinavai")]

    public IActionResult ProductsInAwai()
    {
        List<string> productList = new List<string>();
        foreach (Product prod in products)
        {
            if (prod.available == false)
            {
                string JsonTo = JsonSerializer.Serialize(prod);
                productList.Add(JsonTo);
            }
        }
        return Ok(string.Join(", ", productList));
    }
}


[System.Serializable] public class Product
{
    public string name { get; set; }
    public int id { get; set; }
    public int price { get; set; }
    public bool available { get; set; }

    public Product() { }

    public Product(string Name, int Id, int Price, bool Available)
    {
        id = Id;
        name = Name;
        price = Price;
        available = Available;
    }
}