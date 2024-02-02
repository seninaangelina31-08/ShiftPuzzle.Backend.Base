using System.ComponentModel.DataAnnotations;
using System.Text;
using System;
using System.Collections.Generic;
using System.Net.Http;

using System.Text.Json;

namespace Client;

class Program
{ 
    [System.Serializable]
    public class Product
    {
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string name { get; set; }

    [Range(0.01, 10000)]
    public double price { get; set; }

    [Range(0, 10000)]
    public int stock { get; set; }
    
        
    }
    
    static bool IsAuthorized = false;

        private static HttpClient client = new HttpClient();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Authorization");
            Console.WriteLine("2. Add a product");
            Console.WriteLine("3. Display the product list");
            Console.WriteLine("4. Exit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Auth();
                    break;
                case "2":
                    if (IsAuthorized)
                    {
                        SendProduct();
                    }
                    else
                    {
                        Console.WriteLine("You need to be authorized to perform this action.");
                    }
                    break;
                case "3":
                    DisplayProducts();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void DisplayProducts()
    {
        var response = client.GetAsync("/store/show").Result;
        if (response.IsSuccessStatusCode)
        {
            var products = response.Content.ReadAsAsync<List<Product>>().Result;
            Console.WriteLine("Product List:");
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
            }
        }
        else
        {
            Console.WriteLine("Error retrieving product list.");
        }
    }

    private static void SendProduct()
    {
        Console.WriteLine("Enter the product details:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.Write("Stock: ");
        int stock = Convert.ToInt32(Console.ReadLine());

        var product = new Product(name, price, stock);
        var response = client.PostAsJsonAsync("/store/add", product).Result;
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("Product added successfully.");
        }
        else
        {
            Console.WriteLine("Error adding the product.");
        }
    }

    private static void Auth()
    {
        Console.WriteLine("Enter your credentials:");
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        var user = new UserCredentials { User = username, Pass = password };
        var response = client.PostAsJsonAsync("/store/auth", user).Result;
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("Authorization successful.");
            IsAuthorized = true;
        }
        else
        {
            Console.WriteLine("Authorization failed.");
        }
    }
}