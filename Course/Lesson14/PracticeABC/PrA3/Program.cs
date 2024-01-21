namespace PrA3;
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
    public static void WriteToFile(string setup, string punchline)
    {
        string[] lines = new string[2];
        lines[0] = "- " + setup;
        lines[1] = "- " + punchline;
        File.WriteAllLines("test.txt", lines);
    }
    static void Main(string[] args)
    { 
        string coindeskURL = "https://official-joke-api.appspot.com/random_joke"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла
        
        Joket response = JsonSerializer.Deserialize<Joket>(jsonFromCoindesk); // десериализация
        
        WriteToFile(response.setup, response.punchline);
    }
    public class Joket // основной класс для десериализации
    {
        public string type { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
        public int id { get; set; }
    }
}
