using System.Net;
using System.Text.Json;
using System.IO;
namespace Practice_B;

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
        string randomuserURL = "https://randomuser.me/api/";
        string jsonFromRandomuser = GetRequest(randomuserURL);
        RandomuserAPI response_randomuser = JsonSerializer.Deserialize<RandomuserAPI>(jsonFromRandomuser);

        string genderizeURL = "https://api.genderize.io/?name=" + response_randomuser.results[0].name.first;
        string jsonFromGenderize = GetRequest(genderizeURL);
        GenderizeAPI response_genderize = JsonSerializer.Deserialize<GenderizeAPI>(jsonFromGenderize);

        if (response_randomuser.results[0].gender == response_genderize.gender) 
        {
            Console.WriteLine("IT IS TRUE");   
        }
        
        else 
        {
        Console.WriteLine("IT IS FALSE!");

        }

    }
}
