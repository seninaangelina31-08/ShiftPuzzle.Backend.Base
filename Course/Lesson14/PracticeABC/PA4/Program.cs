namespace Example;
using System.Net;
using System.IO;
using System;
using System.Text.Json;
class Program
{
    class Univers
    {
        public string alpha_two_code {get; set;}
        public List<string> domains {get; set;}
        public string country {get; set;}
        public string name {get; set;}
        public string state_province {get; set;}
        public List<string> web_pages {get; set;}
    }

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
        string URL = "http://universities.hipolabs.com/search?country=Kazakhstan"; 
        string json = GetRequest(URL); 
        Univers response = JsonSerializer.Deserialize<Univers>(json);
        
        string joke = response.name;
        string jsonS = JsonSerializer.Serialize(joke);
        Console.WriteLine(jsonS);

        //Невозможно получить запрос из-за state-province
    }
}
