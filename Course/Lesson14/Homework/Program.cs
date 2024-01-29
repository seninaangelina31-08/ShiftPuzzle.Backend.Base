namespace Homework;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string getAPIURL = "https://api.publicapis.org/entries";
        string jsonFromAPI = GetRequest(getAPIURL);
        API APIS = JsonSerializer.Deserialize<API>(jsonFromAPI);

        string toFiel = "";

        foreach(Entry entrie in APIS.entries)
        {
            toFiel += entrie.Link + "\n";
        }
        File.AppendAllText("FreeAPI.txt", toFiel);
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
}

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Entry
    {
        public string API { get; set; }
        public string Description { get; set; }
        public string Auth { get; set; }
        public bool HTTPS { get; set; }
        public string Cors { get; set; }
        public string Link { get; set; }
        public string Category { get; set; }
    }

    public class API
    {
        public int count { get; set; }
        public List<Entry> entries { get; set; }
    }