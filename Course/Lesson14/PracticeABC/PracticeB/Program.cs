namespace PracticeB;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

class Genderize
{
    public string gender {get; set;}
}
// class Login
// {
//     public string uuid {get; set;}
//     public string username {get; set;}
//     public string password {get; set;}
//     public string salt {get; set;}
//     public string md5 {get; set;}
//     public string sha1 {get; set;}
//     public string sha256 {get; set;}
// }
// class Dob
// {
//     public string date {get; set;}
//     public int age {get; set;}
// }
// class Registered
// {
//     public string date {get; set;}
//     public int age {get; set;}
// }
// class ID 
// {
//     public string name {get; set;}
//     public string value {get; set;}
// }
// class Picture
// {
//     public string large {get; set;}
//     public string medium {get; set;}
//     public string thumbnail {get; set;}
// }
// class Street
// {
//     public int number {get; set;}
//     public string name {get; set;}
// }
// class Coordinates
// {
//     public string latitude {get; set;}
//     public string longitude {get; set;}
// }
// class Timezone
// {
//     public string offset {get; set;}
//     public string description {get; set;}
// }
// class Location
// {
//     public Street street {get; set;}
//     public string city {get; set;}
//     public string state {get; set;}
//     public string country {get; set;}
//     public int postcode {get; set;}
//     public Coordinates coordinates {get; set;}
//     public Timezone timezone {get; set;}
// }
// class Name
// {
//     public string title {get; set;}
//     public string first {get; set;}
//     public string last {get; set;}
// }
class Result
{
    public string gender {get; set;}
    // public Name name {get; set;}
    // public Location location {get; set;}
    // public string email {get; set;}
    // public Login logib {get; set;}
    // public Dob dob {get; set;}
    // public Registered registered {get; set;}
    // public string phone {get; set;}
    // public string cell {get; set;}
    // public ID id {get; set;}
    // public Picture picture {get; set;}
    // public string nat {get; set;}
}

// class Info
// {
//     public string seed {get; set;}
//     public int results {get; set;}
//     public int page {get; set;}
//     public string version {get; set;}
// }
class Random_user
{
    public List<Result> results {get; set;}
    // public Info info {get; set;}
}
class Program
{
    public static string GetRequest(string url)
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
        string URL = "https://randomuser.me/api/"; 
        string json = GetRequest(URL); 
        string URL2 = "https://api.genderize.io/?name=vadim";
        string json2 = GetRequest(URL2);
        
        Random_user user = JsonSerializer.Deserialize<Random_user>(json);
        Genderize gender = JsonSerializer.Deserialize<Genderize>(json2);
        
        string us_gender = user.results[0].gender;
        if (us_gender == gender.gender)
            Console.Write("Да");
        else
            Console.Write("Нет");
        
    }
}
