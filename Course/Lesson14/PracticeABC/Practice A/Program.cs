namespace Practice_A;

using System.Net;
using System.IO;
using System;
using System.Text.Json;
using static System.ConsoleKeyInfo;


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
        // #1
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла
        CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk); 
        double bitcoinPrice = response.bpi.USD.rate_float;
        Console.Write("Bitcoin price : " +  bitcoinPrice); // вывод

        // #2
        string cat_factURL = "https://catfact.ninja/fact"; // ссылка на факт о кошке
        string jsonCatFact = GetRequest(cat_factURL);
        RandomCatFact response1 = JsonSerializer.Deserialize<RandomCatFact>(jsonCatFact);
        string cat_fact = response1.fact;
        while (true)
        {
            Console.WriteLine("\nPress R to print interestinf fact");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.R)
            {

                Console.WriteLine("\nInteresting fact: " + cat_fact);
                break;
            }
            
            else
            {
                Console.WriteLine("\nUncorrect input!");
            }
        }
        // #3
        string funny_jokeURL = "https://official-joke-api.appspot.com/random_joke"; // ссылка на оооооооочень смешную шутку
        string jsonFunnyJoke = GetRequest(funny_jokeURL);
        FunnyJoke responce2 = JsonSerializer.Deserialize<FunnyJoke>(jsonFunnyJoke);
        Console.WriteLine($"\nSetup: {responce2.setup} /nPunchline: {responce2.punchline}");
        AddJokeToFile(responce2, "funny_joke.txt");

         static void AddJokeToFile( FunnyJoke jsonFunnyJoke, string filePath)
        {
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Setup: {jsonFunnyJoke.setup}");
                    writer.WriteLine($"Punchline: {jsonFunnyJoke.punchline}");
                }
            }
        }    
        // #4
        string universityURL = "http://universities.hipolabs.com/search?country=Kazakhstan";
        string jsonUniversity = GetRequest(universityURL);
        List<World_University> response3 = JsonSerializer.Deserialize<List<World_University>>(jsonUniversity);
        response3 = response3?.GetRange(0, Math.Min(3, response3.Count));
        List<string> NameCountries = new List<string> { "Kazakhstan", "United States", "United Kingdom" };

            if (response3 != null)
            {
                foreach (var i in response3)
                {
                    Console.WriteLine($"University: {i.name}");
                }
            }
            else
            {
                Console.WriteLine("These Universities are not found!");
            }





    }

}