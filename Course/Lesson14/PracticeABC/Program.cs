//*ПратикаА:*

//1. Выведи в консоль стоимость биткоина в рублях по фиксированому курсу (api: https://api.coindesk.com/v1/bpi/currentprice.json)
//2. Cоздай программу которая по нажатию на клавишу "R" выводит рандоиный факт о кошке ( api: https://catfact.ninja/fact)
//3. Напиши прогрумму которая будте добавлятьв  файл рандомные шутки (api: https://official-joke-api.appspot.com/random_joke)
//4. Напиши программу которая получит ТОП3 универститетов каждой страны  (api: http://universities.hipolabs.com/search?)


namespace Example;
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
    static void Main(string[] args)
    { 
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла

        string url2 = "https://catfact.ninja/fact"; // наша ссылка для  битка
        string deskk = GetRequest(url2);  // поулчение ответа в виде json файла
        
        string url3 = "https://official-joke-api.appspot.com/random_joke"; // наша ссылка для  битка
        string desk3 = GetRequest(url3);  

        
        string url4 = "http://universities.hipolabs.com/search?"; // наша ссылка для  битка
        string desk4 = GetRequest(url4);

        CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk); // десериализация
        Cats resp2 = JsonSerializer.Deserialize<Cats>(deskk);
        Clc resp3 = JsonSerializer.Deserialize<Clc>(desk3);
        List<University> universities = JsonSerializer.Deserialize<List<University>>(desk4);
    
        Dictionary<string, List<University>> top3UniversitiesByCountry = new Dictionary<string, List<University>>();

        foreach (var uni in universities)
        {
            if (!top3UniversitiesByCountry.ContainsKey(uni.country))
            {
                top3UniversitiesByCountry[uni.country] = new List<University>();
            }
            if (top3UniversitiesByCountry[uni.country].Count < 3)
            {
                top3UniversitiesByCountry[uni.country].Add(uni);
            }
        }

        foreach (var country in top3UniversitiesByCountry)
        {
            Console.WriteLine($"Top 3 universities in {country.Key}:");
            foreach (var uni in country.Value)
            {
                Console.WriteLine($"- {uni.name}");
            }
            Console.WriteLine();
        }

        double bitcoinPrice = response.bpi.USD.rate_float; // получение нужной инфы
        Console.Write("Bitcoin price : " +  bitcoinPrice); // вывод
        
        Console.WriteLine("Нажмите клавишу 'R' для вывода случайного факта.");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.R)
            {
              
                
                Console.WriteLine($"\nСлучайный факт: {resp2.fact} ");
            
                break;
            }
        }
        // Сериализация в JSON
        string js3 = JsonSerializer.Serialize(resp3);
        Console.WriteLine(js3); // вывод сериализованного объекта в консоль

        const string path3 = "zadanie3.json";
        File.WriteAllText(path3, js3); // запись объекта в JSON файл
    }
}