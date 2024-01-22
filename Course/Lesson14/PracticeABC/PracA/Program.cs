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
        StreamReader reader = new StreamReader(dataStream); // Открываем чтение потока
        string responseFromServer = reader.ReadToEnd(); // получаем текст

        reader.Close();   // закрываем за собой чтение потока
        response.Close();  
        return responseFromServer;  // возвращаем ответ

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse)
    }

//1
    public class EUR
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public double rate_float { get; set; }

        //public EUR() { }

        public EUR(string code, string symbol, string rate, string description, double rate_float)
        {
            this.code = code;
            this.symbol = symbol;
            this.rate = rate;
            this.description = description;
            this.rate_float = rate_float;
        }
    }

    public class GBP
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public double rate_float { get; set; }

        //public GBP() { }

        public GBP(string code, string symbol, string rate, string description, double rate_float)
        {
            this.code = code;
            this.symbol = symbol;
            this.rate = rate;
            this.description = description;
            this.rate_float = rate_float;
        }
    }

    public class USD
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public float rate_float { get; set; }

        //public USD() { }

        public USD(string code, string symbol, string rate, string description, float rate_float)
        {
            this.code = code;
            this.symbol = symbol;
            this.rate = rate;
            this.description = description;
            this.rate_float = rate_float;
        }
    }

    public class Bpi
    {
        public USD USD { get; set; }
        public GBP GBP { get; set; }
        public EUR EUR { get; set; }

        //public Bpi() { }

        public Bpi(USD USD, GBP GBP, EUR EUR)
        {
            this.USD = USD;
            this.GBP = GBP;
            this.EUR = EUR;
        }
    }

    public class Time
    {
        public string updated { get; set; }
        public string updatedISO { get; set; }
        public string updateduk { get; set; }

        //public Time() { }

        public Time(string updated, string updatedISO, string updateduk)
        {
            this.updated = updated;
            this.updatedISO = updatedISO;
            this.updateduk = updateduk;
        }
    }

    [System.Serializable] public class CoindeskResponse
    {
        public Time time { get; set; }
        public string disclaimer { get; set; }
        public string chartName { get; set; }
        public Bpi bpi { get; set; }

        public CoindeskResponse(Time time, string disclaimer, string chartName, Bpi bpi)
        {
            this.time = time;
            this.disclaimer = disclaimer;
            this.chartName = chartName;
            this.bpi = bpi;
        }
    }


        //2
        [System.Serializable] public class Interest
    {
        public string fact { get; set; }
        public int length { get; set; }

        public Interest(string fact, int length)
        {
            this.fact = fact;
            this.length = length;
        }
    }

        //3
        [System.Serializable] public class Joke
    {
        public string type { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
        public int id { get; set; }

        public Joke(string type, string setup, string punchline, int id)
        {
            this.type = type;
            this.setup = setup;
            this.punchline = punchline;
            this.id = id;
        }
    }


        //4
        [System.Serializable] public class University 
    {
        public string name { get; set; }
        public string alpha_two_code { get; set; }
        public string state_province { get; set; }
        public List<string> domains { get; set; }
        public string country { get; set; }
        public List<string> web_pages { get; set; }

        public University(string name, string alpha_two_code, string state_province, List<string> domains, string country, List<string> web_pages)
        {
            this.name = name;
            this.alpha_two_code = alpha_two_code;
            this.state_province = state_province;
            this.domains = domains;
            this.country = country;
            this.web_pages = web_pages;
        }  
    }



    static void Main(string[] args)
    { 
        //1
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла
        
        CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk); // десериализация

        double ruble = response.bpi.USD.rate_float * 88.56;
        
        Console.Write("Bitcoin price : " +  ruble + " RUB\n");

        //2
        string catURL = "https://catfact.ninja/fact"; // наша ссылка для  битка
        string jsonFromCat = GetRequest(catURL);  // поулчение ответа в виде json файла
        
        Interest response2 = JsonSerializer.Deserialize<Interest>(jsonFromCat); // десериализация
        
        string a = Console.ReadLine();
        if (a == "r")
        {Console.Write("Interesting fact: " +  response2.fact);}

        //3
        string jokeURL = "https://official-joke-api.appspot.com/random_joke"; // наша ссылка для  битка
        string jsonFromJoke = GetRequest(jokeURL);  // поулчение ответа в виде json файла
        
        Joke response3 = JsonSerializer.Deserialize<Joke>(jsonFromJoke); // десериализация
        string json3 = JsonSerializer.Serialize(response3);
        File.WriteAllText("joke.json", json3);

        //4
        string countriesUrl = "http://universities.hipolabs.com/search?country=";
        List<string> countryNames = new List<string> { "Kazakhstan", "United States", "Russian Federation" };

        foreach (var countryName in countryNames)
        {
            Console.WriteLine($"ТОП 3 университетов в стране: {countryName}");
            List<University> top3 = GetTop3(countriesUrl + countryName);
            PrintUniversities(top3);
            Console.WriteLine(new string('-', 30));
        }
    }

    private static List<University> GetTop3(string apiUrl)
        {
            string jsonFromUniversities = GetRequest(apiUrl);
            List<University> universities = JsonSerializer.Deserialize<List<University>>(jsonFromUniversities);
            return universities?.GetRange(0, Math.Min(3, universities.Count));
        }

        private static void PrintUniversities(List<University> universities)
        {
                foreach (var university in universities)
                {
                    Console.WriteLine($"Университет: {university.name}");
                }
        }
}

