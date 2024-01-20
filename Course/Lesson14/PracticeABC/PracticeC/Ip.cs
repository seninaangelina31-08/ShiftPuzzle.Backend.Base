namespace PracticeC
{
    public class Ip
    {
        public string ip { get; set; }

        public Ip() {}

        public Ip(string IP)
        {
            this.ip = IP;
        }
    }

    public class GeoData
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

        public GeoData() {}

        public GeoData(string Ip, string Hostname, string City, string Region, string Country, string Loc, string Org, string Postal, string Timezone, string Readme)
        {
            this.ip = Ip;
            this.hostname = Hostname;
            this.city = City;
            this.region = Region;
            this.country = Country;
            this.loc = Loc;
            this.org = Org;
            this.postal = Postal;
            this.timezone = Timezone;
            this.readme = Readme;
        }
 
    }

    public class GeoLoc
    {
        public string postcode { get; set; }
        public string country { get; set; }
        public string countryabbreviation { get; set; }
        public List<PlaceInfo> places { get; set; }

        public GeoLoc() { }

        public GeoLoc(string Postcode, string Country, string CA, List<PlaceInfo> Places)
        {
            this.postcode = Postcode;
            this.country = Country;
            this.countryabbreviation = CA;
            this.places = Places;
        }

    }

    public class PlaceInfo
    {
        public string placename { get; set; }
        public string longitude { get; set; }
        public string state { get; set; }
        public string stateabbreviation { get; set; }
        public string latitude { get; set; }

        public PlaceInfo() { }

        public PlaceInfo(string Placename, string Longitude, string State, string SA, string Latitude)
        {
            this.placename = Placename;
            this.longitude = Longitude;
            this.state = State;
            this.stateabbreviation = SA;
            this.latitude = Latitude;
        }
    }
}
