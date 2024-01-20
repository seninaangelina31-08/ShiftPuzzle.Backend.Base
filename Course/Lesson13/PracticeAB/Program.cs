using System;
using System.IO;
using System.Text.Json;

namespace PracticeAB
{
    class Program
    {
        public class User
        {
            public int id { get; set; }
            public string email { get; set; }
        }

        public class Order
        {
            public string orderId { get; set; }
            public string customerName { get; set; }
            public decimal totalPrice { get; set; }
            public string[] items { get; set; }
        }

        public class Library
        {
            public string libraryName { get; set; }
            public List<Book> books { get; set; }
        }

        public class Book
        {
            public string title { get; set; }
            public string author { get; set; }
            public int year { get; set; }
        }

        static void Main()
        {
            {

                Console.WriteLine("Ivanov Ivan");
                string userJsonData = File.ReadAllText("1.json");
                var user = JsonSerializer.Deserialize<User>(userJsonData);

                Console.WriteLine($"ID Ivanov Ivan: {user.id}");
                Console.WriteLine($"Email Ivanov Ivan: {user.email}");

                Console.WriteLine("\nAnna Petrova");
                string orderJsonData = File.ReadAllText("2.json");
                var order = JsonSerializer.Deserialize<Order>(orderJsonData);

                Console.WriteLine($"ID order's: {order.orderId}");
                Console.WriteLine($"Client's name: {order.customerName}");
                Console.WriteLine("Products:");

                foreach (var item in order.items)
                {
                    Console.WriteLine($"- {item}");
                }

                string newProduct = "Wipes for monitors";
                decimal newProductPrice = 1550m;
                order.items = order.items.Append(newProduct).ToArray();
                order.totalPrice += newProductPrice;
                decimal discountedPrice = order.totalPrice * 0.98m;

                Console.WriteLine($"Added {newProduct} for {newProductPrice:C}");
                Console.WriteLine($"Total cost with a 2% discount: {discountedPrice:C}");

                string updatedOrderJson = JsonSerializer.Serialize(order, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("updated_order.json", updatedOrderJson);

                Console.WriteLine("\nThe updated order is recorded in the updated_order.json file");

                Console.WriteLine("\nAnna Petrova");
                string jsonFilePath = "5.json";
                string jsonContent = File.ReadAllText(jsonFilePath);

                var library = JsonSerializer.Deserialize<Library>(jsonContent);

                Book newBook = new Book
                {
                    title = "Eugene Onegin",
                    author = "Alexander Pushkin",
                    year = 1833
                };
                library.books.Add(newBook);

                string updatedJsonContent = JsonSerializer.Serialize(library, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(jsonFilePath, updatedJsonContent);

                Console.WriteLine("Pushkin's book has been added to the library and recorded in a file.");
            }
        }
    }
}