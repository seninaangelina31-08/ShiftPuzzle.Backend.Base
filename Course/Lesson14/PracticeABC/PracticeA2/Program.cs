using System;
using System.IO;
using System.Net;
using System.Text.Json;

namespace PracticeA2
{
    public class FactsResponse
    {
        public string fact { get; set; }
    }

    class Program
    {
        static void Main()
        {
            PrintRandomCatFact();

            while (true)
            {
                Console.WriteLine("Нажмите клавишу 'R' для получения нового случайного факта или 'Q' для выхода.");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.R)
                {
                    Console.WriteLine();
                    PrintRandomCatFact();
                }
                else if (keyInfo.Key == ConsoleKey.Q)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nНеправильный ввод. Пожалуйста, нажмите 'R' или 'Q'.");
                }
            }
        }

        private static void PrintRandomCatFact()
        {
            string coindeskURL = "https://catfact.ninja/fact";
            string jsonFromCoindesk = GetRequest(coindeskURL);

            FactsResponse response = JsonSerializer.Deserialize<FactsResponse>(jsonFromCoindesk);

            string randomCatFact = response.fact;
            Console.WriteLine("Рандомный факт о кошке: " + randomCatFact);
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
    }
}