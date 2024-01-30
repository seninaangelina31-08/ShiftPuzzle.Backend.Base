using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using var httpClient = new HttpClient();

            // Установите базовый URI сервера
            httpClient.BaseAddress = new Uri("http://localhost:5087"); // Замените 5087 на ваш порт

            // Создайте объект продукта, который нужно добавить
            var product = new
            {
                Name = "Example Product",
                Price = 10.99
            };

            // Сериализуйте объект продукта в JSON
            var productJson = JsonSerializer.Serialize(product);

            // Отправьте POST запрос для добавления продукта
            var response = httpClient.PostAsync("/store/add", new StringContent(productJson, Encoding.Default, "application/json")).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Продукт был успешно добавлен.");
            }
            else
            {
                Console.WriteLine("Не удалось добавить продукт.");
            }
        }
    }
}
