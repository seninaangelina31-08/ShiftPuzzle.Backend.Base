using System;
//using System.Collections.Generatic;
using System.Text.Json;
using System.IO;
namespace PracticeAB;

[System.Serializable]class User
{
public string name { get; set; } 
public int id { get; set; }
public string email { get; set; }


public User() {}
public User(string name, int id, string email, List<string> inf)
{
    this.id = id;
    this.name = name;
    this.email = email;

    
}
}







class Program
{
    static void Main(string[] args)
    {
    const string path = "1.json";

    string infa = File.ReadAllText(path);
    User pirat = JsonSerializer.Deserialize<User>(infa);
    if (pirat != null)
        {
        Console.WriteLine($"User name:{pirat.name} ID: {pirat.id} Email: {pirat.email}");

        }
    else
        {
        Console.WriteLine("Файл пустой");
    
        }
    }
}
