using System.Text;
using System.Text.Json;

namespace Client;

class Program
{

    static bool IsAuthorized = false;
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
        Auth();
    }
}
