namespace PracticeA;

using System.Net;
using System.IO;
using System;
using System.Text.Json;
using System.Text.Json.Nodes;

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
        Console.WriteLine($"Bitcoin price : {bitcoinPrice * 89} RUB"); // вывод
        Console.WriteLine();

        // Practice A-2

        string catfactURL = "https://catfact.ninja/fact";
        Console.WriteLine("Если хотите узнать рандомный факт о кошке, то нажмите R");
        string isShowRandomCatFact = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine();

        while (isShowRandomCatFact == "R")
        {
            string jsonFromCatfact = GetRequest(catfactURL);
            CatfactResponce catfactResponce = JsonSerializer.Deserialize<CatfactResponce>(jsonFromCatfact); // десериализация

            Console.WriteLine($"Рандомный факт о кошке:\n{catfactResponce.fact}");
            Console.WriteLine();
            Console.WriteLine("Если хотите узнать рандомный факт о кошке, то нажмите R");
            isShowRandomCatFact = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        // Practice A-3

        string randomjokeURL = "https://official-joke-api.appspot.com/random_joke"; // наша ссылка для  битка
        string jsonFromRandomjoke = GetRequest(randomjokeURL);  // поулчение ответа в виде json файла
        
        RandomjokeResponce randomjokeResponse = JsonSerializer.Deserialize<RandomjokeResponce>(jsonFromRandomjoke); // десериализация
        
        
        File.AppendAllTextAsync("jokes.txt", $"setup: {randomjokeResponse.setup}\n");
        File.AppendAllTextAsync("jokes.txt", $"punchline: {randomjokeResponse.punchline}\n");
        File.AppendAllTextAsync("jokes.txt", $"\n");

        // Practice A-4

        string universitiesURL = "http://universities.hipolabs.com/search?country=Kazakhstan"; // наша ссылка для  битка
        string jsonFromUniversities = GetRequest(universitiesURL);  // поулчение ответа в виде json файла
        
        List<UniversitiesResponce> universitiesResponce = JsonSerializer.Deserialize<List<UniversitiesResponce>>(jsonFromUniversities); // десериализация
        
        Console.WriteLine("3 университета из Казахстана: ");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(universitiesResponce[i].name);
        }

    }
}
