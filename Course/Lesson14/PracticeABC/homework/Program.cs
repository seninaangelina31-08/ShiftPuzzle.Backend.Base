namespace homework;
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
    public static void WriteToFile(List<APIObj> lst)
    {
        string[] lines = new string[lst.Count * 3];
        APIObj obj;
        for (int i = 0; i < lst.Count; i++)
        {
            obj = lst[i];
            if (obj.Auth == ""){
                obj.Auth = "Не требуется";
            }
            lines[i * 3] = "ССЫЛКА: " + obj.Link;
            lines[i * 3 + 1] = "ОПИСАНИЕ: " + obj.Description;
            lines[i * 3 + 2] = "АВТОРИЗАЦИЯ: " + obj.Auth + "\n"; 
        }
        
        File.WriteAllLines("FREE_API.txt", lines);
    }
    static void Main(string[] args)
    { 
        string coindeskURL = "https://api.publicapis.org/entries"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла
        
        RootObj response = JsonSerializer.Deserialize<RootObj>(jsonFromCoindesk); // десериализация
        WriteToFile(response.entries);
    }
    public class APIObj // основной класс для десериализации
    {
        public string API { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Auth { get; set; }
    }
    public class RootObj // основной класс для десериализации
    {
        public List<APIObj> entries { get; set; }
    }
}
