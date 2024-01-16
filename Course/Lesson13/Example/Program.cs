using System;
using System.Collections.Generic; // библиотека для работы с List и Dictionary
using System.Text.Json; // библиотека для работы с JSON

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
        
        const string path = "apple.json";

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
