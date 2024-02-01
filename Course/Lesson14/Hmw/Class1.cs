namespace Hmw;

using System.Net;
using System.IO;
using System;
using System.Text.Json;

public class InfoApi
{
    public string API { get; set; }
    public string Description { get; set; }
    public string Auth { get; set; }
    public bool HTTPS { get; set; }
    public string Cors { get; set; }
    public string Link { get; set; }
    public string Category { get; set; }
}

public class AllInfo
{
    public int count { get; set; }
    public List<InfoApi> entries { get; set; }
}

public class NewApiInfo
{
    public string url { get; set; }
    public string description { get; set; }
    public string auth { get; set; }

    public NewApiInfo(string Url, string Description, string Auth)
    {
        this.url = Url;
        this.description = Description; 
        this.auth = Auth;
    }
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
        string path = "FREE_API.txt";
        StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Append));
        string apiURL = "https://api.publicapis.org/entries";
        string jsonFromApi = GetRequest(apiURL);
        AllInfo apis = JsonSerializer.Deserialize<AllInfo>(jsonFromApi);
        foreach (InfoApi ar in apis.entries)
        {   
            if (ar.Auth == "")
            {
                sw.WriteLine($"Ссылка: {ar.Link} \nОписание: {ar.Description} \nАвторизация: не нужна\n");
            } else 
            {
                sw.WriteLine($"Ссылка: {ar.Link} \nОписание: {ar.Description} \nАвторизация: {ar.Auth}\n");
            }
        }

    }
}