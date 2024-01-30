using System.Net;
using System.IO;
using System;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Homework;

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
        string publicapisURL = "https://api.publicapis.org/entries"; // наша ссылка для  битка
        string jsonFromPublicapis = GetRequest(publicapisURL);  // поулчение ответа в виде json файла
        PublicapisResponce publicapisResponse = JsonSerializer.Deserialize<PublicapisResponce>(jsonFromPublicapis); // десериализация
        
        foreach (Entry entry in publicapisResponse.entries)
        {
            File.AppendAllText("FREE_API", $"ССЫЛКА: {entry.Link}\nОПИСАНИЕ: {entry.Description}\nАВТОРИЗАЦИЯ: {entry.Auth}");
        }
    }
}
