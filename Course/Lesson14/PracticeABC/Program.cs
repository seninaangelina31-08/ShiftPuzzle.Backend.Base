namespace Example;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

public class NameInfo
{
    public int Count { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public double Probability { get; set; }
}

public class Root
{
    public List<Result> Results { get; set; }
    public Info Info { get; set; }
}

public class Result
{
    public string Gender { get; set; }
    public Name Name { get; set; }
    public Location Location { get; set; }
    public string Email { get; set; }
    public Login Login { get; set; }
    public DateOfBirth Dob { get; set; }
    public Registered Registered { get; set; }
    public string Phone { get; set; }
    public string Cell { get; set; }
    public Id Id { get; set; }
    public Picture Picture { get; set; }
    public string Nat { get; set; }

    Result() {}
}

public class Name
{
    public string Title { get; set; }
    public string First { get; set; }
    public string Last { get; set; }
}

public class Location
{
    public Street Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public int Postcode { get; set; }
    public Coordinates Coordinates { get; set; }
    public Timezone Timezone { get; set; }
}

public class Street
{
    public int Number { get; set; }
    public string Name { get; set; }
}

public class Coordinates
{
    public string Latitude { get; set; }
    public string Longitude { get; set; }
}

public class Timezone
{
    public string Offset { get; set; }
    public string Description { get; set; }
}

public class Login
{
    public string Uuid { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public string Md5 { get; set; }
    public string Sha1 { get; set; }
    public string Sha256 { get; set; }
}

public class DateOfBirth
{
    public DateTime Date { get; set; }
    public int Age { get; set; }
}

public class Registered
{
    public DateTime Date { get; set; }
    public int Age { get; set; }
}

public class Id
{
    public string Name { get; set; }
    public string Value { get; set; }
}

public class Picture
{
    public string Large { get; set; }
    public string Medium { get; set; }
    public string Thumbnail { get; set; }
}

public class Info
{
    public string Seed { get; set; }
    public int Results { get; set; }
    public int Page { get; set; }
    public string Version { get; set; }
}


public class CatFact
{
    public string Fact { get; set; }
    public int Length { get; set; }
    public CatFact() {}

}

public class Joke
{
    public string Type { get; set; }
    public string Setup { get; set; }
    public string Punchline { get; set; }
    public int Id { get; set; }

    public Joke() {}
}

public class University
{
    public List<string> Domains { get; set; }
    public string AlphaTwoCode { get; set; }
    public List<string> WebPages { get; set; }
    public string Name { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }

    public University() {}
}

public class LocationInfo
{
    public string PostCode { get; set; }
    public string Country { get; set; }
    public string CountryAbbreviation { get; set; }
    public List<Place> Places { get; set; }
}

public class Place
{
    public string PlaceName { get; set; }
    public string Longitude { get; set; }
    public string State { get; set; }
    public string StateAbbreviation { get; set; }
    public string Latitude { get; set; }
}

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
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json";
        string jsonFromCoindesk = GetRequest(coindeskURL); 
        
        CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk); 
        
        double bitcoinPrice = response.bpi.USD.rate_float;
        Console.Write("Bitcoin price : " +  bitcoinPrice); 

        string JsonCat = GetRequest("https://catfact.ninja/fact");
        CatFact resp1 = JsonSerializer.Deserialize<CatFact>(JsonCat);
        Console.WriteLine(resp1.Fact);

        string JsonJoke = GetRequest("https://official-joke-api.appspot.com/random_joke");
        Joke resp2 = JsonSerializer.Deserialize<Joke>(JsonJoke);
        string ser = JsonSerializer.Serialize(resp2);
        File.WriteAllText("1.json",ser);

        string JsonUni = GetRequest("http://universities.hipolabs.com/search?country=Kazakhstan");
        List<University> resp3 = JsonSerializer.Deserialize<List<University>>(JsonUni);
        Console.WriteLine(resp3[0].Name);
        Console.WriteLine(resp3[1].Name);
        Console.WriteLine(resp3[2].Name);

        string JsonPers = GetRequest("https://randomuser.me/api/");
        Result resp4 = JsonSerializer.Deserialize<Result>(JsonPers);

        string JsonS = GetRequest("https://api.genderize.io/?name=vadim");
        NameInfo resp5 = JsonSerializer.Deserialize<NameInfo>(JsonS);
        if (resp4.Gender == resp5.Gender) {
            Console.WriteLine("Да");
        } else {
            Console.WriteLine("Нет");
        }

        string JsonPost = GetRequest("https://api.zippopotam.us/rs/11000");
        LocationInfo resp6 = JsonSerializer.Deserialize<LocationInfo>(JsonPost);
        Console.WriteLine(resp6.Places[0]);

        

    }


}