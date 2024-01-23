namespace Homework;

using System;
using System.IO;
using System.Net;
using System.Text.Json;


[System.Serializable] public class Api
{
    public string API { get; set; }
    public string Description { get; set; }
    public string Auth { get; set; }
    public bool HTTPS { get; set; }
    public string Cors { get; set; }
    public string Link { get; set; }
    public string Category { get; set; }

    public Api(){}
    public Api(string API, string Description, string Auth, bool HTTPS,
     string Cors, string Link, string Category)
     {
        this.API = API;
        this.Description = Description;
        this.Auth = Auth;
        this.HTTPS = HTTPS;
        this.Cors = Cors;
        this.Link = Link;
        this.Category = Category;
     }
}

[System.Serializable] public class APIList
{
    public int count { get; set; }
    public List<Api> entries { get; set; }

    public APIList(){}
    public APIList(int count, List<Api> entries)
    {
        this.count = count;
        this.entries = entries;
    }
}


[System.Serializable] public class ShortApi
{
    public string Link { get; set; }
    public string Description { get; set; }
    public string Auth { get; set; } 

    public ShortApi(){}
    public ShortApi(string link, string description, string auth)
    {
        this.Link = link;
        this.Description = description;
        this.Auth = auth;
    }
}

[System.Serializable] public class ShortApiList
{
    public List<ShortApi> List { get; set; }

    public ShortApiList(){}
    public ShortApiList(List<ShortApi> list)
    {
        this.List = list;
    }
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
        List<string> free_api = [];
        ShortApiList non_auth_api = new ShortApiList([]);
        string url = "https://api.publicapis.org/entries";
        APIList list = JsonSerializer.Deserialize<APIList>(Request(url));

        foreach (var el in list.entries)
        {
            if (el.Link.Contains("github"))
            {
                free_api.Add(el.Link);
            }
            if (el.Auth.Length == 0)
            {
                non_auth_api.List.Add(new ShortApi(el.Link, el.Description, "No"));
            } 
        }
        File.WriteAllLines("FREE_API.txt", free_api);
        File.WriteAllText("NON_AUTH_API.json", JsonSerializer.Serialize(non_auth_api));

    }
}
