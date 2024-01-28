namespace PracticeABC;
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
        // Practice A
        // #1
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла

        BPIAPIJSON response_1 = JsonSerializer.Deserialize<BPIAPIJSON>(jsonFromCoindesk); // десериализация
        
        double bitcoinPrice = response_1.bpi.USD.rate_float * 88.28; // получение нужной инфы
        Console.WriteLine("Bitcoin price : " +  bitcoinPrice + "₽."); // вывод

        // #2
        string catURL = "https://catfact.ninja/fact";
        string jsonFromCat = GetRequest(catURL);

        CatfactAPIJSON response_2 = JsonSerializer.Deserialize<CatfactAPIJSON>(jsonFromCat);
        
        Console.WriteLine("Fact about cats: " + response_2.fact);

        // #3
        const string path = "3.json";
        string jsonFromFile = File.ReadAllText(path);
        JAPIJSON joke = new JAPIJSON();
        if (jsonFromFile != null) joke = JsonSerializer.Deserialize<JAPIJSON>(jsonFromFile);

        string jokeURL = "https://official-joke-api.appspot.com/random_joke";
        string jsonFromJoke = GetRequest(jokeURL);

        JokeAPIJSON response_3 = JsonSerializer.Deserialize<JokeAPIJSON>(jsonFromJoke);

        joke.joke.Add(response_3);
        
        string json = JsonSerializer.Serialize(joke);
        File.WriteAllText(path, json);

        // #4
        Console.Write("Введите название страны(На английском): ");
        string country = Console.ReadLine();
        string universitiesURL = "http://universities.hipolabs.com/search?country=" + country;
        string jsonFromUniversities = GetRequest(universitiesURL);
        if (jsonFromUniversities.Length > 2)
        {
            List<UniversitiesAPIJSON> response_4 = JsonSerializer.Deserialize<List<UniversitiesAPIJSON>>(jsonFromUniversities);
            Console.WriteLine("ТОП-3 университета" + country);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + " место - " + response_4[i].name);
            }
        }
        else
        {
            Console.WriteLine("Данной страны либо не существует, либо нет в базе данных.");
        }

        // Practice B
        // #1
        string randomuserURL = "https://randomuser.me/api/";
        string jsonFromRandomuser = GetRequest(randomuserURL);

        RandomuserAPI response_randomuser = JsonSerializer.Deserialize<RandomuserAPI>(jsonFromRandomuser);

        string genderizeURL = "https://api.genderize.io/?name=" + response_randomuser.results[0].name.first;
        string jsonFromGenderize = GetRequest(genderizeURL);

        GenderizeAPI response_genderize = JsonSerializer.Deserialize<GenderizeAPI>(jsonFromGenderize);

        if (response_randomuser.results[0].gender == response_genderize.gender) Console.WriteLine("ДА");
        else Console.WriteLine("НЕТ");
        
        // Practice C
        // #1
        string ipifyURL = "https://api.ipify.org?format=json";
        string jsonFromIPify = GetRequest(ipifyURL);

        IPifyAPI response_ipify = JsonSerializer.Deserialize<IPifyAPI>(jsonFromIPify);

        string ipinfoURL = "https://ipinfo.io/" + response_ipify.ip + "/geo";
        string jsonFromIPinfo = GetRequest(ipinfoURL);

        IPinfoAPI response_ipinfo = JsonSerializer.Deserialize<IPinfoAPI>(jsonFromIPinfo);

        string ZipURL = "https://api.zippopotam.us/rs/" + response_ipinfo.postal;
        string ZipURL_01 = "";
        for (int i = 0; i < ZipURL.Length-1; i++) ZipURL_01 += ZipURL[i];
        string jsonFromZippopotam = GetRequest(ZipURL_01);
        Console.WriteLine(response_ipinfo.postal);
        ZippopotamAPI response_zippopotam = JsonSerializer.Deserialize<ZippopotamAPI>(jsonFromZippopotam);

        Console.WriteLine("longitude: " + response_zippopotam.places[0].longitude + "\nlatitude: " + response_zippopotam.places[0].latitude);
    }
}

// Practice A
[System.Serializable] public class Currency
{
    public string code { get; set; }
    public string symbol { get; set; }
    public string rate { get; set; }
    public string description { get; set; }
    public double rate_float { get; set; }
    public Currency() {}
    public Currency(string code_copy, string symbol_copy, string rate_copy, string description_copy, double rate_float_copy)
    {
        this.code = code_copy;
        this.symbol = symbol_copy;
        this.rate = rate_copy;
        this.description = description_copy;
        this.rate_float = rate_float_copy;
    }
}

[System.Serializable] public class Default_Currency
{
    public Currency USD { get; set; }
    public Currency GBP { get; set; }
    public Currency EUR { get; set; }
    public Default_Currency() {}
    public Default_Currency(Currency USD_copy, Currency GBP_copy, Currency EUR_copy)
    {
        this.USD = USD_copy;
        this.GBP = GBP_copy;
        this.EUR = EUR_copy;
    }

}

[System.Serializable] public class Time_BPI
{
    public string updated { get; set; }
    public string updatedISO { get; set; }
    public string updateduk { get; set; }
    public Time_BPI() {}
    public Time_BPI(string updated_copy, string updatedISO_copy, string updateduk_copy)
    {
        this.updated = updated_copy;
        this.updatedISO = updatedISO_copy;
        this.updateduk = updateduk_copy;
    }
}

[System.Serializable] public class BPIAPIJSON
{
    public Time_BPI time { get; set; }
    public string disclaimer { get; set; }
    public string chartName { get; set; }
    public Default_Currency bpi { get; set; }
    public BPIAPIJSON() {}
    public BPIAPIJSON(Time_BPI time_copy, string disclaimer_copy, string chartName_copy, Default_Currency bpi_copy)
    {
        this.time = time_copy;
        this.disclaimer = disclaimer_copy;
        this.chartName = chartName_copy;
        this.bpi = bpi_copy;
    }
}

[System.Serializable] public class CatfactAPIJSON
{
    public string fact { get; set; }
    public int length { get; set; }
    public CatfactAPIJSON() {}
    public CatfactAPIJSON(string fact_copy, int length_copy)
    {
        this.fact = fact_copy;
        this.length = length_copy;
    }
}

[System.Serializable] public class JokeAPIJSON
{
    public string type { get; set; }
    public string setup { get; set; }
    public string punchline { get; set; }
    public int id { get; set; }
    public JokeAPIJSON() {}
    public JokeAPIJSON(string type_copy, string setup_copy, string punchline_copy, int id_copy)
    {
        this.type = type_copy;
        this.setup = setup_copy;
        this.punchline = punchline_copy;
        this.id = id_copy;
    }
}

[System.Serializable] public class JAPIJSON
{
    public List<JokeAPIJSON> joke { get; set; }
    public JAPIJSON() {}
    public JAPIJSON(List<JokeAPIJSON> joke_copy)
    {
        this.joke = joke_copy;
    }
}

[System.Serializable] public class UniversitiesAPIJSON
{
    public string name { get; set; }
    public string alpha_two_code { get; set; }
    public string country { get; set; }
    public bool nastate_provinceme { get; set; }
    public List<string> domains { get; set; }
    public List<string> web_pages { get; set; }
    public UniversitiesAPIJSON() {}
    public UniversitiesAPIJSON(string name_copy, string alpha_two_code_copy, string country_copy, bool nastate_provinceme_copy, List<string> domains_copy, List<string> web_pages_copy)
    {
        this.name = name_copy;
        this.alpha_two_code = alpha_two_code_copy;
        this.country = country_copy;
        this.nastate_provinceme = nastate_provinceme_copy;
        this.domains = domains_copy;
        this.web_pages = web_pages_copy;
    }
}

// Practice B

// RandomuserAPI
[System.Serializable] public class Name
{
    public string title { get; set; }
    public string first { get; set; }
    public string last { get; set; }
    public Name() {}
    public Name(string title_copy, string first_copy, string last_copy)
    {
        this.title = title_copy;
        this.first = first_copy;
        this.last = last_copy;
    }
}

[System.Serializable] public class Street
{
    public int number { get; set; }
    public string name { get; set; }
    public Street() {}
    public Street(int number_copy, string name_copy)
    {
        this.number = number_copy;
        this.name = name_copy;
    }
}

[System.Serializable] public class Coordinates
{
    public string latitude { get; set; }
    public string longitude { get; set; }
    public Coordinates() {}
    public Coordinates(string latitude_copy, string longitude_copy)
    {
        this.latitude = latitude_copy;
        this.longitude = longitude_copy;
    }
}

[System.Serializable] public class Timezone
{
    public string offset { get; set; }
    public string description { get; set; }
    public Timezone() {}
    public Timezone(string offset_copy, string description_copy)
    {
        this.offset = offset_copy;
        this.description = description_copy;
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
    public Login() {}
    public Login(string uuid_copy, string username_copy, string password_copy, string salt_copy, string md5_copy, string sha1_copy, string sha256_copy)
    {
        this.uuid = uuid_copy;
        this.username = username_copy;
        this.password = password_copy;
        this.salt = salt_copy;
        this.md5 = md5_copy;
        this.sha1 = sha1_copy;
        this.sha256 = sha256_copy;
    }
}

[System.Serializable] public class Dob
{
    public string date { get; set; }
    public int age { get; set; }
    public Dob() {}
    public Dob(string date_copy, int age_copy)
    {
        this.date = date_copy;
        this.age = age_copy;
    }
}

[System.Serializable] public class Registered
{
    public string date { get; set; }
    public int age { get; set; }
    public Registered() {}
    public Registered(string date_copy, int age_copy)
    {
        this.date = date_copy;
        this.age = age_copy;
    }
}

[System.Serializable] public class Id
{
    public string name { get; set; }
    public string value { get; set; }
    public Id() {}
    public Id(string name_copy, string value_copy)
    {
        this.name = name_copy;
        this.value = value_copy;
    }
}

[System.Serializable] public class Picture
{
    public string large { get; set; }
    public string medium { get; set; }
    public string thumbnail { get; set; }
    public Picture() {}
    public Picture(string large_copy, string medium_copy, string thumbnail)
    {
        this.large = large_copy;
        this.medium = medium_copy;
        this.thumbnail = thumbnail;
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

    public Location() {}
    public Location(Street street_copy, string city_copy, string state_copy, string country_copy, int postcode_copy, Coordinates coordinates_copy, Timezone timezone_copy)
    {
        this.street = street_copy;
        this.city = city_copy;
        this.state = state_copy;
        this.country = country_copy;
        this.postcode = postcode_copy;
        this.coordinates = coordinates_copy;
        this.timezone = timezone_copy;
    }
}

[System.Serializable] public class Results
{
    public string gender { get; set; }
    public Name name { get; set; }
    public Location location { get; set; }
    public string email { get; set; }
    public Login login { get; set; }
    public Dob dob { get; set; }
    public Registered registered { get; set; }
    public string phone { get; set; }
    public string cell { get; set; }
    public Id id { get; set; }
    public Picture picture { get; set; }
    public string nat { get; set; }

    public Results() {}
    public Results(string gender_copy, Name name_copy, Location location_copy, string email_copy, Login login_copy, Dob dob_copy, Registered registered_copy, string phone_copy, string cell_copy, Id id_copy, Picture picture_copy, string nat_copy)
    {
        this.gender = gender_copy;
        this.name = name_copy;
        this.location = location_copy;
        this.email = email_copy;
        this.login = login_copy;
        this.dob = dob_copy;
        this.registered = registered_copy;
        this.phone = phone_copy;
        this.cell = cell_copy;
        this.id = id_copy;
        this.picture = picture_copy;
        this.nat = nat_copy;
    }
}

[System.Serializable] public class Info
{
    public string seed { get; set; }
    public int results { get; set; }
    public int page { get; set; }
    public string version { get; set; }

    public Info() {}
    public Info(string seed_copy, int results_copy, int page_copy, string version_copy)
    {
        this.seed = seed_copy;
        this.results = results_copy;
        this.page = page_copy;
        this.version = version_copy;
    }
}

[System.Serializable] public class RandomuserAPI
{
    public List<Results> results { get; set; }
    public Info info { get; set; }
    public RandomuserAPI() {}
    public RandomuserAPI(List<Results> results_copy, Info info_copy)
    {
        this.results = results_copy;
        this.info = info_copy;
    }
}

// Genderize
[System.Serializable] public class GenderizeAPI
{
    public int count { get; set; }
    public string name { get; set; }
    public string gender { get; set; }
    public double probability { get; set; }
    public GenderizeAPI() {}
    public GenderizeAPI(int count_copy, string name_copy, string gender_copy, double probability_copy)
    {
        this.count = count_copy;
        this.name = name_copy;
        this.gender = gender_copy;
        this.probability = probability_copy;
    }
}

// Practice C

// IPify
[System.Serializable] public class IPifyAPI
{
    public string ip { get; set; }
    public IPifyAPI() {}
    public IPifyAPI(string ip_copy)
    {
        this.ip = ip_copy;
    }
}

// IPinfo
[System.Serializable] public class IPinfoAPI
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
    public IPinfoAPI() {}
    public IPinfoAPI(string ip_copy, string hostname_copy, string city_copy, string region_copy, string country_copy, string loc_copy, string org_copy, string postal_copy, string timezone_copy, string readme_copy)
    {
        this.ip = ip_copy;
        this.hostname = hostname_copy;
        this.city = city_copy;
        this.region = region_copy;
        this.country = country_copy;
        this.loc = loc_copy;
        this.org = org_copy;
        this.postal = postal_copy;
        this.timezone = timezone_copy;
        this.readme = readme_copy;
    }
}

// Zippopotam
[System.Serializable] public class ZippopotamAPI
{
    public string postcode { get; set; }
    public string country { get; set; }
    public string country_abbreviation { get; set; }
    public List<Places> places { get; set; }
    public ZippopotamAPI() {}
    public ZippopotamAPI(string postcode_copy, string country_copy, string country_abbreviation_copy, List<Places> places_copy)
    {
        this.postcode = postcode_copy;
        this.country = country_copy;
        this.country_abbreviation = country_abbreviation_copy;
        this.places = places_copy;
    }
}

[System.Serializable] public class Places
{
    public string place_name { get; set; }
    public string longitude { get; set; }
    public string state { get; set; }
    public string state_abbreviation { get; set; }
    public string latitude { get; set; }
    public Places() {}
    public Places(string place_name_copy, string longitude_copy, string state_copy, string state_abbreviation_copy, string latitude_copy)
    {
        this.place_name = place_name_copy;
        this.longitude = longitude_copy;
        this.state = state_copy;
        this.state_abbreviation = state_abbreviation_copy;
        this.latitude = latitude_copy;
    }
}
