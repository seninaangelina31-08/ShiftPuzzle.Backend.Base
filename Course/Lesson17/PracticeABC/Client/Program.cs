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
        if (!IsAuthorized)
        {
            Console.WriteLine("Вы не авторизованы");
            return;
        }

        var url = "http://localhost:5087/store/show";
        var client = new HttpClient();
        var response = client.GetAsync(url).Result;
        List<Product> products = new();

        if (response.IsSuccessStatusCode)
        {
            products = JsonSerializer.Deserialize<List<Product>>(response.Content.ReadAsStringAsync().Result);
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
        }



        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("| Название продукта | Цена продукта | Количество на складе |");
        foreach (Product product in products)
        {
            Console.WriteLine($"| {product.name,-17} | {product.price,-13} | {product.stock,-20} |");
        }


        Console.WriteLine("------------------------------------------------------------");
    }


    public static void SendProduct()
    {
        if (!IsAuthorized)
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

    public static void UpdatePrice()
    {
        if (!IsAuthorized)
        {
            Console.WriteLine("Вы не авторизованы");
            return;
        }

        var url = "http://localhost:5087/store/updateprice";

        Console.WriteLine("Введите название продукта:");
        var name = Console.ReadLine();
        Console.WriteLine("Введите новую цену продукта:");
        var newPrice = int.Parse(Console.ReadLine());

        var client = new HttpClient();

        var product = new
        {
            Name = name,
            Price = newPrice
        };


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
        if (!IsAuthorized)
        {
            Console.WriteLine("Вы не авторизованы");
            return;
        }
        
        var url = "http://localhost:5087/store/updatename";

        Console.WriteLine("Введите текущее название продукта:");
        var currentName = Console.ReadLine();
        Console.WriteLine("Введите новое название продукта:");
        var newName = Console.ReadLine();

        var client = new HttpClient();

        var product = new
        {
            Name = $"{currentName} {newName}",
            Price = 1
        };


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


    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1 - Авторизация\n2 - Добавление продукта\n3 - Вывод списка продуктов\n4 - Изменение цены продукта\n5 - Изменение названия продукта\n6 - Выход");


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
                    UpdatePrice();
                    break;

                case "5":
                    break;

                case "6":
                    Console.WriteLine("GOOD BYE");
                    break;

                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
            if (choice == "6") break;
        }
    }
}