namespace Homework;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

class Program
{
    public static string GetRequest(string url) // функция принимает адерс api
    {
        WebRequest request = WebRequest.Create(url); // создаем запрос
        WebResponse response = request.GetResponse(); // отправляем команду на получение ответа
        Stream dataStream = response.GetResponseStream(); // открываем поток для чтения (это как File.Readline только для сети)
        StreamReader streamReader = new StreamReader(dataStream); // Открываем чтение потока
        string jsonResponse = streamReader.ReadToEnd(); // получаем текст

        streamReader.Close();   // закрываем за собой чтение потока
        response.Close();  
        return jsonResponse;  // возвращаем ответ
    }
    static void Main(string[] args)
    {
        string publicapisURL = "https://api.publicapis.org/entries";
        string jsonFromPublicapis = GetRequest(publicapisURL);

        Publicapis response = JsonSerializer.Deserialize<Publicapis>(jsonFromPublicapis);

        List<Entries> Object = response.entries;
        List<string> apis = new List<string>();

        foreach (var obj in Object)
        {
            if (obj.Link.Contains("github"))
            {
                apis.Add("ССЫЛКА: " + obj.Link);
                apis.Add("ОПИСАНИЕ: " + obj.Description);
                apis.Add("");
            }
        }
        File.WriteAllLines("APIS.txt", apis);
    }
}

[System.Serializable] public class Entries
{
    public string API { get; set; }
    public string Description { get; set; }
    public string Auth { get; set; }
    public bool HTTPS { get; set; }
    public string Cors { get; set; }
    public string Link { get; set; }
    public string Category { get; set; }
    public Entries() {}
    public Entries(string API_copy, string Description_copy, string Auth_copy, bool HTTPS_copy, string Cors_copy, string Link_copy, string Category_copy)
    {
        this.API = API_copy;
        this.Description = Description_copy;
        this.Auth = Auth_copy;
        this.HTTPS = HTTPS_copy;
        this.Cors = Cors_copy;
        this.Link = Link_copy;
        this.Category = Category_copy;
    }
}

[System.Serializable] public class Publicapis
{
    public int count { get; set; }
    public List<Entries> entries { get; set; }
    public Publicapis() {}
    public Publicapis(int count_copy, List<Entries> entries_copy)
    {
        this.count = count_copy;
        this.entries = entries_copy;
    }
}
