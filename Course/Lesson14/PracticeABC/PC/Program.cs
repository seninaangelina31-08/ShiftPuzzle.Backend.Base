namespace Example;
using System.Net;
using System.IO;
using System;
using System.Text.Json;
class Program
{
    class Place
    {
        public string latitude {get; set;}
        public string longitude {get; set;}
    }
    class Pochta
    {
        public List<Place> places {get; set;}
    }
    class IP
    {
        public string ip {get; set;}
    }
    class Geo
    {
        public string country {get; set;}
        public string postal {get; set;}
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
        IP my_ip = JsonSerializer.Deserialize<IP>(GetRequest("https://api.ipify.org/?format=json"));
        Geo Post = JsonSerializer.Deserialize<Geo>(GetRequest($"https://ipinfo.io/{my_ip.ip}/geo"));
        Pochta pocht = JsonSerializer.Deserialize<Pochta>(GetRequest($"https://api.zippopotam.us/{Post.country}/{Post.postal}"));

        Console.WriteLine($"Широта: {pocht.places[0].latitude}  и долгота: {pocht.places[0].longitude} ближайшего почтового отделения");
    }
}
