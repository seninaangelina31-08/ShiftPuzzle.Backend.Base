namespace PrA;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

class Program
{  
    public static string GetRequest(string url) 
    {
        WebRequest request = WebRequest.Create(url); 
        WebResponse response = request.GetResponse(); 
        Stream dataStream = response.GetResponseStream(); 
        StreamReader streamReader = new StreamReader(dataStream); 
        string jsonResponse = streamReader.ReadToEnd(); 

        streamReader.Close(); 
        response.Close();  
        return jsonResponse; 
    }
    static string GetRandomJoke()
    {
        using (var webClient = new WebClient())
        {
            try
            {
                // Загрузка шутки из API
                string apiUrl = "https://official-joke-api.appspot.com/random_joke";
                string jokeJson = webClient.DownloadString(apiUrl);

                // Десериализация JSON-строки в объект
                var jokeObject = JsonSerializer.Deserialize<JokeObject>(jokeJson);

                // Возвращение шутки
                return jokeObject.setup + "\n" + jokeObject.punchline;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке шутки: {ex.Message}");
                return null;
            }
        }
    }

    static void WriteJokeToFile(string fileName, string joke)
    {
        try
        {
            // Открытие файла для записи
            using (StreamWriter writer = File.AppendText(fileName))
            {
                // Запись шутки в файл
                writer.WriteLine(joke);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при записи в файл: {ex.Message}");
        }
    }


    static void Main(string[] args)
    { 
        //1
        // string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json"; 
        // string jsonFromCoindesk = GetRequest(coindeskURL); 
        
        // CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk); 
        
        // double bitcoinPrice = response.bpi.USD.rate_float; 
        // Console.Write("Bitcoin price : " +  bitcoinPrice * 89); 

        //2
        // ConsoleKeyInfo key;
        // do
        // {
        //     key = Console.ReadKey();
        //     if (key.Key == ConsoleKey.R) 
        //     {
        //         string factofcatsURL = "https://catfact.ninja/fact";
        //         string jsonfromCatFact = GetRequest(factofcatsURL);

        //         Factcats responseOfCat = JsonSerializer.Deserialize<Factcats>(jsonfromCatFact);

        //         string randomFact = responseOfCat.fact;
        //         Console.WriteLine($"\n{randomFact}");
        //     }
        // }
        // while (key.Key != ConsoleKey.Escape);

        //3
        // string joke = GetRandomJoke();
        // string fileName = "jokes.txt";
        // WriteJokeToFile(fileName, joke);
        // Console.WriteLine("Шутка добавлена в файл!");

        //4
        string country = "Kazakhstan";
        string apiUrl = $"http://universities.hipolabs.com/search?country={country}";

        using (var client = new WebClient())
        {
            try
            {
                string json = client.DownloadString(apiUrl);
                var universities = JsonSerializer.Deserialize<University[]>(json);

                Array.Sort(universities, (u1, u2) => u2.rating.CompareTo(u1.rating));

                Console.WriteLine($"ТОП3 университетов в {country}:");
                for (int i = 0; i < 3 && i < universities.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {universities[i].name} - {universities[i].domain}");
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Ошибка");
            }
        }
    }
}
