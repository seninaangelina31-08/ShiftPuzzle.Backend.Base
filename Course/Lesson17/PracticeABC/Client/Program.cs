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
            var url = "http://localhost:5087/store/show";
            
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var productsJson = response.Content.ReadAsStringAsync().Result;
                    var products = JsonSerializer.Deserialize<Product[]>(productsJson);

                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("| Название продукта | Цена | Количество на складе |"); 

                    foreach (var product in products)
                    {
                        Console.WriteLine($"| {product.name, -18} | {product.price, -5} | {product.stock, -19} |");

                    }
                    Console.WriteLine("-----------------------------------------------------------------");
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
        
            var url = "http://localhost:5087/store/add";
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

    public static void UpdateName()
    {
        if(!IsAuthorized)
        {
            Console.WriteLine("Вы не авторизованы");
            return;        
        }

        Console.WriteLine("Введите название продукта:");
        var name = Console.ReadLine();
        Console.WriteLine("Введите новое название продукта:");
        var newname = Console.ReadLine();
        
        var url = "http://localhost:5087/store/updatename";
        using (HttpClient client = new HttpClient())
        {
        
            var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("currentName", name),
                    new KeyValuePair<string, string>("newName", newname)
                }
            );


            // var client = new HttpClient(); 
            // var json = JsonSerializer.Serialize(product);
            // var content = new StringContent(json, Encoding.UTF8, "application/json");

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
        
        
            var url = "http://localhost:5087/store/auth";
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
                    Console.WriteLine("\nВыберите опцию:");
                    bool flag = false; 

                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Auth();
                            break;
                        case "2":
                            SendProduct();
                            break;
                        case "3":
                            DisplayProducts();
                            break;
                        case "4":
                            UpdateName();
                            break;
                        case "5":
                            DisplayProducts();
                            break;
                        case "6":
                            flag = true;
                            break;
                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте снова.");
                            break;
                    }
                    if (flag)
                    {
                        break;
                    }
                }
    }
}