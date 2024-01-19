using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace PracticeAB
{
    [System.Serializable] public class User {
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public bool isVerified { get; set; }

    public User() { }

    public User(int id, string name, string email, bool is_verified) {
        this.id = id;
        this.name = name;
        this.email = email;
        this.isVerified = is_verified;
    }


}

[System.Serializable] public class Order {
    public string orderId { get; set; }
    public string customerName { get; set; }
    public double totalPrice { get; set; }
    public List<string> items { get; set; }
    
    public Order(){ }

    public Order(string order_id, string customer_name, int total_price, List<string> items) {
        this.orderId = order_id;
        this.customerName = customer_name;
        this.totalPrice = total_price;
        this.items = items;
    }
}

[System.Serializable] public class Book {
    public string title { get; set; }
    public string author { get; set; }
    public int year { get; set; }

    public Book(){ }

    public Book(string title, string author, string year) {
        this.title = title;
        this.author = author;
        this.year = Convert.ToInt32(year);
    }
}

[System.Serializable] public class Library {
    public string libraryName { get; set; }
    public List<Book> books { get; set; }

    public Library(){ }

    public Library(string l_name, List<Book> books) {
        this.libraryName = l_name;
        this.books = books; 
    }
}

class Program {
        static void Main(string[] args) {
            string path = "1.json";
            string JsonFromFile = File.ReadAllText(path);

            // Переделываем json в класс (десериализация)
            User user = JsonSerializer.Deserialize<User>(JsonFromFile);

            // Сливаем в открытый доступ персональные данные Ивана :)
            Console.WriteLine($"--- Task A1 ---\nEmail: {user.email}; ID: {user.id}");

            path = "2.json";
            JsonFromFile = File.ReadAllText(path);

            // Переделываем json в класс (десериализация)
            Order order_1 = JsonSerializer.Deserialize<Order>(JsonFromFile);

            // Выводим список товаров
            Console.WriteLine("--- Task A2 ---\nСписок товаров: ");
            foreach (var item in order_1.items) {
                Console.WriteLine($"-{item}");
            }
            // Выводим цену до и после скидки
            Console.WriteLine($"Сумма до скидки: {order_1.totalPrice}\nСумма после скидки: {order_1.totalPrice * 0.9}");

            path = "4.json";
            JsonFromFile = File.ReadAllText(path);
            // Переделываем json в класс (десериализация)
            Order order_2 = JsonSerializer.Deserialize<Order>(JsonFromFile);
            // Докидываем салфетки
            order_2.items.Add("Салфетки для монитора");
            // Пересчитываем цену
            order_2.totalPrice = (order_2.totalPrice + 1550) * 0.98;
            // Собираем новый json (сериализация)
            string JsonToFile = JsonSerializer.Serialize(order_2);
            // И пишем его в новый файл
            File.WriteAllText("4_solution.json", JsonToFile);

            path = "5.json";
            JsonFromFile = File.ReadAllText(path);
            
            // Переделываем json в класс (десериализация)
            Library library_1 = JsonSerializer.Deserialize<Library>(JsonFromFile);

            library_1.books.Add(new Book("Евгений Онегин", "Александр Пушкин", "1833"));
            JsonToFile = JsonSerializer.Serialize(library_1);
            File.WriteAllText("5_solution.json", JsonToFile);
        }
    }
}
