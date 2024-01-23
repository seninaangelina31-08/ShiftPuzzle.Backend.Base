namespace PracticeA;

using System.Net;
using System.IO;
using System;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;



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
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла
        
        CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk); // десериализация
        
        
        double bitcoinPrice = response.bpi.USD.rate_float; // получение нужной инфы
        Console.Write("Bitcoin price : " +  bitcoinPrice); // вывод





        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Console.WriteLine("Нажмите клавишу 'R' для получения случайного факта о кошке:");
            while (true)
            {
                var keyInfo = Console.ReadKey(intercept: true);
                if (keyInfo.Key == ConsoleKey.R)
                {
                    Console.WriteLine();

                    string url = "https://catfact.ninja/fact";
                    HttpResponseMessage response2 = client.GetAsync(url).Result;

                    if (response2.IsSuccessStatusCode)
                    {
                        string jsonResponse = response2.Content.ReadAsStringAsync().Result;
                        var catFact = JsonSerializer.Deserialize<CatFact>(jsonResponse);
                        Console.WriteLine(catFact.Fact);
                    }
                    else
                    {
                        Console.WriteLine("Не удалось получить случайный факт о кошке.");
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }




        string universitiesURL = "http://universities.hipolabs.com/search?country=Kazakhstan";

        string universitiesJson = GetRequest(universitiesURL);
        var universities = JsonSerializer.Deserialize<List<University>>(universitiesJson);

        foreach (var country in universities.GroupBy(u => u.country))
        {
            Console.WriteLine("Топ 3 университетов в стране " + country.Key + ":");
            foreach (var university in country.Take(3))
            {
                Console.WriteLine(university.name);
            }
            Console.WriteLine();
        }
    }

    static void AddJokeToFile(string filePath, string apiUrl)
    {

        string jokeResponse = GetRequest(apiUrl);
        if (!string.IsNullOrEmpty(jokeResponse))
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(jokeResponse);
                }
            Console.WriteLine("Шутка успешно добавлена в файл.");
        }
        else
        {
            Console.WriteLine("Не удалось получить шутку.");
        }
    }
}




class CatFact
{
    public string Fact { get; set; }
}

class University
{
    public string name { get; set; }
    public string alpha_two_code { get; set; }
    public string country { get; set; }
    public List<string> web_pages { get; set; }
}