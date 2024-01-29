using System.Text;
using System.Text.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace Client;

{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }

    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            var user = new User { Login = "Shadik", Password = "101120066Am" };
            await AuthorizeAsync(user);
            
            var product = new Product { Name = "Google Pixel 7A", Price = 499.0, Stock = 7000 };
            await SendProductAsync(product);
        }   

        public static async Task AuthorizeAsync(User user)
        {
            var client = new HttpClient();
            var content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:5087/authorize", content);
        
        }
        public static async Task SendProductAsync(Product product)
        {
            var client = new HttpClient();
            var content = new StringContent(JsonSerializer.Serialize(product), Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:5087/store/add", content);
        }
    }
}