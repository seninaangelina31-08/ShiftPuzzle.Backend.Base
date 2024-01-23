namespace PracticeC;

using System;
using System.Net;
using System.Text.Json;

class Program
{
    public static string GetRequest(string url)
    {
        WebRequest request = WebRequest.Create(url);
        WebResponse response = request.GetResponse();
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            return reader.ReadToEnd();
        }
    }

    static void Main(string[] args)
    {
        // Получаем IP адрес
        string ipifyURL = "https://api.ipify.org?format=json";
        string jsonFromIpify = GetRequest(ipifyURL);
        IpifyResponse ipifyResponse = JsonSerializer.Deserialize<IpifyResponse>(jsonFromIpify);
        string ipAddress = ipifyResponse.ip;

        // Получаем почтовый код и обозначение страны
        string ipinfoURL = "https://ipinfo.io/" + ipAddress + "/geo";
        string jsonFromIpinfo = GetRequest(ipinfoURL);
        IpinfoResponse ipinfoResponse = JsonSerializer.Deserialize<IpinfoResponse>(jsonFromIpinfo);
        string postalCode = ipinfoResponse.postal;
        string countryAbbreviation = ipinfoResponse.country;

        // Получаем долготу и широту ближайшего почтового отделения
        string zippopotamURL = "https://api.zippopotam.us/" + countryAbbreviation.ToLower() + "/" + postalCode;
        string jsonFromZippopotam = GetRequest(zippopotamURL);
        ZippopotamResponse[] zippopotamResponse = JsonSerializer.Deserialize<ZippopotamResponse[]>(jsonFromZippopotam);

        Console.WriteLine("IP адрес: " + ipAddress);
        Console.WriteLine("Почтовый код: " + postalCode);
        Console.WriteLine("Страна: " + countryAbbreviation);
        Console.WriteLine("Долгота: " + zippopotamResponse[0].places[0].longitude);
        Console.WriteLine("Широта: " + zippopotamResponse[0].places[0].latitude);
    }
}
