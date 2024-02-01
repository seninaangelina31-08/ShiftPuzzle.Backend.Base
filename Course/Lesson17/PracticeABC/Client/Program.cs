using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text;
using System.Text.Json;


namespace Client;
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

        static void DisplayProducts()
            {
                var url = "http://localhost:5087/store/show"; 
                
                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var productsJson = response.Content.ReadAsStringAsync().Result;
                        var products = JsonSerializer.Deserialize<Product[]>(productsJson);

                        Console.WriteLine("List of Products:");
                        foreach (var product in products)
                        {
                            Console.WriteLine("-----------------------------------------------------------------");
                            Console.WriteLine($"Name: {product.name}, price: {product.price}, count: {product.stock}");
                            Console.WriteLine("-----------------------------------------------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Something is wrong.");
                    }
                }
            }


        public static void SendProduct()
        {        
                if(!IsAuthorized)
                {
                    Console.WriteLine("Вы не авторизованы");
                    return;        
                }
            
                var url = "http://localhost:5087/store/add"; // Замените на порт вашего сервера
                
                Console.WriteLine("Введите название продукта:");
                var name = Console.ReadLine();
                Console.WriteLine("Введите цену продукта:");
                var price = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество на складе:");
                var stock = int.Parse(Console.ReadLine());

                var product = new Product
                {
                    name = name,
                    price = price,
                    stock = stock
                };
                var body = JsonSerializer.Serialize(product);
                var content = new StringContent(body, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
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
        }


        public static void Auth()
        {       
            //Console.Write("Введите логин: ");
            //string login = Console.ReadLine();

            //Console.Write("Введите пароль: ");
            //string password = Console.ReadLine();

            var userData = new
            {
                User = "admin",
                Pass = "123"
            };

            var url = "http://localhost:5087/store/auth"; // Замените на адрес вашего сервера для аутентификации
            var client = new HttpClient(); 
            var json = JsonSerializer.Serialize(userData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
                
            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Cool!!!!");
                IsAuthorized = true;
            }
            else
            {
                Console.WriteLine("Error");
                IsAuthorized = false;
            }
        }

        public static void UpName()
        {       

            Console.Write("Enter current name: ");
            string name = Console.ReadLine();

            Console.Write("Enter new name: ");
            string newname = Console.ReadLine();

            var url = $"http://localhost:5087/store/updatename?currentName={name}&newName={newname}"; // Замените на адрес вашего сервера для аутентификации

            using (var client = new HttpClient())
            { 
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("curRRntName", name)
                });
                
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
        }

        public static void UpPrice()
        {       

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter new price: ");
            string newprice = Console.ReadLine();

            var url = $"http://localhost:5087/store/updateprice?name={name}&newPrice={newprice}"; // Замените на адрес вашего сервера для аутентификации

            using (var client = new HttpClient())
            { 
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("curRRntName", name)
                });
                
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
        }


        static void Main(string[] args)
        { 
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Выберите опцию:");
                        

                //var choice = Console.ReadLine();
                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    { 
                    case 1:
                        Auth();
                        break;

                    case 2:
                        SendProduct();
                        break;
                            
                    case 3:
                        DisplayProducts();
                        break;
                            
                    case 4:
                        break;

                    case 5:
                        UpPrice();
                        break;

                    case 6:
                        UpName();
                        break;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }