using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;
using System;
using System.Net;
using System.IO;

namespace Client;

class Program
{ 
    // Класс продукта
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

    public static string GetProductsData(string url)
    {
        // Считываем данные о продуктах
        WebRequest webrequest = WebRequest.Create(url);
        WebResponse response = webrequest.GetResponse();

        Stream stream = response.GetResponseStream();
        StreamReader streamReader = new StreamReader(stream);

        string json = streamReader.ReadToEnd();

        streamReader.Close();
        response.Close();

        return json;
    }

    static void DisplayProducts()
        {
            // Проверяем авторизацию клиента
            if(!IsAuthorized)
            {
                Console.WriteLine("Вы не авторизованы");
                return;        
            }

            // Запрос
            var url = "http://localhost:5087/store/show";

            // Делаем форматированный вывод списка продуктов
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("|   Название продукта   |      Цена      | Количество на складе |"); 
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(GetProductsData(url));
            foreach (var product in products)
            {
                Console.WriteLine($"| {product.name, -21} | {product.price, -14} | {product.stock, -20} |");
            }
            Console.WriteLine("-----------------------------------------------------------------");
        }


    public static void SendProduct()
    {        
        // Проверяем авторизацию клиента
        if(!IsAuthorized)
        {
            Console.WriteLine("Вы не авторизованы");
            return;        
        }
        
        // Запрос
        var url = "http://localhost:5087/store/add";

        // Вводим данные
        Console.WriteLine("Введите название продукта:");
        var name = Console.ReadLine();

        Console.WriteLine("Введите цену продукта:");
        var price = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество на складе:");
        var stock = int.Parse(Console.ReadLine());

        // Подготавливаем данные для json и последующей передачи на сервер
        var product = new
        {
            Name = name,
            Price = price,
            Stock = stock
        };

        // Упаковываем json
        var client = new HttpClient(); 
        var json = JsonSerializer.Serialize(product);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        // Ответ от сервера
        var response = client.PostAsync(url, content).Result;
        if (response.IsSuccessStatusCode)
        {
            // Получаем сообщение-ответ от сервера
            var responseContent = response.Content.ReadAsStringAsync().Result;
            // Выводим его
            Console.WriteLine($"Продукт {name} успешно добавлен");
        }
        else
        {
            // Что-то пошло не так
            Console.WriteLine($"Error: {response.StatusCode}");
        }
    }


    public static void Auth()
    {   
        // Вводим данные
        Console.Write("Введите логин: ");
        string login = Console.ReadLine();

        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        // Запрос            
        var url = "http://localhost:5087/store/auth";
        
        // Подготавливаем данные для json и последующей передачи на сервер
        var userData = new
        {
            User = login,
            Pass = password
        };

        // Упаковываем json
        var client = new HttpClient(); 
        var json = JsonSerializer.Serialize(userData);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        // Ответ от сервера
        var response = client.PostAsync(url, content).Result;
        if (response.IsSuccessStatusCode)
        {
            // Получаем сообщение-ответ от сервера
            var responseContent = response.Content.ReadAsStringAsync().Result;
            // Выводим его
            Console.WriteLine(responseContent);
            // Меняем статус клиента на авторизованный
            IsAuthorized = true;
        }
        else
        {
            // Что-то пошло не так (в том числе клиент ввел некорректный логин и пароль)
            Console.WriteLine($"Error: {response.StatusCode}");
            // Меняем статус клиента на неавторизованный
            IsAuthorized = false;
        }
    }

    public static void UpdatePrice()
    {   
        // Проверяем авторизацию клиента
        if(!IsAuthorized)
        {
            Console.WriteLine("Вы не авторизованы");
            return;        
        }

        // Вводим данные
        Console.Write("Введите имя продукта: ");
        string name = Console.ReadLine();

        Console.Write("Введите новую цену продукта: ");
        double newPrice = Convert.ToDouble(Console.ReadLine());

        // Запрос
        var url = "http://localhost:5087/store/updateprice";

        // Подготавливаем данные для json и последующей передачи на сервер
        var userData = new 
        {
            Name = name,
            NewPrice = newPrice
        };

        // Упаковываем json
        var client = new HttpClient();
        var json = JsonSerializer.Serialize(userData);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        // Ответ от сервера
        var response = client.PostAsync(url, content).Result;
        if (response.IsSuccessStatusCode)
            {
                // Получаем сообщение-ответ от сервера
                var responseContent = response.Content.ReadAsStringAsync().Result;
                // Выводим его
                Console.WriteLine(responseContent);
            }
            else
            {
                // Что-то пошло не так
                Console.WriteLine($"Error: {response.StatusCode}");
            }

    }

    public static void UpdateName()
    {   
        // Проверяем авторизацию клиента
        if(!IsAuthorized)
        {
            Console.WriteLine("Вы не авторизованы");
            return;        
        }

        // Вводим данные
        Console.Write("Введите текущее имя продукта: ");
        string name = Console.ReadLine();

        Console.Write("Введите новое имя продукта: ");
        string new_name = Console.ReadLine();

        // Запрос
        var url = "http://localhost:5087/store/updatename";

        // Подготавливаем данные для json и последующей передачи на сервер
        var Userdata = new 
        {
            CurrentName = name,
            NewName = new_name
        };

        // Упаковываем json
        var client = new HttpClient();
        var json = JsonSerializer.Serialize(Userdata);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        // Ответ от сервера
        var response = client.PostAsync(url, content).Result;
        if (response.IsSuccessStatusCode)
            {
                // Получаем сообщение-ответ от сервера
                var responseContent = response.Content.ReadAsStringAsync().Result;
                // Выводим его
                Console.WriteLine(responseContent);
            }
            else
            {
                // Что-то пошло не так
                Console.WriteLine($"Error: {response.StatusCode}");
            }

    }

    static void Main(string[] args)
    { 
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Приложение клиента активно
        bool running = true;
        while (running)
                {
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1.Авторизация\n2.Добавление продукта\n3.Вывод списка\n4.Выход\n5.Обновление цены\n6.Обновление имени");

                    // Считываем команду клиента
                    var choice = Console.ReadLine();

                    // Обрабатываем команду клиента
                    switch (choice)
                    { 
                        case "1":
                        {
                            // Авторизация
                            Auth();
                            break;
                        }
                        case "2":
                        {
                            // Добавить продукт
                            SendProduct();
                            break;
                        }
                        case "3":
                        {
                            // Вывести список продуктов
                            DisplayProducts();
                            break;
                        }
                        case "4":
                        {
                            // Снимаем флажок того, что клиент активен
                            running = false;
                            // Снимаем флажок авторизации
                            IsAuthorized = false;
                            break;
                        }
                        case "5":
                        {
                            // Изменение цены
                            UpdatePrice();
                            break;
                        }
                        case "6":
                        {
                            // Изменение названия продукта
                            UpdateName();
                            break;
                        }
                        default:
                            // Неверная команда
                            Console.WriteLine("Неверный выбор. Попробуйте снова.");
                            break;
                    }
                }
    }
}