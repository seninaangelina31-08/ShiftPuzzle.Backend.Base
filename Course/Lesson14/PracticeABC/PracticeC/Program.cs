using System.Net;
using System.IO;
using System;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace PracticeC;

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
        string ipifyURL = "https://api.ipify.org?format=json"; // наша ссылка для  битка
        string jsonFromIpify = GetRequest(ipifyURL);  // поулчение ответа в виде json файла
        IpifyResponse ipifyResponse = JsonSerializer.Deserialize<IpifyResponse>(jsonFromIpify); // десериализация 
        string ipAdress = ipifyResponse.ip;

        string ipinfoURL = $"https://ipinfo.io/{ipAdress}/geo";
        string jsonFromIpinfo = GetRequest(ipinfoURL);  // поулчение ответа в виде json файла
        IpinfoResponse ipinfoResponse = JsonSerializer.Deserialize<IpinfoResponse>(jsonFromIpinfo); // десериализация 
        string country = ipinfoResponse.country;
        string postal = ipinfoResponse.postal;

        string zippopotamURL = $"https://api.zippopotam.us/{country}/{postal}"; // наша ссылка для  битка
        string jsonFromZippopotam = GetRequest(zippopotamURL);  // поулчение ответа в виде json файла
        ZippopotamResponse zippopotamResponse = JsonSerializer.Deserialize<ZippopotamResponse>(jsonFromZippopotam); // десериализация
        
        Console.WriteLine($"Широта: {zippopotamResponse.places[0].latitude}");
        Console.WriteLine($"Долгота: {zippopotamResponse.places[0].longitude}");


    }
}
