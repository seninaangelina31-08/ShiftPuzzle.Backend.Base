namespace Example;
using System.Net;
using System.IO;
using System;
using System.Text.Json;
public class CatFact
{
    public string Fact { get; set; }
    public int Length { get; set; }
    public CatFact() {}

}

public class Joke
{
    public string Type { get; set; }
    public string Setup { get; set; }
    public string Punchline { get; set; }
    public int Id { get; set; }

    public Joke() {}
}

public class University
{
    public List<string> Domains { get; set; }
    public string AlphaTwoCode { get; set; }
    public List<string> WebPages { get; set; }
    public string Name { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }

    public University() {}
}

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
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json";
        string jsonFromCoindesk = GetRequest(coindeskURL); 
        
        CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk); 
        
        double bitcoinPrice = response.bpi.USD.rate_float;
        Console.Write("Bitcoin price : " +  bitcoinPrice); 

        string JsonCat = GetRequest("https://catfact.ninja/fact");
        CatFact resp1 = JsonSerializer.Deserialize<CatFact>(JsonCat);
        Console.WriteLine(resp1.Fact);

        string JsonJoke = GetRequest("https://official-joke-api.appspot.com/random_joke");
        Joke resp2 = JsonSerializer.Deserialize<Joke>(JsonJoke);
        string ser = JsonSerializer.Serialize(resp2);
        File.WriteAllText("1.json",ser);

        string JsonUni = GetRequest("http://universities.hipolabs.com/search?country=Kazakhstan");
        List<University> resp3 = JsonSerializer.Deserialize<List<University>>(JsonUni);
        Console.WriteLine(resp3[0].Name);
        Console.WriteLine(resp3[1].Name);
        Console.WriteLine(resp3[2].Name);

    }


}