namespace PracticeAtask1;
using System;
using System.Net;
using System.IO;
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
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice/RUB.json";
        string jsonFromCoindesk = GetRequest(coindeskURL);

        JsonDocument doc = JsonDocument.Parse(jsonFromCoindesk);
        JsonElement bpi = doc.RootElement.GetProperty("bpi");
        JsonElement rub = bpi.GetProperty("RUB");
        float rateFloat = rub.GetProperty("rate_float").GetSingle();

        Console.WriteLine("Стоимость биткоина: " + rateFloat );
    }
}
