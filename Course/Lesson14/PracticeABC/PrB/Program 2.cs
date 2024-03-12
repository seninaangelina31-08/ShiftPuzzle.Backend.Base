namespace PrB;
using System.Net;
using System.IO;
using System;
using System.Text.Json;


class Program
{  
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
    static void Main(string[] args)
    {
        string coindeskURL = $"https://randomuser.me/api/"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла

        RootObject deserializedObject = JsonSerializer.Deserialize<RootObject>(jsonFromCoindesk);

        string name = deserializedObject.results[0].name.first;
        string gender1 = deserializedObject.results[0].gender;

        string coindeskURL2 = $"https://api.genderize.io/?name={name}"; // наша ссылка для  битка
        string jsonFromCoindesk2 = GetRequest(coindeskURL2);
        Gender2 deserializedObject2 = JsonSerializer.Deserialize<Gender2>(jsonFromCoindesk2);

        string gender2 = deserializedObject2.gender;

        if (gender1 == gender2){
            Console.Write("YES");
        } else {
            Console.Write("NO");
        }
    }
    public class Gender2
    {
        public int count { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public double probability { get; set; }
    }
    public class Name
    {
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }
    }

    public class Street
    {
        public int number { get; set; }
        public string name { get; set; }
    }

    public class Coordinates
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class Timezone
    {
        public string offset { get; set; }
        public string description { get; set; }
    }

    public class Location
    {
        public Street street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public int postcode { get; set; }
        public Coordinates coordinates { get; set; }
        public Timezone timezone { get; set; }
    }

    public class Login
    {
        public string uuid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }
    }

    public class Dob
    {
        public DateTime date { get; set; }
        public int age { get; set; }
    }

    public class Registered
    {
        public DateTime date { get; set; }
        public int age { get; set; }
    }

    public class Id
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class Picture
    {
        public string large { get; set; }
        public string medium { get; set; }
        public string thumbnail { get; set; }
    }

    public class Result
    {
        public string gender { get; set; }
        public Name name { get; set; }
        public Location location { get; set; }
        public string email { get; set; }
        public Login login { get; set; }
        public Dob dob { get; set; }
        public Registered registered { get; set; }
        public string phone { get; set; }
        public string cell { get; set;}
        public Id id { get;set;}
        public Picture picture {get;set;}
        public string nat{get;set;}
    }

    public class Info
    {
        public string seed{get;set;}
        public int results{get;set;}
        public int page{get;set;}
        public string version{get;set;}
    }

    public class RootObject
    {
        public Result[] results{get;set;}
        public Info info{get;set;}
    }
}
