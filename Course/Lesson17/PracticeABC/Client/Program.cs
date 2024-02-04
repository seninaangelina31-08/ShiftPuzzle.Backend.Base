using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Client
{
    class Program
    {

        public class UserCredentials
        {
            [Required]
            [StringLength(100, MinimumLength = 3)]
            public string User { get; set; }
            [Required]
            [StringLength(100, MinimumLength = 3)]
            public string Pass { get; set; }

        }
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
        public static void UpdatePrice()
        {
            if (!IsAuthorized)
            {
                Console.WriteLine("Вы не авторизованы");
                return;
            }

            var url = "http://localhost:5087/store/updateprice"; // Замените на порт вашего сервера
            Console.WriteLine("Введите название продукта:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите новую цену продукта:");
            var price = double.Parse(Console.ReadLine());
            var newPrice = new
            {
                Name = name,
                Price = price
            };
            var client = new HttpClient();
            string json = JsonSerializer.Serialize(newPrice);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(responseContent);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }

        public static void UpdateName()
        {   
            var url = "http://localhost:5087/store/updatename"; // Замените на порт вашего сервера
            Console.WriteLine("Введите название продукта:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите новое название продукта:");
            string newname = Console.ReadLine();
            object new_Name = new
            {
                currentName = name,
                newName = newname
            };
            var client = new HttpClient();
            string json = JsonSerializer.Serialize(new_Name);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(responseContent);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }
        static bool IsAuthorized = false;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:\n1. Авторизация\n2. Добавление продукта\n3. Вывод списка\n4. Выход\n5. Изменить название товара\n6. Изменить цену товара");
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
                        case 5:
                            if (IsAuthorized)
                                UpdateName();
                            else
                                Console.WriteLine("Сначала авторизуйтесь.");
                            break;
                        case 6:
                            if (IsAuthorized)
                                UpdatePrice();
                            else
                                Console.WriteLine("Сначала авторизуйтесь.");
                            break;
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
            UserCredentials a = new UserCredentials { User = login, Pass = password };
            // Отправка запроса на сервер для аутентификации
            var url = "http://localhost:5087/store/auth";
            var body = JsonSerializer.Serialize(a);
            var content = new StringContent(body, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync(url, content).Result;
                Console.WriteLine(response.IsSuccessStatusCode);
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
            var url = "http://localhost:5087/store/add"; // Замените на адрес вашего сервера для добавления продукта
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
            var url = "http://localhost:5087/store/show"; // Замените на адрес вашего сервера для получения списка продуктов

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var productsJson = response.Content.ReadAsStringAsync().Result;
                    var products = JsonSerializer.Deserialize<Product[]>(productsJson);

                    Console.WriteLine("Список продуктов:");
                    Console.WriteLine($"| Название           | Цена  | Количество          |");
                    foreach (var product in products)
                    {
                        Console.WriteLine($"| {product.name,-18} | {product.price,-5} | {product.stock,-19} |");
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