namespace PracticeAB;

class Program
{
    static void Main(string[] args)
    {
        string jsonFromFile = File.ReadAllText("1.json");
        User user = JsonSerializer.Deserialize<User>(jsonFromFile);
        if (user != null)
        {
            Console.WriteLine($"Name: {user.Name}\nDescription: {user.Description}\nPrice: {user.Price}");
        }
    }
}

[System.Serializable] public class User
{
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public bool isVerified { get; set; }

    public User() { } // Пустой конструктор для десериализации

    // конструктор класса
    public User(int id, string name, string email, bool isVerified)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.isVerified = isVerified;
    }
}

