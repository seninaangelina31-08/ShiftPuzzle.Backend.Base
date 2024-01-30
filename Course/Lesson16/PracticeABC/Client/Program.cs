using System;
using System.Net.Http;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        using (var client = new HttpClient())
        {
            var content = new StringContent("your_json_here", Encoding.UTF8, "application/json");
            var response = client.PostAsync("http://localhost:5087/store/add", content).Result;
            // Обработка ответа
        }
    }
}
