namespace PracticeA1;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

public class CoindeskResponse // основной класс для десериализации
{
    public Time time { get; set; }
    public string disclaimer { get; set; }
    public string chartName { get; set; }
    public Bpi bpi { get; set; }
}

    public class Bpi // ниже второстепенные классы, объекты которых вложенны в основной CoindeskResponse (а также друг в друга)
{
    public USD USD { get; set; }
    public GBP GBP { get; set; }
    public EUR EUR { get; set; }
}

public class EUR
{
    public string code { get; set; }
    public string symbol { get; set; }
    public string rate { get; set; }
    public string description { get; set; }
    public double rate_float { get; set; }
}

public class GBP
{
    public string code { get; set; }
    public string symbol { get; set; }
    public string rate { get; set; }
    public string description { get; set; }
    public double rate_float { get; set; }
}



public class Time
{
    public string updated { get; set; }
    public DateTime updatedISO { get; set; }
    public string updateduk { get; set; }
}

public class USD
{
    public string code { get; set; }
    public string symbol { get; set; }
    public string rate { get; set; }
    public string description { get; set; }
    public double rate_float { get; set; }
}

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
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json"; 
        string jsonFromCoindesk = GetRequest(coindeskURL); 
        
        CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk);
        
        
        double bitcoinPrice = response.bpi.USD.rate_float;
        Console.Write("Цена биткоина : " +  bitcoinPrice + "$");
    }
}
