namespace c;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string getIpURL = "https://api.ipify.org?format=json";
        string jsonFromIP = GetRequest(getIpURL);
        IP responseIP = JsonSerializer.Deserialize<IP>(jsonFromIP);

        string getIpDataURL = $"https://ipinfo.io/{responseIP.ip}/geo";
        string jsonFromIpData = GetRequest(getIpDataURL);
        ipData responseIpData = JsonSerializer.Deserialize<ipData>(jsonFromIpData);

        string getPostCodeURL = $"https://api.zippopotam.us/{responseIpData.country}/{responseIpData.postal}";
        string jsonFromPostCode = GetRequest(getPostCodeURL);
        PostCode responsePostCode = JsonSerializer.Deserialize<PostCode>(jsonFromPostCode);

        string coordinates = $"latitude - {responsePostCode.places[0].latitude}; longitude - {responsePostCode.places[0].longitude}";
        Console.WriteLine(coordinates);
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

public class IP
    {
        public string ip { get; set; }
    }

public class ipData
    {
        public string ip { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string loc { get; set; }
        public string org { get; set; }
        public string postal { get; set; }
        public string timezone { get; set; }
        public string readme { get; set; }
    }

public class Place
    {
        public string placename { get; set; }
        public string longitude { get; set; }
        public string state { get; set; }

        public string stateabbreviation { get; set; }
        public string latitude { get; set; }
    }

    public class PostCode
    {
        public string postcode { get; set; }
        public string country { get; set; }

        public string countryabbreviation { get; set; }
        public List<Place> places { get; set; }
    }