<<<<<<< HEAD
<<<<<<< HEAD
﻿
using System.ComponentModel.DataAnnotations;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
namespace Client;
class Program
    [System.Serializable]
    public class Product
    {

    public string name { get; set; }

  
    public double price { get; set; }

 
    public int stock { get; set; }

        
    }
{ 
    static bool IsAuthorized = false;
    public static void Authorize()
=======
﻿using System;
=======
﻿
using System.ComponentModel.DataAnnotations;
using System;
>>>>>>> 9a42ddb0 (feat: added answer to task 16)
using System.Net.Http;
using System.Text;
using System.Text.Json;
namespace Client;
class Program
    [System.Serializable]
    public class Product
    {

    public string name { get; set; }

<<<<<<< HEAD
    public async void Authorize()
>>>>>>> 43b20e84 (feat: added answers to tasks 15, 16)
=======
  
    public double price { get; set; }

 
    public int stock { get; set; }

        
    }
{ 
    static bool IsAuthorized = false;
    public static void Authorize()
>>>>>>> 9a42ddb0 (feat: added answer to task 16)
    {
        var url = "http://localhost:5027/store/authorize";
        var userdate = new
        {
            username = "IvanIvanovich",
            password = "12445"
        };
        var client = new HttpClient();
        var json = JsonSerializer.Serialize(userdate);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
<<<<<<< HEAD
<<<<<<< HEAD

        var response =  client.PostAsync(url, content).Result;
        if (response.IsSuccessStatusCode)
        {
            var result =  response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
            IsAuthorized = true;
            
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
            IsAuthorized = false;
            
        }
    }
    public static void SendProduct()
    {        
            if(!IsAuthorized)
            {
                Console.WriteLine("Вы не авторизованы");
                return;        
            }
        
            var url = "http://localhost:5027/store/add"; // Замените на порт вашего сервера
            Console.WriteLine("Введите название продукта:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите цену продукта:");
            var price = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество на складе:");
            var stock = int.Parse(Console.ReadLine());

            var product = new
            {
                Name = name,
                Price = price,
                Stock = stock
            };

            var client = new HttpClient(); 
            var json = JsonSerializer.Serialize(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync(url, content).Result;
            if (resp.IsSuccessStatusCode)
            {
                var respContent = resp.Content.ReadAsStringAsync().Result;
                Console.WriteLine(respContent);
            }
            else
            {
                Console.WriteLine($"Error: {resp.StatusCode}");
            }
    }


    static void Main(string[] args)
    {
        var client = new HttpClient();
        Authorize();
        if (!IsAuthorized)
            {
                Console.WriteLine("Вы не авторизованы.");
                
            }
        else{
            SendProduct();
            }
        
=======
        var response = await client.PostAsync(url, content).Result;
=======

        var response =  client.PostAsync(url, content).Result;
>>>>>>> 9a42ddb0 (feat: added answer to task 16)
        if (response.IsSuccessStatusCode)
        {
            var result =  response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
            IsAuthorized = true;
            
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
            IsAuthorized = false;
            
        }
>>>>>>> 43b20e84 (feat: added answers to tasks 15, 16)
    }
    public static void SendProduct()
    {        
            if(!IsAuthorized)
            {
                Console.WriteLine("Вы не авторизованы");
                return;        
            }
        
            var url = "http://localhost:5027/store/add"; // Замените на порт вашего сервера
            Console.WriteLine("Введите название продукта:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите цену продукта:");
            var price = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество на складе:");
            var stock = int.Parse(Console.ReadLine());

            var product = new
            {
                Name = name,
                Price = price,
                Stock = stock
            };

            var client = new HttpClient(); 
            var json = JsonSerializer.Serialize(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync(url, content).Result;
            if (resp.IsSuccessStatusCode)
            {
                var respContent = resp.Content.ReadAsStringAsync().Result;
                Console.WriteLine(respContent);
            }
            else
            {
                Console.WriteLine($"Error: {resp.StatusCode}");
            }
    }


    static void Main(string[] args)
    {
        var client = new HttpClient();
        Authorize();
        if (!IsAuthorized)
            {
                Console.WriteLine("Вы не авторизованы.");
                
            }
        else{
            SendProduct();
            }
        
    }
}
