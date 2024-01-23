namespace PracticeABC;
using System.Net;
using System.IO;
using System;
using System.Text.Json;



public class CoindeskResponse
{
    public Time time { get; set; }
    public string disclaimer { get; set; }
    public string chartName { get; set; }
    public Bpi bpi { get; set; }
    
    public CoindeskResponse(){}
    public CoindeskResponse(Time time, string disclaimer, string chartName, Bpi bpi)
    {
        this.time = time;
        this.disclaimer = disclaimer;
        this.chartName = chartName;
        this.bpi = bpi;
    }
}
 public class Bpi
{
    public USD USD { get; set; }
    public GBP GBP { get; set; }
    public EUR EUR { get; set; }
    
    public Bpi(){}
    public Bpi(USD USD, GBP GBP, EUR EUR)
    {
        this.EUR = EUR;
        this.GBP = GBP;
        this.USD = USD;
    }
}
public class EUR
{
    public string code { get; set; }
    public string symbol { get; set; }
    public string rate { get; set; }
    public string description { get; set; }
    public double rate_float { get; set; }
    
    public EUR(){}
    public EUR(string code, string symbol, string rate, string description, double rate_float)
    {
        this.code = code;
        this.symbol = symbol;
        this.rate = rate;
        this.description = description;
        this.rate_float = rate_float;
    }
}
public class GBP
{
    public string code { get; set; }
    public string symbol { get; set; }
    public string rate { get; set; }
    public string description { get; set; }
    public double rate_float { get; set; }
    public GBP(){}
    public GBP(string code, string symbol, string rate, string description, double rate_float)
    {
        this.code = code;
        this.symbol = symbol;
        this.rate = rate;
        this.description = description;
        this.rate_float = rate_float;
    }
}    


public class Time
{
    public string updated { get; set; }
    public DateTime updatedISO { get; set; }
    public string updateduk { get; set; }
    
    public Time(){}
    public Time(string updated, DateTime updatedISO, string updateduk)
    {
        this.updated = updated;
        this.updatedISO = updatedISO;
        this.updateduk = updateduk;
    }
}
public class USD
{
    public string code { get; set; }
    public string symbol { get; set; }
    public string rate { get; set; }
    public string description { get; set; }
    public double rate_float { get; set; }
    public USD(){}
    public USD(string code, string symbol, string rate, string description, double rate_float)
    {
        this.code = code;
        this.symbol = symbol;
        this.rate = rate;
        this.description = description;
        this.rate_float = rate_float;
    }
}

public class RandomFact
{
    public string fact { get; set; }
    public int length { get; set; }

    public RandomFact(){}
    public RandomFact(string fact, int length)
    {
        this.fact = fact;
        this.length = length;
    }
}

[System.Serializable] public class Joke
{
    public string type { get; set; }
    public string setup { get; set; }
    public string punchline { get; set; }
    public int id { get; set; }
    
    public Joke(){}
    public Joke(string type, string setup, string punchline, int id)
    {
        this.type = type;
        this.setup = setup;
        this.punchline = punchline;
        this.id = id;
    }
}

[System.Serializable] public class UList
{
    public List<University> lst { get; set; }
    
    public UList(){}
    public UList(List<University> lst)
    {
        this.lst = lst;
    }
}
[System.Serializable] public class University
{
    public string name { get; set; }
    public string alpha_code_two { get; set; }
    public List<string> domains { get; set; }
    public string country { get; set; }
    public List<string> web_pages { get; set; }

    public University(){}
    public University(string name, string alpha_code_two, List<string> domains, string country, List<string> web_pages)
    {
        this.name = name;
        this.alpha_code_two = alpha_code_two;
        this.domains = domains;
        this.country = country;
        this.web_pages = web_pages;
    }

}

[System.Serializable] public class RandomList
{
    public List<RandomUser> results { get; set; }
    public RandomList(){}
    public RandomList(List<RandomUser> results)
    {
        this.results = results;
    } 
}

[System.Serializable] public class RandomUserandInfo
{
    public List<RandomUser> results { get; set; }
    public Info info { get; set; } 
    
    public RandomUserandInfo(){}
    public RandomUserandInfo(List<RandomUser> results, Info info)
    {
        this.results = results;
        this.info = info;
    }
}
[System.Serializable] public class RandomUser
{
    public string gender { get; set; }
    public Name name { get; set; }
    public Location location { get; set; }
    public string email { get; set; }
    public Login login { get; set; }
    public DOB dob { get; set; }
    public Registred registred { get; set; }
    public string phone { get; set; }
    public string cell { get; set; }
    public Id id { get; set; }
    public Picture picture { get; set; }
    public string nat { get; set; }

}

[System.Serializable] public class Name
{
    public string title { get; set; }
    public string first { get; set; }
    public string last { get; set; }

    public Name(){}
    public Name(string title, string first, string last)
    {
        this.title = title;
        this.first = first;
        this.last = last;
    }
}

[System.Serializable] public class Location
{
    public Street street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public int postcode { get; set; }
    public Coordinates coordinates { get; set; }
    public Timezone timezone { get; set; }


}

[System.Serializable] public class Street
{
    public int number { get; set; }
    public string name { get; set; }

    public Street(){}
    public Street(int number, string name)
    {
        this.number = number;
        this.name = name;
    }
}


[System.Serializable] public class Coordinates
{
    public string latitude { get; set; }
    public string longtitude { get; set; }

    public Coordinates(){}
    public Coordinates(string latitude, string longtitude)
    {
        this.latitude = latitude;
        this.longtitude = longtitude;
    }
}

[System.Serializable] public class Timezone
{
    public string offset { get; set; }
    public string description { get; set; }

    public Timezone(){}
    public Timezone(string offset, string description)
    {
        this.offset = offset;
        this.description = description;
    }
}

[System.Serializable] public class Login
{
    public string uuid { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string salt { get; set; }
    public string md5 { get; set; }
    public string sha1 { get; set; }
    public string sha256 { get; set; }
    public Login(){}
    public Login(string uuid, string username, string password, string salt, string md5, string sha1, string sha256)
    {
        this.uuid = uuid;
        this.username = username;
        this.password = password;
        this.salt = salt;
        this.md5 = md5;
        this.sha1 = sha1;
        this.sha256 = sha256;
    }
}
[System.Serializable] public class DOB
{
    public string date { get; set; }
    public int age { get; set; }
    
    public DOB(){}
    public DOB(string date, int age)
    {
        this.date = date;
        this.age = age;
    }
}

[System.Serializable] public class Registred
{
    public string date { get; set; }
    public int age { get; set; }
    
    public Registred(){}
    public Registred(string date, int age)
    {
        this.date = date;
        this.age = age;
    }
}

[System.Serializable] public class Id
{
    public string name { get; set; }
    public string value { get; set; }
    public Id(){}
    public Id(string name, string value)
    {
        this.name = name;
        this.value = value;
    }
}

[System.Serializable] public class Picture
{
    public string large { get; set; }
    public string medium { get; set; }
    public string thumbnail { get; set; }
    public Picture(){}
    public Picture(string large, string medium, string thumbnail)
    {
        this.large = large;
        this.medium = medium; 
        this.thumbnail = thumbnail;
    }
}

[System.Serializable] public class Info
{
    public string seed { get; set; }
    public int results { get; set; }
    public int page { get; set; }
    public string version { get; set; }

    public Info(){}
    public Info(string seed, int results, int page, string version)
    {
        this.seed = seed;
        this.results = results;
        this.page = page;
        this.version = version;
    }
}

[System.Serializable] public class Genderize
{
    public int count { get; set; }
    public string name { get; set; }
    public string gender { get; set; }
    public double probability { get; set; }
    
    public Genderize(){}
    public Genderize( int count, string name, string gender, double probability)
    {
        this.count = count;
        this.name = name;
        this.gender = gender;
        this.probability = probability;
    }
}

[System.Serializable] public class IP
{
    public string ip { get; set; }

    public IP(){}
    public IP(string ip)
    {
        this.ip = ip;
    }
}

[System.Serializable] public class IP_info_url
{
    public string ip { get; set; }
    public string hostname { get; set; }
    public string city { get; set; }
    public string region { get; set; }
    public string country { get; set; }
    public string loc { get; set; }
    public string org { get; set; }
    public string postal { get; set; }
    public string timezone { get; set; }
    public string readme { get; set; }

    public IP_info_url(){}
    public IP_info_url(string ip, string hostname, string city, string region, string country,
     string loc, string org, string postal, string timezone, string readme)
     {
        this.ip = ip;
        this.hostname = hostname;
        this.city = city;
        this.region = region;
        this.country = country;
        this.loc = loc;
        this.org = org;
        this.postal = postal;
        this.timezone = timezone;
        this.readme = readme;
            

     }
}

[System.Serializable] public class Zippo
{
    [JsonProperty("post code")]
    public string postcode { get; set; }
}
class Program
{
    public static string Request(string url)
    {
        WebRequest request = WebRequest.Create(url);
        WebResponse response = request.GetResponse();
        Stream dataStream = response.GetResponseStream();
        StreamReader streamReader = new StreamReader(dataStream);
        string jsonResponse = streamReader.ReadToEnd();
        streamReader.Close();
        response.Close();
        return jsonResponse;
    }


    static void Main(string[] args)
    {
        string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
        string json_from_request = Request(url);

        CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(json_from_request);

        double BTCPrice = response.bpi.USD.rate_float;
        Console.WriteLine($"BTC price : {BTCPrice}");



        ConsoleKeyInfo key;
        do
        {
            Console.Write("Введите R, чтобы узнать факт: ");
            key = Console.ReadKey();
            Console.WriteLine();

            if (key.Key == ConsoleKey.R)
            {
                url = "https://catfact.ninja/fact";
                json_from_request = Request(url);
                RandomFact rf = JsonSerializer.Deserialize<RandomFact>(json_from_request);
                Console.WriteLine(rf.fact);
            }
            
        }
        while (key.Key == ConsoleKey.R);

        
        // КРИВОЕ АПИ
        // url = "https://official-joke-api.appspot.com/random_joke";
        // json_from_request = Request(url);
        // Joke joke = JsonSerializer.Deserialize<Joke>(json_from_request);
        // File.WriteAllText("joke.json", JsonSerializer.Serialize(joke));

        // url = "http://universities.hipolabs.com/search";
        // json_from_request = Request(url);
        // Console.Write(json_from_request);
        // UList ulist = JsonSerializer.Deserialize<UList>(json_from_request);
        // Console.Write(ulist.lst[0].name);
        
        string url_random = "https://randomuser.me/api/";
        string json_from_request_random = Request(url_random);
        RandomUserandInfo RUaI = JsonSerializer.Deserialize<RandomUserandInfo>(json_from_request_random);
        string url_genderize = $"https://api.genderize.io/?name={RUaI.results[0].name.first}";
        string json_from_genderize = Request(url_genderize);
        Genderize genderized_user = JsonSerializer.Deserialize<Genderize>(json_from_genderize);

        if (RUaI.results[0].gender == genderized_user.gender)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }

        string ip_url = "https://api.ipify.org/?format=json";
        string ip_json = Request(ip_url);
        IP ip = JsonSerializer.Deserialize<IP>(ip_json);
        string ip_info_url = $"https://ipinfo.io/{ip.ip}/geo";
        string info_json = Request(ip_info_url);
        IP_info_url info = JsonSerializer.Deserialize<IP_info_url>(info_json);



    }
}
