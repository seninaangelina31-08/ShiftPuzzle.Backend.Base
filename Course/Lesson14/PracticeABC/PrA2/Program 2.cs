namespace PrA2;
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
        string coindeskURL = "https://catfact.ninja/fact"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла
        
        CatFact response = JsonSerializer.Deserialize<CatFact>(jsonFromCoindesk); // десериализация
        
        Console.Write(response.fact); // вывод
    }
    public class CatFact // основной класс для десериализации
    {
        public string fact { get; set; }
        public int length { get; set; }
    }
}
