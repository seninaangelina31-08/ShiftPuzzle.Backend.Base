namespace practiceA;
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

    static void Main(string[] args)
    { 
        // Задание 1
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json"; 
        string jsonFromCoindesk = GetRequest(coindeskURL); 
        
        CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk);
        
        double bitcoinPrice = response.bpi.USD.rate_float; 
        Console.WriteLine("Bitcoin price : " +  bitcoinPrice * 89); 

        // Задание 2
        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.R) 
            {
                string factofcatsURL = "https://catfact.ninja/fact";
                string jsonfromCatFact = GetRequest(factofcatsURL);

                Factofcats responseOfCat = JsonSerializer.Deserialize<Factofcats>(jsonfromCatFact);

                string randomFact = responseOfCat.fact;
                Console.WriteLine($"\n{randomFact}");
            }
        }
        while (key.Key != ConsoleKey.Escape);

        // Задание 3
        string randomJokeURL = "https://official-joke-api.appspot.com/random_joke";
        string jsonFromRandomJoke = GetRequest(randomJokeURL);

        RandomJoke responseOfJoke = JsonSerializer.Deserialize<RandomJoke>(jsonFromRandomJoke);
        
        string randomJokeSetup = responseOfJoke.setup;
        string randomJokePunchline = responseOfJoke.punchline;

        File.AppendAllText("randomJoke.txt", $"-{randomJokeSetup} \n-{randomJokePunchline}\n");
        Console.WriteLine("...Шутка успешно записана...");

        // Задание 4
        do
        {
            Console.Write("Введите название страны (на английском): ");
            string country = Console.ReadLine();
            string countryURL = $"http://universities.hipolabs.com/search?country={country}";
            string jsonFromCountry = GetRequest(countryURL);
            List<string> mas = new List<string>{};
            mas = ConvertJson(jsonFromCountry);
            int count = 1;

            foreach (string c in mas)
            {   
                if (count == 4)
                {
                    break;
                }
                CountryClass countr = JsonSerializer.Deserialize<CountryClass>(c);
                Console.WriteLine($"{count} - {countr.name}");
                count++;
            }
            key = Console.ReadKey();
        }
        while (key.Key != ConsoleKey.Escape);
    }

    public static List<string> ConvertJson(string jsonstring)
    {
        List<string> mas = new List<string>{};
        for (int i = 0; i < jsonstring.Length; i++)
        {
            if (jsonstring[i] == '{')
            {
                for (int j = i; j < jsonstring.Length; j++)
                {
                    if (jsonstring[j] == '}')
                    {
                        string ans = jsonstring.Substring(i, j-i + 1);
                        mas.Add(ans);
                        break;
                    }
                    
                }
            }
        }
        return mas;
    }
}
