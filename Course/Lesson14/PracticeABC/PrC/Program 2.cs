namespace PrC;
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
        string coindeskURL = $"https://api.ipify.org/?format=json"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла

        IP ip_obj = JsonSerializer.Deserialize<IP>(jsonFromCoindesk);

        Console.Write(ip_obj.ip);

        string coindeskURL2 = $"https://ipinfo.io/{ip_obj.ip}/geo";
        string jsonFromCoindesk2 = GetRequest(coindeskURL2);

        Postal postal_obj = JsonSerializer.Deserialize<Postal>(jsonFromCoindesk);

        Console.Write(postal_obj.loc);

        string coindeskURL3 = $"https://api.zippopotam.us/rs/{postal_obj.postal}";
        string jsonFromCoindesk3 = GetRequest(coindeskURL3);

        Geo geo_obj = JsonSerializer.Deserialize<Geo>(jsonFromCoindesk);

        Console.Write($"Coordinate: {geo_obj.longitude}, {geo_obj.latitude}");
    }
    public class IP
    {
        public string ip { get; set; }
    }
    public class Postal
    {
        public string loc { get; set; }
        public string postal { get; set; }
    }
    public class Geo
    {
        public string longitude { get; set; }
        public string latitude { get; set; }
    }
}
