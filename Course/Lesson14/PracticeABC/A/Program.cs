namespace A;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        //TASK1
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла
        CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk); // десериализация
        double bitcoinPrice = response.bpi.USD.rate_float; // получение нужной инфы
        Console.WriteLine("Bitcoin price : " +  bitcoinPrice * 88,59f); // вывод

        //TASK2
        string coindeskURL2 = "https://catfact.ninja/fact";
        string jsonFromCoindesk2 = GetRequest(coindeskURL2);  // поулчение ответа в виде json файла
        CatFact response2 = JsonSerializer.Deserialize<CatFact>(jsonFromCoindesk2); // десериализация
        string randomFact = response2.fact; // получение нужной инфы
        Console.WriteLine("Random fact about cats : " +  randomFact); // вывод

        //TASK3
        string coindeskURL3 = "https://official-joke-api.appspot.com/random_joke";
        string jsonFromCoindesk3 = GetRequest(coindeskURL3);  // поулчение ответа в виде json файла
        joke response3 = JsonSerializer.Deserialize<joke>(jsonFromCoindesk3); // десериализация
        string randomJoke = response3.setup + response3.punchline; // получение нужной инфы
        Console.WriteLine("Random joke : " +  randomJoke); // вывод

        //TASK4
        string coindeskURL4 = "http://universities.hipolabs.com/search?country=Kazakhstan";
        string jsonFromCoindesk4 = GetRequest(coindeskURL4);  // поулчение ответа в виде json файла
        University response4 = JsonSerializer.Deserialize<University>(jsonFromCoindesk4); // десериализация
        string top1Universitry = response4.name; // получение нужной инфы
        Console.WriteLine("top 1 university : " +  top1Universitry); // вывод
        //вопрос к Акшину, а как получить массив элементов json, у меня не получилось взать топ 3 университета, так как я хз как получить ВСЕ университеты идли хотя бы 1 определенный из них
        
    }
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

    public class CatFact
    {
        public string fact { get; set; }
        public int length { get; set; }
    }

    public class joke
    {
        public string type { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
        public int id { get; set; }
    }

    public class University
    {
        public string name { get; set; }
        public string alpha_two_code { get; set; }
        public string country { get; set; }
        public object stateprovince { get; set; }
        public List<string> domains { get; set; }
        public List<string> web_pages { get; set; }
    }
}
