namespace PrC;

public class IP
{
    public string ip { get; set; }
}


public class PlaceforIp
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
}

public class Place
{
    public string place_name { get; set; }
    public string longitude { get; set; }
    public string state { get; set; }
    public string state_abbreviation { get; set; }
    public string latitude { get; set; }

}

public class  Coordinates
{
    public string post_code { get; set; }
    public string country { get; set; }
    public string country_abbreviation { get; set; }
    public List<Place> places { get; set; }
}
