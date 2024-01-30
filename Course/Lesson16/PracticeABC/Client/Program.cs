using System.Text;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

namespace Client;

class Program
{
    
    static void Main(string[] args)
    { 
        bool isAuth = false;
        while (!isAuth)
        {
            Console.Write("Введите никнейм: ");
            string username = Console.ReadLine();
            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            string getAPIURL = $"http://localhost:5087/user/auth?userName={username}&password={password}"; 
            string response = GetRequest(getAPIURL);
            if(response == "Ok")
            {
                isAuth = true;
                Console.WriteLine("Вы успешно аунтефицировались!");
            }
            else 
            {
                Console.WriteLine("Аккаунта не существует/не верный пароль!");
            }
        }
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
}
