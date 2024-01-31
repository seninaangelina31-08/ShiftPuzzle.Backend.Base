using System.Text;
using System.Text.Json;

namespace Client;
 
class Program
{

    public class User
    {
        public string name { get; set; }
        public string password { get; set; }
        public bool isAuthorized { get; set; }

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
            this.isAuthorized = false;
        }
    }

    static void CreateDBUser(User user)
    {
        string url = "http://localhost:5087/store/add_user";
        var user_send = new 
        {
            name = user.name,
            password = user.password,
            isAuthorized = false,
        };

        var client = new HttpClient();
        var json = JsonSerializer.Serialize(user_send);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        /*
        json представляет собой строку JSON, которую вы хотите отправить в теле POST-запроса.
        
        Encoding.UTF8 указывает кодировку символов (в данном случае, UTF-8), используемую для кодирования строки JSON.

        "application/json" - это тип содержимого (Content-Type), который указывает серверу, что тело запроса содержит данные в формате JSON.
        */
        var response = client.PostAsync(url, content).Result;
        /*
        client - это объект HttpClient, который используется для выполнения HTTP-запросов.

        PostAsync - это асинхронный метод, предназначенный для отправки HTTP POST-запроса.

        url - это адрес, куда будет отправлен запрос.
        
        content - это объект HttpContent, который представляет тело запроса 
        
        .Result преобразует асинхронный вызов в синхронный и возвращает результат (ответ от сервера).*/

        if (response.IsSuccessStatusCode)
        {
            var responseContent = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseContent);
        }
        else{
            Console.WriteLine($"Ошибка: {response.StatusCode}");
        }

    }
    static void Logining(User user)
    {
        string url = "http://localhost:5087/store/login";
        var user_send = new 
        {
            name = user.name,
            password = user.password,
        };

        var client = new HttpClient();
        var json = JsonSerializer.Serialize(user_send);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = client.PostAsync(url, content).Result;

        if (response.IsSuccessStatusCode)
        {
            var responseContent = response.Content.ReadAsStringAsync().Result;
            user.isAuthorized = true;
            Console.WriteLine(responseContent);
        }
        else{
            Console.WriteLine($"Ошибка: {response.StatusCode}; {response.Content.ReadAsStringAsync().Result}");
        }
    }
    
    static void Main(string[] args)
    { 
        User user1 = new User("Vasya", "123");
        CreateDBUser(user1);
        Logining(user1);
    }
    
}