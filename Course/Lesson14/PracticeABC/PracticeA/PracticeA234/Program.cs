namespace PracticeA234;
using System.Net;
using System.IO;
using System;
using System.Text.Json;
class Program
{
    static void Main(string[] args)
    {
        // PracticeA2
        string url2 = "https://catfact.ninja/fact";
        Catfact Fact = JsonSerializer.Deserialize<Catfact>(GetRequest(url2));
        Console.WriteLine("PracticeA2");
        Console.WriteLine($"Fact №{Fact.length}");
        Console.WriteLine($"{Fact.fact}\n");

        // PracticeA3
        string url3 = "https://official-joke-api.appspot.com/random_joke";
        Joke joke = JsonSerializer.Deserialize<Joke>(GetRequest(url3));
        Console.WriteLine("PracticeA3");
        StreamWriter f = new StreamWriter("Jokes.txt", true);
        f.WriteLine($"Joke №{joke.id.ToString()}");
        f.WriteLine(joke.type);
        f.WriteLine(joke.setup);
        f.WriteLine($"{joke.punchline}\n");
        f.Close();
        Console.WriteLine("Шутка записана в файл. Смейся");

        // PracticeA4

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
}
