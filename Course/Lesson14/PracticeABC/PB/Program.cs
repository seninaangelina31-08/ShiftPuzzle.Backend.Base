namespace Example;
using System.Net;
using System.IO;
using System;
using System.Text.Json;
class Program
{
    class Genderize
    {
        public string gender {get; set;}
    }
    class Result
    {
        public string gender {get; set;}
    }
    class Random_user
    {
        public List<Result> results {get; set;}
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
    static void Main(string[] args)
    {
        string json = GetRequest("https://randomuser.me/api/"); 
        string json2 = GetRequest("https://api.genderize.io/?name=vadim");
        
        Random_user user = JsonSerializer.Deserialize<Random_user>(json);
        Genderize g = JsonSerializer.Deserialize<Genderize>(json2);
        
        string rez = user.results[0].gender;
        if (rez == g.gender) Console.WriteLine("Да");
        else Console.WriteLine("Нет");
    }
}
