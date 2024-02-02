using System;
using System.Net;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace PracticeC
{
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

        class IpResponse
        {
            public string ip { get; set; }
        }

        class IpinfoResponse
        {
            public string postal { get; set; }
            public string country { get; set; }
        }

        class ZippopotamResponse
        {
            public List<Dictionary<string, string>> places { get; set; }
        }

        static void Main(string[] args)
        {
            // Вытаскиваем IP
            string ipURL = "https://api.ipify.org?format=json";
            string jsonFromIp = GetRequest(ipURL);
            IpResponse ipResponse = JsonSerializer.Deserialize<IpResponse>(jsonFromIp);
            string ipAddress = ipResponse.ip;

            // Вытаскиваем почтовый код и страну
            string ipinfoURL = $"https://ipinfo.io/{ipAddress}/geo";
            string jsonFromIpinfo = GetRequest(ipinfoURL);
            IpinfoResponse ipinfoResponse = JsonSerializer.Deserialize<IpinfoResponse>(jsonFromIpinfo);
            string postalCode = ipinfoResponse.postal;
            string countryAbbreviation = ipinfoResponse.country;

            // Вытаскиваем долготу и широту ближайшего почтового отделения
            string zippopotamURL = $"https://api.zippopotam.us/{countryAbbreviation.ToLower()}/{postalCode}";
            string jsonFromZippopotam = GetRequest(zippopotamURL);
            ZippopotamResponse zippopotamResponse = JsonSerializer.Deserialize<ZippopotamResponse>(jsonFromZippopotam);

            Console.WriteLine($"IP: {ipAddress}");
            Console.WriteLine($"Почтовый код: {postalCode}");
            Console.WriteLine($"Страна: {countryAbbreviation}");
            Console.WriteLine($"Долгота: {zippopotamResponse.places[0]["longitude"]}");
            Console.WriteLine($"Широта: {zippopotamResponse.places[0]["latitude"]}");
        }
    }
}
