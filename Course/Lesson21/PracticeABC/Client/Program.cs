<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿﻿using System;
=======
﻿using System;
>>>>>>> 78543e51 (матераилы 21-го урока)
=======
﻿﻿using System;
>>>>>>> 7a4262c4 (feat: added answer to task 21 (true commit))
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace Client
{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
>>>>>>> main
=======
>>>>>>> 7a4262c4 (feat: added answer to task 21 (true commit))


    [Serializable]
    public class Product
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string name { get; set; }

        [Range(0.01, 10000)] 
        public double price { get; set; }

        [Range(0, 10000)]
        public int stock { get; set; }

        public Product(string nname, double nprice, int nstock)
        {
            name = nname;
            price = nprice;
            stock = nstock;
        }

        public Product()
        {
            // Пустой конструктор
        }
    }

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01
>>>>>>> main
=======
>>>>>>> 7a4262c4 (feat: added answer to task 21 (true commit))
    public class Program
    {
        private const string BaseUrl = "http://localhost";
        private const string Port = "5258";
<<<<<<< HEAD
=======
    public class Program
    {
        private const string BaseUrl = "http://localhost";
        private const string Port = "5087";
>>>>>>> 78543e51 (матераилы 21-го урока)
=======
>>>>>>> 7a4262c4 (feat: added answer to task 21 (true commit))
        private const string AuthMethod = "/store/auth";
        private const string AddProductMethod = "/store/add";
        private const string ShowProductsMethod = "/store/show";

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        

=======
<<<<<<< HEAD
=======
>>>>>>> 78543e51 (матераилы 21-го урока)
        [Serializable]
        public class Product
        {
            [Required]
            [StringLength(100, MinimumLength = 3)]
            public string Name { get; set; }

            [Range(0.01, 10000)]
            public double Price { get; set; }

            [Range(0, 10000)]
            public int Stock { get; set; }
        }
<<<<<<< HEAD
=======
        

>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01
>>>>>>> main
=======
>>>>>>> 78543e51 (матераилы 21-го урока)
=======
        

>>>>>>> 7a4262c4 (feat: added answer to task 21 (true commit))

        private static bool IsAuthorized = false;
        private static readonly HttpClient Client = new HttpClient();

        private static void DisplayProducts()
        {
            var url = $"{BaseUrl}:{Port}{ShowProductsMethod}";

            var response = Client.GetAsync(url).Result;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 7a4262c4 (feat: added answer to task 21 (true commit))
            var responseContent = response.Content.ReadAsStringAsync().Result; 
            Console.WriteLine(responseContent);
            var products = JsonSerializer.Deserialize<List<Product>>(responseContent);


<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
>>>>>>> 78543e51 (матераилы 21-го урока)
            var responseContent = response.Content.ReadAsStringAsync().Result;

            var products = JsonSerializer.Deserialize<List<Product>>(responseContent);

<<<<<<< HEAD
=======
            var responseContent = response.Content.ReadAsStringAsync().Result; 
            Console.WriteLine(responseContent);
            var products = JsonSerializer.Deserialize<List<Product>>(responseContent);


>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01
>>>>>>> main
=======
>>>>>>> 78543e51 (матераилы 21-го урока)
=======
>>>>>>> 7a4262c4 (feat: added answer to task 21 (true commit))
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("| Название продукта | Цена | Количество на складе |");
            Console.WriteLine("-----------------------------------------------------------------");

            foreach (var product in products)
            {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                Console.WriteLine($"| {product.name, -18} | {product.price, -5} | {product.stock, -19} |"); 
=======
<<<<<<< HEAD
                Console.WriteLine($"| {product.Name, -18} | {product.Price, -5} | {product.Stock, -19} |");
=======
                Console.WriteLine($"| {product.name, -18} | {product.price, -5} | {product.stock, -19} |"); 
>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01
>>>>>>> main
=======
                Console.WriteLine($"| {product.Name, -18} | {product.Price, -5} | {product.Stock, -19} |");
>>>>>>> 78543e51 (матераилы 21-го урока)
=======
                Console.WriteLine($"| {product.name, -18} | {product.price, -5} | {product.stock, -19} |"); 
>>>>>>> 7a4262c4 (feat: added answer to task 21 (true commit))
            }

            Console.WriteLine("-----------------------------------------------------------------");
        }

        private static void SendProduct()
        {
            if (!IsAuthorized)
            {
                Console.WriteLine("Вы не авторизованы");
                return;
            }

            var url = $"{BaseUrl}:{Port}{AddProductMethod}";

            Console.WriteLine("Введите название продукта:");
            var name = Console.ReadLine();

            Console.WriteLine("Введите цену продукта:");
            var price = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество на складе:");
            var stock = int.Parse(Console.ReadLine());

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            var product = new Product(name,price,stock); 
=======
<<<<<<< HEAD
=======
>>>>>>> 78543e51 (матераилы 21-го урока)
            var product = new Product
            {
                Name = name,
                Price = price,
                Stock = stock
            };
<<<<<<< HEAD
=======
            var product = new Product(name,price,stock); 
>>>>>>> 53ced403e07941094cf29678628e51a5621c4c01
>>>>>>> main
=======
>>>>>>> 78543e51 (матераилы 21-го урока)
=======
            var product = new Product(name,price,stock); 
>>>>>>> 7a4262c4 (feat: added answer to task 21 (true commit))

            var json = JsonSerializer.Serialize(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = Client.PostAsync(url, content).Result;

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

        private static void Auth()
        {
            var url = $"{BaseUrl}:{Port}{AuthMethod}";

            Console.WriteLine("Введите имя пользователя:");
            var user = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            var pass = Console.ReadLine();

            var userData = new
            {
                User = user,
                Pass = pass
            };

            var json = JsonSerializer.Serialize(userData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = Client.PostAsync(url, content).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(responseContent);
                IsAuthorized = true;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                IsAuthorized = false;
            }
        }

        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("Выберите опцию:");
                Console.WriteLine("1. Авторизация");
                Console.WriteLine("2. Отправить продукт");
                Console.WriteLine("3. Вывести список");
                Console.WriteLine("4. Выйти");
                Console.Write("Введите ваш выбор: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Auth();
                        break;
                    case "2":
                        if (!IsAuthorized)
                        {
                            Console.WriteLine("Вы не авторизованы.");
                            break;
                        }

                        SendProduct();
                        break;
                    case "3":
                        DisplayProducts();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
<<<<<<< HEAD
<<<<<<< HEAD
}
=======
}
>>>>>>> 78543e51 (матераилы 21-го урока)
=======
﻿
>>>>>>> 240f7224 (feat: added answer to task 21)
=======
}
>>>>>>> 7a4262c4 (feat: added answer to task 21 (true commit))
