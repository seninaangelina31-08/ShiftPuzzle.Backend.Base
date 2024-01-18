using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace PracticeAB
{

    [System.Serializable]
    public class First
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public bool isVerified { get; set; }

        public First() { }

        public First(int id, string name, string email, bool isVerified)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.isVerified = isVerified;
        }
    }

    [System.Serializable]
    public class Second
    {
        public string orderId { get; set; }
        public string customerName { get; set; }
        public int totalPrice { get; set; }
        public List<string> items { get; set; }

        public Second() { }

        public Second(string orderId, string customerName, int totalPrice, List<string> items)
        {
            this.orderId = orderId;
            this.customerName = customerName;
            this.totalPrice = totalPrice;
            this.items = items;
        }
    }

    [System.Serializable] public class Third
    {
        public string orderId { get; set; }
        public string customerName { get; set; }
        public double totalPrice { get; set; }
        public List<string> items { get; set; }

        public Third(string orderId, string customerName, double totalPrice, List<string> items)
        {
            this.orderId = orderId;
            this.customerName = customerName;
            this.totalPrice = totalPrice;
            this.items = items;
        }
    }

    [System.Serializable] public class Fifth
    {
        public string name { get; set; }
        public List<string[]> books { get; set; }

        public Fifth(){ }

        public Fifth(string name, List<string[]> books)
        {
            this.name = name;
            this.books = books;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1//
            const string path = "1.json";
            string jsonFromFile = File.ReadAllText(path);
            First person = JsonSerializer.Deserialize<First>(jsonFromFile);
            Console.WriteLine($"Email: {person.email}, Id: {person.id}");

            //2//
            const string path2 = "2.json";
            string jsonFromFile2 = File.ReadAllText(path2);
            Second customer = JsonSerializer.Deserialize<Second>(jsonFromFile2);
            Console.WriteLine($"Cost: {(customer.totalPrice)*0.9}");

            Console.WriteLine("List: ");
            foreach (var link in customer.items)
            {
                Console.WriteLine(link);
            }

            //4//
            List<string> itemsAnn = new List<string>{"Laptop", "Mouse", "Paper"};
            Third ann = new Third("ORD10245", "Ann Petrovna", (5600+1550)*0.98, itemsAnn);

            string json4 = JsonSerializer.Serialize(ann);
            Console.WriteLine(json4);

            const string path4 = "4.json";
            File.WriteAllText(path4, json4);

            //5//
            string fifth = File.ReadAllText("5.json");
            Fifth book = JsonSerializer.Deserialize<Fifth>(fifth);

            string[] a = new string[] {"War and Peace","Leo Tolstoy", "1869"};
            string[] b = new string[] {"Master and Margarate", "Mickel Bulgakov", "1967"};
            string[] c = new string[] {"Gold Chicken", "Alexander Pushkin", "1834"};
            List<string[]> book2 = new List<string[]>{a, b, c};
            book.books.Add(c);

            string jsonString = JsonSerializer.Serialize(book, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("5.json", jsonString);


            //Fifth lib = new Fifth("City library", book2);

            //string json5 = JsonSerializer.Serialize(lib);

            //File.WriteAllText(path5, json5);
        }
    }
}