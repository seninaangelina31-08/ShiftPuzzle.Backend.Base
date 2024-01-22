using System;
using System.IO;
using System.Net;
using System.Text.Json;

namespace PracticeA3
{
    public class Joke
    {
        public string setup { get; set; }
        public string punchline { get; set; }
    }

    class Program
    {
        static void Main()
        {
            string jokesApiUrl = "https://official-joke-api.appspot.com/random_joke";

            Joke joke = GetRandomJoke(jokesApiUrl);

            Console.WriteLine("Случайная шутка:");
            Console.WriteLine($"{joke.setup}\n{joke.punchline}");

            AddJokeToFile(joke, "jokes.txt");

            Console.WriteLine("Шутка добавлена в файл 'jokes.txt'.");
        }

        private static Joke GetRandomJoke(string apiUrl)
        {
            string jsonJoke = GetRequest(apiUrl);
            Joke joke = JsonSerializer.Deserialize<Joke>(jsonJoke);
            return joke;
        }

        private static void AddJokeToFile(Joke joke, string filePath)
        {
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Setup: {joke.setup}");

                    writer.WriteLine($"Punchline: {joke.punchline}");

                    writer.WriteLine(new string('-', 30));
                }
            }
        }

        private static string GetRequest(string url)
        {
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
        }
    }
}