using System.Text;
using System.Text.Json;

namespace Client;
 
class Program
{
    
    static void Main(string[] args)
    { 
        User user_1 = new User("Vasya", "123");
        CreateDBUser(user_1);
        Logining(user_1);
    }
    public class User
    {
    public string Login { get; set; }
    public string Password { get; set; }
    public bool IsAuthorized { get; set; }
    public User(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
            this.IsAuthorized = false;
        }
    }  
    static void CreateDBUser(User user)
    {
        string url = "http://localhost:5087/store/add_user";
        var user_to_send = new 
        {
            login = user.Login,
            Password = user.Password,
            IsAuthorized = false
        };
        var client = new HttpClient();
        var json = JsonSerializer.Serialize(user_to_send);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = client.PostAsync(url, content).Result;
        if (response.IsSuccessStatusCode)
        {
            var responseContent = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseContent);
        }
        else{
            Console.WriteLine($"Error: {response.StatusCode}");
        }

    }
    static void Logining(User user)
    {
        string url = "http://localhost:5087/store/login";
        var user_to_send = new 
        {
            Login = user.Login,
            Password = user.Password
        };
        var client = new HttpClient();
        var json = JsonSerializer.Serialize(user_to_send);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = client.PostAsync(url, content).Result;
        if (response.IsSuccessStatusCode)
        {
            var responseContent = response.Content.ReadAsStringAsync().Result;
            user.IsAuthorized = true;
            Console.WriteLine(responseContent);
        }
        else{
            Console.WriteLine($"Error: {response.StatusCode}; {response.Content.ReadAsStringAsync().Result}");
        }
    }
}