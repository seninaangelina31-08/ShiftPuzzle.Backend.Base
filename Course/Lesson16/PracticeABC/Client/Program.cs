using System.Text;
using System.Text.Json;

namespace Client;

class Program
{

    public static void Add_user()
    {
        var url = "http://localhost:5087/store/add_user";
        var client = new HttpClient(); 

        Console.Write("Введите имя пользователя: ");
        string name = Console.ReadLine();
        Console.Write("Введите логин пользователя: ");
        string login = Console.ReadLine();
        Console.Write("Введите пароль: ");
        string pass = Console.ReadLine();

        var userData = new{Name = name, Loggin = login, Password = pass};
        var json = JsonSerializer.Serialize(userData);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = client.PostAsync(url, content).Result;
    }

    public static void Auth()
    {
        var url = "http://localhost:5087/store/login";
        Console.Write("Введите имя пользователя: ");
        string name = Console.ReadLine();
        Console.Write("Введите логин пользователя: ");
        string login = Console.ReadLine();
        Console.Write("Введите пароль: ");
        string pass = Console.ReadLine();
        var userData = new{Name = name, Loggin = login, Password = pass};

        var client = new HttpClient(); 
        var json = JsonSerializer.Serialize(userData);
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
            Console.WriteLine("1. Авторизоваться");
            Console.WriteLine("2. Добавить пользователя");
            
            var choice = Console.ReadLine();
            switch (choice)
            { 
                case "1":
                    Auth();
                    break;
                case "2":
                    Add_user();
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}
