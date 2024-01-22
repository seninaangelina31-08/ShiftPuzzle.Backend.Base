using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace PracticeA4
{
    public class University
    {
        public string name { get; set; }
        public string country { get; set; }
    }

    class Program
    {
        static void Main()
        {
            string countriesApiUrl = "http://universities.hipolabs.com/search?country=";
            List<string> countryCodes = new List<string> { "Kazakhstan", "United States", "United Kingdom" };

            foreach (var countryCode in countryCodes)
            {
                Console.WriteLine($"ТОП 3 университетов в стране: {countryCode}");
                List<University> top3Universities = GetTop3Universities(countriesApiUrl + countryCode);
                PrintUniversities(top3Universities);
                Console.WriteLine(new string('-', 30));
            }
        }

        private static List<University> GetTop3Universities(string apiUrl)
        {
            string jsonUniversities = GetRequest(apiUrl);
            List<University> universities = JsonSerializer.Deserialize<List<University>>(jsonUniversities);
            return universities?.GetRange(0, Math.Min(3, universities.Count));
        }

        private static void PrintUniversities(List<University> universities)
        {
            if (universities != null)
            {
                foreach (var university in universities)
                {
                    Console.WriteLine($"Университет: {university.name}");
                }
            }
            else
            {
                Console.WriteLine("Не удалось получить информацию о университетах.");
            }
        }

        private static string GetRequest(string url)
        {
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(url);
                }
            }
        }
    }
}