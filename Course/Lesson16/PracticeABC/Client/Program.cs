using System.Text;
using System.Text.Json;

namespace Client;

class Program
{
    
    static void Main(string[] args)
    { 
        var urlCreateNewUser = "http://localhost:5087/store/CreateNewUser";
        var urlAuth = "http://localhost:5087/store/Auth";
        StoreUser storeUser = new("Akshin", "MLtheBest");
        var product = new
        {
            name = "ВР-шлем",
            price = 45000,
            stock = 50
        };

        var client = new HttpClient();
        var jsonCreateNewUser = JsonSerializer.Serialize(storeUser);
        var jsonAuth = JsonSerializer.Serialize(storeUser);
        var contentCreateNewUser = new StringContent(jsonCreateNewUser, Encoding.UTF8, "application/json");
        var contentAuth = new StringContent(jsonAuth, Encoding.UTF8, "application/json");
        
        var responce = client.PostAsync(urlCreateNewUser, contentCreateNewUser).Result;
        if (responce.IsSuccessStatusCode)
        {
            var responceContent = responce.Content.ReadAsStreamAsync().Result;
            Console.WriteLine(responceContent);
        }
        else
        {
            Console.WriteLine($"Error: {responce.StatusCode}");
        }

        responce = client.PostAsync(urlAuth, contentAuth).Result;
        if (responce.IsSuccessStatusCode)
        {
            var responceContent = responce.Content.ReadAsStreamAsync().Result;
            Console.WriteLine(responceContent);
        }
        else
        {
            Console.WriteLine($"Error: {responce.StatusCode}");
        }
        
    }
}

