namespace PracticeABC;
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
        // #1
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла

        BPIAPIJSON response_1 = JsonSerializer.Deserialize<BPIAPIJSON>(jsonFromCoindesk); // десериализация
        
        double bitcoinPrice = response_1.bpi.USD.rate_float * 88.28; // получение нужной инфы
        Console.WriteLine("Bitcoin price : " +  bitcoinPrice + "₽."); // вывод

        // #2
        string catURL = "https://catfact.ninja/fact";
        string jsonFromCat = GetRequest(catURL);

        CatfactAPIJSON response_2 = JsonSerializer.Deserialize<CatfactAPIJSON>(jsonFromCat);
        
        Console.WriteLine("Fact about cats: " + response_2.fact);

        // #3
        const string path = "3.json";
        string jsonFromFile = File.ReadAllText(path);
        JAPIJSON joke = new JAPIJSON();
        if (jsonFromFile != null) joke = JsonSerializer.Deserialize<JAPIJSON>(jsonFromFile);

        string jokeURL = "https://official-joke-api.appspot.com/random_joke";
        string jsonFromJoke = GetRequest(jokeURL);

        JokeAPIJSON response_3 = JsonSerializer.Deserialize<JokeAPIJSON>(jsonFromJoke);

        joke.joke.Add(response_3);
        
        string json = JsonSerializer.Serialize(joke);
        File.WriteAllText(path, json);

        // #4
        Console.Write("Введите название страны(На английском): ");
        string country = Console.ReadLine();
        string universitiesURL = "http://universities.hipolabs.com/search?country=" + country;
        string jsonFromUniversities = GetRequest(universitiesURL);
        if (jsonFromUniversities.Length > 2)
        {
            List<UniversitiesAPIJSON> response_4 = JsonSerializer.Deserialize<List<UniversitiesAPIJSON>>(jsonFromUniversities);
            Console.WriteLine("ТОП-3 университета" + country);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + " место - " + response_4[i].name);
            }
        }
        else
        {
            Console.WriteLine("Данной страны либо не существует, либо нет в базе данных.");
        }
    }
}

[System.Serializable] public class Currency
{
    public string code { get; set; }
    public string symbol { get; set; }
    public string rate { get; set; }
    public string description { get; set; }
    public double rate_float { get; set; }
    public Currency() {}
    public Currency(string code_copy, string symbol_copy, string rate_copy, string description_copy, double rate_float_copy)
    {
        this.code = code_copy;
        this.symbol = symbol_copy;
        this.rate = rate_copy;
        this.description = description_copy;
        this.rate_float = rate_float_copy;
    }
}

[System.Serializable] public class Default_Currency
{
    public Currency USD { get; set; }
    public Currency GBP { get; set; }
    public Currency EUR { get; set; }
    public Default_Currency() {}
    public Default_Currency(Currency USD_copy, Currency GBP_copy, Currency EUR_copy)
    {
        this.USD = USD_copy;
        this.GBP = GBP_copy;
        this.EUR = EUR_copy;
    }

}

[System.Serializable] public class Time_BPI
{
    public string updated { get; set; }
    public string updatedISO { get; set; }
    public string updateduk { get; set; }
    public Time_BPI() {}
    public Time_BPI(string updated_copy, string updatedISO_copy, string updateduk_copy)
    {
        this.updated = updated_copy;
        this.updatedISO = updatedISO_copy;
        this.updateduk = updateduk_copy;
    }
}

[System.Serializable] public class BPIAPIJSON
{
    public Time_BPI time { get; set; }
    public string disclaimer { get; set; }
    public string chartName { get; set; }
    public Default_Currency bpi { get; set; }
    public BPIAPIJSON() {}
    public BPIAPIJSON(Time_BPI time_copy, string disclaimer_copy, string chartName_copy, Default_Currency bpi_copy)
    {
        this.time = time_copy;
        this.disclaimer = disclaimer_copy;
        this.chartName = chartName_copy;
        this.bpi = bpi_copy;
    }
}

[System.Serializable] public class CatfactAPIJSON
{
    public string fact { get; set; }
    public int length { get; set; }
    public CatfactAPIJSON() {}
    public CatfactAPIJSON(string fact_copy, int length_copy)
    {
        this.fact = fact_copy;
        this.length = length_copy;
    }
}

[System.Serializable] public class JokeAPIJSON
{
    public string type { get; set; }
    public string setup { get; set; }
    public string punchline { get; set; }
    public int id { get; set; }
    public JokeAPIJSON() {}
    public JokeAPIJSON(string type_copy, string setup_copy, string punchline_copy, int id_copy)
    {
        this.type = type_copy;
        this.setup = setup_copy;
        this.punchline = punchline_copy;
        this.id = id_copy;
    }
}

[System.Serializable] public class JAPIJSON
{
    public List<JokeAPIJSON> joke { get; set; }
    public JAPIJSON() {}
    public JAPIJSON(List<JokeAPIJSON> joke_copy)
    {
        this.joke = joke_copy;
    }
}

[System.Serializable] public class UniversitiesAPIJSON
{
    public string name { get; set; }
    public string alpha_two_code { get; set; }
    public string country { get; set; }
    public bool nastate_provinceme { get; set; }
    public List<string> domains { get; set; }
    public List<string> web_pages { get; set; }
    public UniversitiesAPIJSON() {}
    public UniversitiesAPIJSON(string name_copy, string alpha_two_code_copy, string country_copy, bool nastate_provinceme_copy, List<string> domains_copy, List<string> web_pages_copy)
    {
        this.name = name_copy;
        this.alpha_two_code = alpha_two_code_copy;
        this.country = country_copy;
        this.nastate_provinceme = nastate_provinceme_copy;
        this.domains = domains_copy;
        this.web_pages = web_pages_copy;
    }
}