using System.Text;
using System.Text.Json;

namespace Client;

class Program
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
    
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
    }

    static public void Add_object(string url, Product newProduct)
    {
        var client = new HttpClient();
        var json = JsonSerializer.Serialize(newProduct);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = client.PostAsync(url, content).Result;
        if (response.IsSuccessStatusCode)
        {
            var responseConect = response.Content.ReadAsStringAsync().Result;
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
        }

    }
    
    static public void Authorization(string url, User user, bool ifAuthorization = false)
    {
        if (user.Login == "Nikita" && user.Password == "I live by the KOD")
        {
            var client = new HttpClient();
            var json = JsonSerializer.Serialize(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseConect = response.Content.ReadAsStringAsync().Result;
                ifAuthorization = true;
                Console.WriteLine("Добро пожаловать.");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }
        else
        {
            Console.WriteLine("Неверно введены данные. P.S.: " + ifAuthorization);
        }
        
    }
    
    static void Main(string[] args)
    { 
        string url = "http://localhost:5087/store/add";
        string url_Authorization = "http://localhost:5087/store/authorization";
        User Nikta = new User("Nikita", "I live by the KOD");
        var newProduct = new Product("Test", 100, 0);

        Add_object(url, newProduct);
        Authorization(url_Authorization, Nikta);
    }
}
