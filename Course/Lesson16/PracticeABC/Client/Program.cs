using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;

namespace Client;

class Program
{
    [System.Serializable]
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
        }
    }

    [System.Serializable]
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }

        public User(string username, string password, int id)
        {
            this.Username = username;
            this.Password = password;
            this.Id = id;
        }
    }

    static void Main(string[] args)
    {
        Auth();
        Send();
    }

    public bool IsAuthorized = false;

    public static void Auth()
    {

        User user = new User("Зубенко Михаил", "Меьйсчафачейэбцдучзеиечбвчучфехурб", 1);

        string url = "http://localhost:5087/store/auth";

        var client = new HttpClient();
        string json = JsonSerializer.Serialize(user);
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

    public static void Send()
    {

        string name = Console.ReadLine();

        double price = double.Parse(Console.ReadLine());

        int stock = int.Parse(Console.ReadLine());

        Product product = new Product(name, price, stock);

        var url = "http://localhost:5087/store/send";

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
}
