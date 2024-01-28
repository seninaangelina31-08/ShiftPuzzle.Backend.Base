//*ПратикаБ*: 

//1.  Мы не можем доверять всем API, так что есть такое задание: используя АПИ для генерации рандомных данных о человеке (api: https://randomuser.me/api/) проверь является ли указанный пол дейсвтительно правильным но уже через червис (api: https://api.genderize.io/?name=vadim) ответ должен быть простым. Если все совпадает - да, если нет - НЕТ.

//*ПрактикаС*: 

//1. Получи свой IP адрес через (api: https://api.ipify.org?format=json) и через сервис (https://ipinfo.io/109.93.165.66/geo) вытащи почтовый код и обозначение страны, который надо будет прогнать через  (api: https://api.zippopotam.us/us/33162) и получить долготу и широту ближайшего почтовое отделения, для того чтобы наш дрон мог доставить посылку

//подсказки: 
//1. *https://api.ipify.org/?format=json      получаем =>  {"ip":"109.93.165.66"}*
//2. *https://ipinfo.io/109.93.165.66/geo     получаем =>  ...."postal": "11000", "country": "RS"....*
//3. *https://api.zippopotam.us/rs/11000      получаем => ....[{"place name": "Beograd", "longitude": "20.4622222", "state": "", "state abbreviation": "", "latitude": "44.8205556"}]...*
using System;
using System.Net;
using System.Text.Json;
using System.Collections.Generic;


public class IpData
{
    public string ip { get; set; }
}

public class GeoData
{
    public string postal { get; set; }
    public string country { get; set; }
}

public class ZippopotamData
{
    public string post_code { get; set; }
    public string country { get; set; }
    public string country_abbreviation { get; set; }
    public List<Location> places { get; set; }

    public class Location
{
    public string place_name { get; set; }
    public string longitude { get; set; }
    public string state { get; set; }
   
    public string StateAbbreviation { get; set; }
    public string latitude { get; set; }
}
}

public class RandUserData
{
    public RandomUserResult[] results { get; set; }
}

public class RandomUserResult
{
    public string gender { get; set; }
}

public class Genderes
{
    public string gender { get; set; }
}


class Program
{
    static void Main(string[] args)
    {

        string path1 = "https://randomuser.me/api/?inc=gender";
        string path2 = "https://api.genderize.io/?name=vadim";


       
        
        string rrr = new WebClient().DownloadString(path1);
        var randomuser = JsonSerializer.Deserialize<RandUserData>(rrr);
        string gender = randomuser.results[0].gender;

        string ggg = new WebClient().DownloadString(path2);
        var g = JsonSerializer.Deserialize<Genderes>(ggg);
        string gendercheck = g.gender;

        if (gender == gendercheck)
            {
                Console.WriteLine("Да");
            }
        else
            {
                Console.WriteLine("Нет");
            }
      

        string ipurl = "https://api.ipify.org?format=json";
        string ipjson = new WebClient().DownloadString(ipurl);
        IpData ipdata = JsonSerializer.Deserialize<IpData>(ipjson);
        string addr = ipdata.ip;

        string geoUrl = $"https://ipinfo.io/{addr}/geo";
        string geojson = new WebClient().DownloadString(geoUrl);
        GeoData geodata = JsonSerializer.Deserialize<GeoData>(geojson);
        string postalCode = geodata.postal;
        string coabr = geodata.country;

        string zipurl = $"https://api.zippopotam.us/{coabr}/{postalCode}";
        string zipjson = new WebClient().DownloadString(zipurl);
        ZippopotamData zippopotamdata = JsonSerializer.Deserialize<ZippopotamData>(zipjson);

        Console.WriteLine($"Ip адрес: {addr}");
        Console.WriteLine($"Почтовый код: {postalCode}");
        Console.WriteLine($"Страна: {coabr}");

        if (zippopotamdata != null)
        {
            Console.WriteLine($"Ближайшее почтовое отделение:");
            foreach (var place in zippopotamdata.places)
            {
                Console.WriteLine($"- Название места: {place.place_name}");
                Console.WriteLine($"- Долгота: {place.longitude}");
                Console.WriteLine($"- Широта: {place.latitude}");
            }
        }
        else
        {
            Console.WriteLine("Ближайшего отделения не найдено");
        }
        
    }
}