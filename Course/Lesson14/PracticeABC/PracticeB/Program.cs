using System.Net;
using System.IO;
using System;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace PracticeB;

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
        string randomuserURL = "https://randomuser.me/api/"; // наша ссылка для  битка
        string genderizeURL = "https://api.genderize.io/?name=";

        string jsonFromrandomuser = GetRequest(randomuserURL);
        RandomuserResponce randomuserResponse = JsonSerializer.Deserialize<RandomuserResponce>(jsonFromrandomuser);

        genderizeURL += randomuserResponse.results[0].name.first;
        string jsonFromGenderize = GetRequest(genderizeURL);
        GenderizeResponce genderizeResponse = JsonSerializer.Deserialize<GenderizeResponce>(jsonFromGenderize);

        bool isNormalGender = randomuserResponse.results[0].gender == genderizeResponse.gender;

        if (isNormalGender)
        {
            Console.WriteLine("ДА");
        }
        else
        {
            Console.WriteLine("НЕТ");
        }
        
        
        
    }
}
