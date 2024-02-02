using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;

namespace Client;

class Program
{ 
    [System.Serializable]
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
            var url = "http://localhost:5087/store/show"; // Замените на порт вашего сервера
            var client = new HttpClient();   
            var response = client.GetAsync(url).Result;  
            string responseContent = response.Content.ReadAsStringAsync().Result;
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(responseContent);

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("| Название продукта  | Цена  | Количество на складе|"); 
            foreach(var product in products)
                Console.WriteLine($"| {product.name, -18} | {product.price, -5} | {product.stock, -19} |");
            Console.WriteLine("-----------------------------------------------------------------");
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

            var product = new
            {
                Name = name,
                Price = price,
                Stock = stock
            };

            var client = new HttpClient(); 
            var json = JsonSerializer.Serialize(product);
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

    public static void UpdatePrice()
    {        
            if(!IsAuthorized)
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
            if(!IsAuthorized)
            {
                Console.WriteLine("Вы не авторизованы");
                return;        
            }
        
            var url = "http://localhost:5087/store/updatename"; // Замените на порт вашего сервера
            Console.WriteLine("Введите название продукта:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите новое название продукта:");
            var newname = Console.ReadLine();
            var new_Name = new
            {
                Name = name,
                NewName = newname
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

    public static void Auth()
    {       
        
        
            var url = "http://localhost:5087/store/auth"; // Замените на порт вашего сервера, также замените символы на правильный апи
            var userData = new
            {
                User = "admin",
                Pass = "123"
            };

            var client = new HttpClient(); 
            var json = JsonSerializer.Serialize(userData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(url, content).Result;
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


    static void Main(string[] args)
    { 
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
                {
                    Console.WriteLine("Выберите опцию: (1. Авторизация 2. Обновление цены 3. Обновление имени 4. Добавление продукта  5. Вывод спика 6. Выход)");
                     

                    var choice = Console.ReadLine();

                    switch (choice)
                    { 
                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте снова.");
                            break;
                        case "1":
                            Auth();
                            break;
                        case "2":
                            UpdatePrice();
                            break;
                        case "3":
                            UpdateName();
                            break;
                        case "4":
                            SendProduct();
                            break;
                        case "5":
                            DisplayProducts();
                            break;
                        case "6":
                            return;
                    }
                }
    }
}