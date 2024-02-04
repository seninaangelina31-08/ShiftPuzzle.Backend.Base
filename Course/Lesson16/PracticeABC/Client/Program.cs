using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;

public class Client
{
    public string username { get; set; }
    public string password { get; set; }
    public bool IsAuthorized { get; private set; }

    public async void Authorize()
    {
        var url = "http://localhost:5027/store/authorize";
        var userdate = new
        {
            username = "IvanIvanovich",
            password = "12445"
        };
        var client = new HttpClient();
        var json = JsonSerializer.Serialize(userdate);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(url, content).Result;
        if (response.IsSuccessStatusCode)
        {
            IsAuthorized = true;
            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }
        else
        {
            IsAuthorized = false;
            Console.WriteLine($"Error: {response.StatusCode}");
        }
    }
}

