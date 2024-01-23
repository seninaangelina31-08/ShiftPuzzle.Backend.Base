namespace PracticeB;

using System;
using System.Net;
using System.Text.Json;

class Program
{
    static void Main()
    {
        WebClient client = new WebClient();

        // Получаем данные о поле по имени "vadim"
        string genderizeResponse = client.DownloadString("https://api.genderize.io/?name=vadim");
        GenderizeResult genderizeData = JsonSerializer.Deserialize<GenderizeResult>(genderizeResponse);

        // Получаем случайные данные о человеке
        string randomUserResponse = client.DownloadString("https://randomuser.me/api/");
        RandomUserResult randomUserData = JsonSerializer.Deserialize<RandomUserResult>(randomUserResponse);

        // Проверяем совпадение пола
        bool genderMatch = genderizeData.gender == randomUserData.results[0].gender;
        Console.WriteLine(genderMatch ? "Да" : "Нет");
    }
}

class GenderizeResult
{
    public string name { get; set; }
    public string gender { get; set; }
}

class RandomUserResult
{
    public RandomUser[] results { get; set; }
    public Info info { get; set; }
}

class RandomUser
{
    public string gender { get; set; }
}

class Info
{

}

