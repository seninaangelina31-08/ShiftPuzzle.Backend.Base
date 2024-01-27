using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client
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
            var product = new Product { Name = "Apple", Price = 120.0, Stock = 100 };
            await SendProductAsync(product);

            var user = new User { Login = "Akshin", Password = "2032012034" };
            await AuthorizeAsync(user);
        }   

        public static async Task SendProductAsync(Product product)
        {
            var client = new HttpClient();
            var content = new StringContent(JsonSerializer.Serialize(product), Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:5087/store/add", content);
        }

        public static async Task AuthorizeAsync(User user)
        {
            var client = new HttpClient();
            var content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:5087/authorize", content);
        }
    }
}