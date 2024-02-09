namespace Homework;
//Обязательная часть:
//1. Используя https://api.publicapis.org/entries, получи список бесплатных api
//2. Десериализуй данные в приложении C#
//3. Запишите в файл “FREE_API.txt” все URL ссылки на Github API
// Продвинутая часть:
//1. Запиши в файл в формате:
//ССЫЛКА: http://api.coinddesk.com
//ОПИСАНИЕ: текст_описания
//АВТОРИЗАЦИЯ: не нужна (т.к. некоторые сервисы могут требовать авторизацию)
using System;
using System.Net;
using System.Text.Json;
using System.Collections.Generic;


class Program
{
    public class ApiResponse
    {
        public List<Apiapshk> Entries { get; set; }
    }

    public class Apiapshk
    {
        public string API { get; set; }
        public string Description { get; set; }
        public string Auth { get; set; }
        public string HTTPS { get; set; }
        public string Cors { get; set; }
        public string Link { get; set; }
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
        
        string path1 = "https://api.publicapis.org/entries";
        string response = GetRequest(path1);
        ApiResponse apilst = JsonSerializer.Deserialize<ApiResponse>(response);
      

        var gitapurl = new List<string>();
        foreach (var apshk in apilst.Entries)
        {
            if (apshk.Auth == "" && apshk.Link.Contains("github.com"))
            {
                string vstavka = $"ССЫЛКА: {apshk.Link}\n ОПИСАНИЕ: {apshk.Description}\n АВТОРИЗАЦИЯ: не нужна (т.к. некоторые сервисы могут требовать авторизацию)";
                gitapurl.Add(vstavka);
            }
        }
        File.WriteAllLines("FREE_API.txt", gitapurl);   
    }
}