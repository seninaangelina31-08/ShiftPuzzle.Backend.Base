using System;
using System.Net;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

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
        string apiURL = "https://api.publicapis.org/entries";
        string jsonApi = GetRequest(apiURL);

        // Configure JsonSerializer options
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            IgnoreNullValues = true, // Skip properties with null values
            Converters =
            {
                new AuthConverter() // Custom converter for Auth property
            }
        };

        // Deserialize the JSON response
        var apiData = JsonSerializer.Deserialize<ApiData>(jsonApi, options);

        // Write the GitHub API URLs to a file
        using (StreamWriter writer = new StreamWriter("FREE_API.txt"))
        {
            foreach (var entry in apiData.Entries)
            {
                if (string.IsNullOrEmpty(entry.Auth) && entry.Link.Contains("github.com"))
                {
                    writer.WriteLine(entry.Link);
                }
            }
        }
    }

    public class AuthConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;

            return reader.GetString();
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }

    public class ApiEntry
    {
        public string API { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Auth { get; set; }
        public bool? HTTPS { get; set; }
        public string Cors { get; set; }
        public string[] Tags { get; set; }
    }

    public class ApiData
    {
        public ApiEntry[] Entries { get; set; }
    }
}