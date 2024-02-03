using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;
using System.Net;
using System.IO;

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

    public static string Request(string url)
    {
        WebRequest webrequest = WebRequest.Create(url);
        WebResponse response = webrequest.GetResponse();
        Stream stream = response.GetResponseStream();
        StreamReader streamReader = new StreamReader(stream);
        string json_string = streamReader.ReadToEnd();
        streamReader.Close();
        response.Close();
        return json_string;
    }

    static void DisplayProducts()
        {
            var url = "http://localhost:5087/store/show"; // Замените на порт вашего сервера
            
            // реализуй логику


            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("| Название продукта | Цена | Количество на складе |"); 

            List<Product> products = JsonSerializer.Deserialize<List<Product>>(Request(url));
            foreach (var product in products)
            {
                Console.WriteLine($"| {product.name, -17} | {product.price, -4} | {product.stock, -19} |");
            }       

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

    public static void UpdateName()
    {
        if(!IsAuthorized)
        {
            Console.WriteLine("Вы не авторизованы!");
            return;        
        }

        Console.Write("Введите текущее имя продукта: ");
        string name = Console.ReadLine();
        Console.Write("Введите новое имя продукта: ");
        string new_name = Console.ReadLine();
        var url = "http://localhost:5087/store/updatename";
        var client = new HttpClient();

        var data = new 
        {
            Name = name,
            NewName = new_name
        };
        var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

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
            Console.WriteLine("Вы не авторизованы!");
            return;        
        }

        Console.Write("Введите имя продукта: ");
        string name = Console.ReadLine();
        Console.Write("Введите новую цену продукта: ");
        double new_price = Convert.ToDouble(Console.ReadLine());
        var url = "http://localhost:5087/store/updateprice";
        var client = new HttpClient();

        var data = new 
        {
            Name = name,
            Price = new_price,
            Stock = 0
        };
        var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

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


    static void Main(string[] args)
    { 
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
                {
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1.Авторизация\n2.Добавление продукта\n3.Вывод списка\n4.Выход\n5.Обновление цены\n6.Обновление имени");
                     

                    var choice = Console.ReadLine();

                    switch (choice)
                    { 
                        case "1":
                        {
                            Auth();
                            break;
                        }
                        case "2":
                        {
                            SendProduct();
                            break;
                        }
                        case "3":
                        {
                            DisplayProducts();
                            break;
                        }
                        case "4":
                        {
                            IsAuthorized = false;
                            break;
                        }
                        case "5":
                        {
                            UpdatePrice();
                            break;
                        }
                        case "6":
                        {
                            UpdateName();
                            break;
                        }
                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте снова.");
                            break;
                    }
                }
    }
}