namespace homework;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

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

    public static void WriteToFile(List<APIObject> ls)
    {
        string[] lines = new string[ls.Count * 3];
        APIObject objec;
        for (int i = 0; i < ls.Count; i++)
        {
            objec = ls[i];
            if (objec.Auth == ""){
                objec.Auth = "Не требуется";
            }
            lines[i * 3] = "ССЫЛКА: " + objec.Link;
            lines[i * 3 + 1] = "ОПИСАНИЕ: " + objec.Description;
            lines[i * 3 + 2] = "АВТОРИЗАЦИЯ: " + objec.Auth + "\n"; 
        }

        File.WriteAllLines("FREE_API.txt", lines);
    }

    public class APIObject 
    {
        public string API { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Auth { get; set; }
    }
    
    public class RootObject
    {
        public List<APIObject> entries { get; set; }
    }


    static void Main(string[] args)
    { 
        string apiURL = "https://api.publicapis.org/entries"; 
        string jsonFromApi = GetRequest(apiURL);  

        RootObject response = JsonSerializer.Deserialize<RootObject>(jsonFromApi);
        WriteToFile(response.entries);
    }

}
