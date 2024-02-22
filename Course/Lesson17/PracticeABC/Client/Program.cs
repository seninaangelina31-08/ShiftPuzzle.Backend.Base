using System.ComponentModel.DataAnnotations;
using System.Text;
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

    static void DisplayProducts()
        {
            var url = "http://localhost:5087/store/show"; // Замените на порт вашего сервера

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("| Название продукта | Цена | Количество на складе |"); 
            foreach (var obj in product)
            {
                Console.WriteLine($"| {obj.name, -18} | {obj.price, -5} | {obj.stock, -19} |");
            }
            Console.WriteLine("-----------------------------------------------------------------");
        }

    public static string GetRequest(string url) // функция принимает адерс api
    {
        WebRequest request = WebRequest.Create(url); // создаем запрос
        WebResponse response = request.GetResponse(); // отправляем команду на получение ответа
        Stream dataStream = response.GetResponseStream(); // открываем поток для чтения (это как File.Readline только для сети)
        StreamReader streamReader = new StreamReader(dataStream); // Открываем чтение потока
        string jsonResponse = streamReader.ReadToEnd(); // получаем текст

        streamReader.Close();   // закрываем за собой чтение потока
        response.Close();  
        return jsonResponse;  // возвращаем ответ
    }

    public static void UpdateName()
    {        
        if(!IsAuthorized)
        {
            Console.WriteLine("Вы не авторизованы");
            return;        
        }
    
        var url = "http://localhost:5087/store/updatename"; // Замените на порт вашего сервера
        Console.WriteLine("Введите название продукта:");
        var currentName = Console.ReadLine();
        Console.WriteLine("Введите новое название продукта:");
        var newName = Console.ReadLine();
        url += $"?currentName={currentName}&newName={newName}";
        string Request = GetRequest(url);
        Console.WriteLine(Request);
    }
    
    public static void UpdatePrice()
    {        
        if(!IsAuthorized)
        {
            Console.WriteLine("Вы не авторизованы");
            return;        
        }
    
        var url = "http://localhost:5087/store/updateprice"; // Замените на порт вашего сервера
        Console.WriteLine("Введите название продукта:");
        var name = Console.ReadLine();
        Console.WriteLine("Введите новую цену продукта:");
        var newPrice = Console.ReadLine();
        url += $"?name={name}&newPrice={newPrice}";
        string Request = GetRequest(url);
        Console.WriteLine(Request);
    }
    public static void SendProduct()
    {        
            if(!IsAuthorized)
            {
                Console.WriteLine("Вы не авторизованы");
                return;        
            }
        
            var url = "http://localhost:5087/store/add"; // Замените на порт вашего сервера
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

            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(responseContent);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
    }


    public static void Auth()
    {       
        
        
            var url = "http://localhost:5087/store/????"; // Замените на порт вашего сервера, также замените символы на правильный апи
            var userData = new
            {
                User = "admin",
                Pass = "123"
            };

            var client = new HttpClient(); 
            var json = JsonSerializer.Serialize(userData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(responseContent);
                IsAuthorized = true;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                IsAuthorized = false;
            }
    }


    static void Main(string[] args)
 { 
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
                {
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("Выберите функцию:\n1. Авторизация\n2. Обновление цены\n3. Обновение имени\n4. Вывод списка\n5. Добавление продукта\n6. Выход");
                     

                    var user_choice = Console.ReadLine();

                    switch (user_choicechoice)
                    { 
                        case "1":
                            Auth();
                            break;
                        case "2":
                            UpdatePrice();
                            break;
                        case "3":
                            UpdateName();
                            break;
                        case "4":
                            DisplayProducts();
                            break;
                        case "5":
                            SendProduct();
                            break;
                        case "6":
                            Console.WriteLine("-----------------------------------------------------------------");
                            return;
                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте снова.");
                            break;
                    }
                    Console.WriteLine("-----------------------------------------------------------------");
                }   
}             