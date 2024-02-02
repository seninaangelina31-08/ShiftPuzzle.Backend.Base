using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;

namespace PracticeA
{
    class CoindeskResponse
    {
        public Time time { get; set; }
        public string disclaimer { get; set; }
        public string chartName { get; set; }
        public Bpi bpi { get; set; }
    }

    class Bpi
    {
        public USD USD { get; set; }
        public GBP GBP { get; set; }
        public EUR EUR { get; set; }
    }

    class EUR
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public double rate_float { get; set; }
    }

    class GBP
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public double rate_float { get; set; }
    }

    class Time
    {
        public string updated { get; set; }
        public DateTime updatedISO { get; set; }
        public string updateduk { get; set; }
    }

    class USD
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public double rate_float { get; set; }
    }

    class JokeResponse
    {
        public string setup { get; set; }
        public string punchline { get; set; }
    }

    class CatFact
    {
        public string fact { get; set; }
    }

    class University
    {
        public string name { get; set; }
        public string alpha_two_code { get; set; }
        public string country { get; set; }
        public List<string> web_pages { get; set; }
    }

    class Program
    {  
        public static string GetRequest(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(dataStream); // Открываем чтение потока
            string jsonResponse = streamReader.ReadToEnd(); // получаем текст

            streamReader.Close();
            response.Close();  
            return jsonResponse;
        }

        static void Main(string[] args)
        { 
            string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json";
            string jsonFromCoindesk = GetRequest(coindeskURL);
            
            CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk);
            
            double bitcoinPrice = response.bpi.USD.rate_float;
            Console.WriteLine($"Bitcoin price : {bitcoinPrice}");

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                Console.WriteLine("Нажмите клавишу 'R' для получения факта о кошке, 'Escape' для выхода:");
                while (true)
                {
                    var keyInfo = Console.ReadKey(intercept: true);
                    if (keyInfo.Key == ConsoleKey.R)
                    {
                        Console.WriteLine();

                        string catUrl = "https://catfact.ninja/fact";
                        HttpResponseMessage catResponse = client.GetAsync(catUrl).Result;

                        if (catResponse.IsSuccessStatusCode)
                        {
                            string jsonResponse = catResponse.Content.ReadAsStringAsync().Result;
                            var catFact = JsonSerializer.Deserialize<CatFact>(jsonResponse);
                            Console.WriteLine(catFact.fact);
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


            static void AddJokeToFile(string filePath, string apiUrl)
            {

                string jokeJson = GetRequest(apiUrl);
                if (!string.IsNullOrEmpty(jokeJson))
                {
                    var joke = JsonSerializer.Deserialize<JokeResponse>(jokeJson);
                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        writer.WriteLine($"{joke.setup} {joke.punchline}");
                    }
                    Console.WriteLine("Шутка добавлена в файл :)");
                }
                else
                {
                    Console.WriteLine("Шутка, увы, не добавлена :(");
                }
            }

            AddJokeToFile("jokeks.txt", "https://official-joke-api.appspot.com/random_joke");


            string universitiesURL = "http://universities.hipolabs.com/search?country=Kazakhstan";
            string universitiesJson = GetRequest(universitiesURL);
            var universities = JsonSerializer.Deserialize<List<University>>(universitiesJson);

            foreach (var country in universities.GroupBy(u => u.country))
            {
                Console.WriteLine($"Топ 3 университетов в стране {country.Key}:");
                foreach (var university in country.Take(3))
                {
                    Console.WriteLine(university.name);
                }
                Console.WriteLine();
            }
        }
    }
}
