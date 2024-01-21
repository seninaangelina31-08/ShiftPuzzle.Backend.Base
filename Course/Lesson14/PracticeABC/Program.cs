using System.Net;
using System.Text.Json;

class Program
{
    class CatFact
    {
        public string Fact { get; set; }
    }

    static string GetRandomCatFact()
    {
        string url = "https://catfact.ninja/fact";
        string fact = null;

        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                string json = reader.ReadToEnd();
                CatFact catFact = JsonSerializer.Deserialize<CatFact>(json);
                fact = catFact?.Fact;
            }
        }
        return fact;
    }

    static void Main()
    {
        Console.WriteLine("Нажмите Enter для получения случайного факта о кошке. Для выхода введите 'exit'.");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                break;
            }

            string catFact = GetRandomCatFact();
            Console.WriteLine("\nСлучайный факт о кошке:\n" + catFact);
        }
    }
}
