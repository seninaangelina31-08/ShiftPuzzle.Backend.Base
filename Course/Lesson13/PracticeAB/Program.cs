using System;
using System.Collections.Generic; // библиотека для работы с List и Dictionary
using System.Text.Json; // библиотека для работы с JSON

namespace PracticeAB

{
    [Serializable]
    public class User
    {
        public string Email { get; set; }
        public int UserId { get; set; }
    }

    [Serializable]
    public class Product
    {
        public string orderId { get; set; }
        public string customerName { get; set; }
        public int totalPrice { get; set; }
        public List<string> items { get; set; }
    }

    [Serializable]
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }

    public class Library
    {
        public string LibraryName { get; set; }
        public List<Book> Books { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Вывод почты и ID пользователя Иванов Иван
            User user = new User
            {
                Email = "ivanov@example.com",
                UserId = 12345
            };

            Console.WriteLine("Почта: " + user.Email);
            Console.WriteLine("ID пользователя: " + user.UserId);
            Console.WriteLine();

            // Вывод списка купленных товаров Анной и применение 10% скидки
            List<Product> products = new List<Product>
            {
                new Product
                {
                    orderId = "ORD10245",
                    customerName = "Анна Петрова",
                    totalPrice = 5600,
                    items = new List<string> { "Ноутбук", "Мышь" }
                }
            };

            Console.WriteLine("Список товаров Анны Петровой:");

            foreach (Product product in products)
            {
                Console.WriteLine("Общая цена без скидки: " + product.totalPrice);
                Console.WriteLine("Товары: " + product.items);

                // Применяем скидку
                double discountedPrice = product.totalPrice * 0.9;
                Console.WriteLine("Цена со скидкой: " + discountedPrice);
                Console.WriteLine();
            }

            // Добавление салфеток для мониторов в список покупок Анны и применение скидки 2%
            Product salfetki = new Product
            {
                orderId = "ORD10245",
                customerName = "Анна Петрова",
                totalPrice = 1550,
                items = new List<string> { "Салфетки для мониторов" }
            };

            products.Add(salfetki);

            Console.WriteLine("Список товаров Анны Петровой после добавления салфеток:");

            foreach (Product product in products)
            {
                Console.WriteLine("Общая цена без скидки: " + product.totalPrice);
                Console.WriteLine("Товары: " + product.items);

                // Применяем скидку
                double discountedPrice = product.totalPrice * 0.98; // 2% скидка
                Console.WriteLine("Цена со скидкой: " + discountedPrice);
                Console.WriteLine();
            }

            // Сериализация и запись в файл
            string jsonString = JsonSerializer.Serialize(products);

            File.WriteAllText("products.json", jsonString);


            // Создание списка книг
            List<Book> books = new List<Book>
            {
                new Book
                {
                    Title = "Война и мир",
                    Author = "Лев Толстой",
                    Year = 1869
                },
                new Book
                {
                    Title = "Мастер и Маргарита",
                    Author = "Михаил Булгаков",
                    Year = 1967
                }
            };

            //Создание объекта библиотеки
            Library library = new Library
            {
                LibraryName = "Городская библиотека",
                Books = books
            };

            // Сериализация объекта в JSON
            string jsonStringB = JsonSerializer.Serialize(library);

            // Запись JSON в файл
            File.WriteAllText("library.json", jsonStringB);

            Console.WriteLine("Файл сохранен успешно.");
        }
    }
}