using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Client
{
    class Program
    {
        public class Product
        {
            [Required]
            [StringLength(100, MinimumLength = 3)]
            public string name { get; set; }

            [Range(0.01, 10000)]
            public double price { get; set; }

            [Range(0, 10000)]
            public int stock { get; set; }
        }

        static bool IsAuthorized = false;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:\n1. Авторизация\n2. Добавление продукта\n3. Вывод списка\n4. Выход");
                Console.Write("Введите действие: ");

                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            Auth();
                            break;
                        case 2:
                            if (IsAuthorized)
                                SendProduct();
                            else
                                Console.WriteLine("Сначала авторизуйтесь.");
                            break;
                        case 3:
                            if (IsAuthorized)
                                DisplayProducts();
                            else
                                Console.WriteLine("Сначала авторизуйтесь.");
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Неправильный номер.");
                            break;
                    }
                }

                Console.WriteLine();
            }
        }

        static void Auth()
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            // Отправка запроса на сервер для аутентификации
            var url = "http://localhost:5087/auth"; 
            var body = JsonSerializer.Serialize(new { login, password });
            var content = new StringContent(body, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync(url, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    IsAuthorized = true;
                    Console.WriteLine("Авторизация успешна!");
                }
                else
                {
                    Console.WriteLine("Неверный логин или пароль.");
                }
            }
        }

        static void SendProduct()
        {
            Console.Write("Введите имя продукта: ");
            string name = Console.ReadLine();

            double price;
            Console.Write("Введите цену продукта: ");
            if (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Неправильный формат числа.");
                return;
            }

            int stock;
            Console.Write("Введите количество на складе: ");
            if (!int.TryParse(Console.ReadLine(), out stock))
            {
                Console.WriteLine("Неправильный формат числа.");
                return;
            }

            var product = new Product { name = name, price = price, stock = stock };
            var url = "http://localhost:5087/products/add"; // Замените на адрес вашего сервера для добавления продукта
            var body = JsonSerializer.Serialize(product);
            var content = new StringContent(body, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync(url, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Продукт успешно добавлен!");
                }
                else
                {
                    Console.WriteLine("Ошибка при добавлении продукта.");
                }
            }
        }

        static void DisplayProducts()
        {
            var url = "http://localhost:5087/products"; // Замените на адрес вашего сервера для получения списка продуктов

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var productsJson = response.Content.ReadAsStringAsync().Result;
                    var products = JsonSerializer.Deserialize<Product[]>(productsJson);

                    Console.WriteLine("Список продуктов:");
                    foreach (var product in products)
                    {
                        Console.WriteLine($"Имя: {product.name}");
                        Console.WriteLine($"Цена: {product.price}");
                        Console.WriteLine($"Количество на складе: {product.stock}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка при получении списка продуктов.");
                }
            }
        }
    }
}