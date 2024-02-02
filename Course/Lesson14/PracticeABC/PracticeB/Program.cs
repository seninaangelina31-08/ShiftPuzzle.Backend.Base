using System;
using System.Net;
using System.Text.Json;
using System.Collections.Generic;

namespace PracticeB
{
    class Program
    {
        static void Main()
        {
            WebClient client = new WebClient();

            // Получаем случайные данные о человеке
            string randomUserResponse = client.DownloadString("https://randomuser.me/api/");
            RandomUserResponse randomUserData = JsonSerializer.Deserialize<RandomUserResponse>(randomUserResponse);

            // Получаем данные о поле по полученному имени
            string genderizeResponse = client.DownloadString($"https://api.genderize.io/?name={randomUserData.results[0].name["first"]}");
            GenderizeResponse genderizeData = JsonSerializer.Deserialize<GenderizeResponse>(genderizeResponse);

            Console.WriteLine($"Полученное имя: {randomUserData.results[0].name["first"]}");

            // Проверяем совпадение пола
            bool matchGender = genderizeData.gender == randomUserData.results[0].gender;

            Console.WriteLine($"Пол из АПИ: {randomUserData.results[0].gender}; Определитель пола: {genderizeData.gender}");
            Console.WriteLine(matchGender ? "Да" : "Нет");
        }
    }

    class GenderizeResponse
    {
        public string name { get; set; }
        public string gender { get; set; }
    }

    class RandomUserResponse
    {
        public RandomUser[] results { get; set; }
    }

    class RandomUser
    {
        public string gender { get; set; }
        public Dictionary<string,string> name { get; set; }
    }
}
