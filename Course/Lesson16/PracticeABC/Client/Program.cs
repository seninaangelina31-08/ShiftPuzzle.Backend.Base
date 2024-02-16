using System.Text;
using System.Text.Json;

namespace Client;

// Позльзователь
[System.Serializable] public class User
{
    // Логгин
    public string Login { get; set; }
    // Пароль
    public string Password { get; set; }
    // Зарегестрирован ли пользователь
    public bool IsAuthorized { get; set; }
    public User(){}
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
        this.IsAuthorized = false;
    }

    public void AddUser()
    {
        // Запрос на добавление пользователя
        string add_user_url = "http://localhost:5087/store/add_user";
        
        // Параметры пользователя, которые необходимо отправить
        var user_data = new 
        {
            Login = this.Login,
            Password = this.Password,
            IsAuthorized = false
        };

        // Выполняем запрос на сервер и получаем результат
        var client = new HttpClient();
        var json = JsonSerializer.Serialize(user_data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = client.PostAsync(add_user_url, content).Result;
    
        if (response.IsSuccessStatusCode)
        {
            // Если запрос выполнился как надо
            var responseContent = response.Content.ReadAsStringAsync().Result;
            // Выводим результат в консоль
            Console.WriteLine(responseContent);
        }
        else
        {
            // Что-то пошло не так :(
            Console.WriteLine($"Error: {response.StatusCode}");
        }

    }
    public void UserLogining(string login, string password)
    {
        // Запрос на регистрацию пользователя
        string logining_url = "http://localhost:5087/store/logining_user";
        // Параметры пользователя, которые необходимо отправить
        var user_data = new 
        {
            Login = login,
            Password = password
        };
        // Выполняем запрос на сервер и получаем результат
        var client = new HttpClient();
        var json = JsonSerializer.Serialize(user_data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = client.PostAsync(logining_url, content).Result;

        if (response.IsSuccessStatusCode)
        {
            // Если запрос выполнился как надо
            var responseContent = response.Content.ReadAsStringAsync().Result;
            // Выводим результат в консоль
            Console.WriteLine(responseContent);
        }
        else
        {
            // Что-то пошло не так :(
            Console.WriteLine($"Error: {response.StatusCode}; {response.Content.ReadAsStringAsync().Result}");
        }
    }
    
}
class Program
{
    
    static void Main(string[] args)
    { 
        // Тестим систему
        User user_1 = new User("User_1", "123456");
        User user_2 = new User("User_2", "qwerty");
        user_1.AddUser();
        user_2.AddUser();
        user_1.UserLogining("User_1", "123456");
        user_2.UserLogining("User_2", "ytrewq");
        user_2.UserLogining("User_2", "qwerty");
    }
}