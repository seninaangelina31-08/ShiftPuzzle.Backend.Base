namespace PracticeB;
using System.Text.Json;
using System;
using System.Net;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string randomUserURL = "https://randomuser.me/api/";
        string jsonFromUserURL = GetRequest(randomUserURL);

        User randomuser = JsonSerializer.Deserialize<User>(jsonFromUserURL);
        RealUser(randomuser);
    }

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

    public static bool RealUser(User userInfo)
    {
        string userName = userInfo.results[0].name.first;
        string userGender = userInfo.results[0].gender;
        Console.WriteLine($"Имя: {userName}");
        Console.WriteLine($"Предположительный пол: {userGender}");

        string trueGenderURL = $"https://api.genderize.io/?name={userName}";
        string jsonFromGenderURL = GetRequest(trueGenderURL);

        TrueGender genderInfo = JsonSerializer.Deserialize<TrueGender>(jsonFromGenderURL);
        Console.WriteLine("Соответствие:");
        if (genderInfo.gender == userGender)
        {
            Console.WriteLine("Да");
            return true;
        }

        else if (genderInfo.gender != userGender)
        {
            Console.WriteLine("Нет");
            return false;
        }
        return false;
    }
}
