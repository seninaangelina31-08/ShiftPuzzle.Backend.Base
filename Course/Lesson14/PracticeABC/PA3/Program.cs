namespace Example;
using System.Net;
using System.IO;
using System;
using System.Text.Json;
class Program
{
    class jokes
    {
        public string type {get; set;}
        public string setup {get; set;}
        public string punchline {get; set;}
        public int id {get; set;}
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
        string URL = "https://official-joke-api.appspot.com/random_joke"; 
        string json = GetRequest(URL); 
        jokes response = JsonSerializer.Deserialize<jokes>(json);
        
        string joke = response.setup + "\n" + response.punchline;
        string jsonS = JsonSerializer.Serialize(joke);

        const string path = "joke.json";
        File.WriteAllText(path, jsonS); // запись объекта в JSON файл
    }
}
