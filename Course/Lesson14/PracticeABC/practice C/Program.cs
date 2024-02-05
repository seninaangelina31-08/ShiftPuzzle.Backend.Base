namespace practice_C;

using System;
using System.Net;
using System.IO;
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
        string myIP_URL = "https://api.ipify.org?format=json";
        string jsonfrommyIP = GetRequest(myIP_URL);
        MyApi ip_responce = JsonSerializer.Deserialize<MyApi>(jsonfrommyIP);
        string my_ip = ip_responce.ip;

        string mySredaObitania_URL = $"https://ipinfo.io/{my_ip}/geo";
        string jsonfrommyMSO = GetRequest(mySredaObitania_URL);
        MySredaObitania MSO_responce = JsonSerializer.Deserialize<MySredaObitania>(jsonfrommyMSO);
        string postal1 = MSO_responce.postal;
        string country1 = MSO_responce.country;

        string MyData_URL = $"https://api.zippopotam.us/{country1}/{postal1}";
        string jsonfromMyData = GetRequest(MyData_URL);
        MyData MyData_responce = JsonSerializer.Deserialize<MyData>(jsonfromMyData);
        var longitude1 = MyData_responce.places;
        //string latitude1 = MyData_responce;
        foreach (var i in longitude1 )
        {
         Console.WriteLine($"Долгота: {i.longitude} \nШирота:{i.latitude}");   
        }
        
        Console.WriteLine(MyData_URL);

        
    }
}
