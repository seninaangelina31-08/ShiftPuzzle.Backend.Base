namespace PrA4;
using System.Net;
using System.IO;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;


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
        const string country = "Russian Federation";
        string coindeskURL = $"http://universities.hipolabs.com/search?country={country}"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла

        var universities = JsonSerializer.Deserialize<University[]>(jsonFromCoindesk);

        var random = new Random();
        var top_univer = universities.OrderBy(x => random.Next()).Take(3);
        University[] top = new University[3];
        int idx = 0;

        foreach (var university in top_univer)
        {
            top[idx] = university;
            idx++;
        }


        if (country == "Russian Federation"){
            foreach (University item in top)
            {
                if (item.name == "ITMO University"){
                    top[0] = item;
                    break;
                }
            }
        }

        for (int i = 1; i < 4; i++)
        {
            University university = top[i - 1];
            Console.WriteLine($"Number {i} in {country}:\n");
            Console.WriteLine($"University Name: {university.name}");
            Console.WriteLine($"Site: {university.web_pages[0]}");
            Console.WriteLine();
        }
    }
    public class University // основной класс для десериализации
    {
        public string name { get; set; }
        public string alpha_two_code { get; set; }
        public string state_province { get; set; }
        public List<string> domains { get; set; }
        public string country { get; set; }
        public List<string> web_pages { get; set; }
    }
}
