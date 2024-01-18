using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Example;

// объявление сериализуемого класса Product
[System.Serializable] public class Product
{
    // поля класса
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public List<string> Links { get; set; }

    public Product() { } // Пустой конструктор для десериализации

    // конструктор класса
    public Product(string name, string description, int price, List<string> links)
    {
        this.Name = name;
        this.Description = description;
        this.Price = price;
        this.Links = links;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<string> appleLinks = new List<string>{"link1", "link2"}; // лист со ссылками
        Product apple = new Product("Granny Smith", "Green Apples. Tasty", 300, appleLinks); // создание объекта продукта (яблоки)

        // Сериализация в JSON
        string json = JsonSerializer.Serialize(apple);
        Console.WriteLine(json); // вывод сериализованного объекта в консоль

        const string path = "apple.json";
        File.WriteAllText(path, json); // запись объекта в JSON файл

        // Десериализация из JSON
        string jsonFromFile = File.ReadAllText(path);
        Product read_apple = JsonSerializer.Deserialize<Product>(jsonFromFile);

        if (read_apple != null)
        {
            // вывод полей объекта
            Console.WriteLine($"Name: {read_apple.Name}\nDescription: {read_apple.Description}\nPrice: {read_apple.Price}");

            // вывод содержимого списка ссылок
            Console.WriteLine("Links:");
            foreach (string link in read_apple.Links)
            {
                Console.WriteLine(link);
            }
        }
    }
}
