namespace practice_C;

 public class MyApi
 {
    public string ip { get; set; }
    public MyApi() {}
 }

public class MySredaObitania
{
    public string ip { get; set; }
    public string hostname { get; set; }
    public string city { get; set; }
    public string region { get; set; }
    public string country  { get; set; }
    public string loc  { get; set; }
    public string org  { get; set; }
    public string postal  { get; set; }
    public string timezone  { get; set; }
    public MySredaObitania() {}
}
public class MyData
{
    public string country { get; set; }
    public List<Places> places { get; set; }
    public MyData() {}
}

public class Places
{
    public string state { get; set; }
    public  string longitude { get; set; }
    public string latitude { get; set; }
    public string state_abbreviation { get; set; }
    public Places() {}
}