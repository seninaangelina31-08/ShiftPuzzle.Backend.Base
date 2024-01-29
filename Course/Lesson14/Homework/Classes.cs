namespace homework;

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
