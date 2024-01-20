namespace PracticeB
{
    [System.Serializable] public class User
    {
        public List<Results> results { get; set; }
        public Info info { get; set; }

        public User() { }

        public User(List<Results> REsults, Info INfo)
        {
            this.results = REsults;
            this.info = INfo;
        }
    }

    [System.Serializable] public class Results
    {
        public string gender { get; set; }
        public Name name { get; set; }
        public Location location { get; set; }
        public string email { get; set; }
        public Login login { get; set; }
        public Dob dob { get; set; }
        public Registered registered { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public Id id { get; set; }
        public Picture picture { get; set; }
        public string nat { get; set; }

        public Results() {}

        public Results(string Gender, Name NAme, Location LOcation, string Email, Login LOgin, Dob DOb, Registered REgistered, string Phone, string Cell, Id ID, Picture PIcture, string Nat)
        {
            this.gender = Gender;
            this.name = NAme;
            this.location = LOcation;
            this.email = Email;
            this.login = LOgin;
            this.dob = DOb;
            this.registered = REgistered;
            this.phone = Phone;
            this.cell = Cell;
            this.id = ID;
            this.picture = PIcture;
            this.nat = Nat;
        }

    }

    [System.Serializable] public class Name
    {
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }

        public Name() {}

        public Name(string Title, string First, string Last)
        {
            this.title = Title;
            this.first = First;
            this.last = Last;
        }

        
    }

    [System.Serializable] public class Location
    {
        public Street street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public int postcode { get; set; }
        public Coordinates coordinates { get; set; }
        public Timezone timezone { get; set; }

        public Location() {}

        public Location(Street STreet, string City, string State, string Country, int Postcode, Coordinates COordinates, Timezone TImezone)
        {
            this.street = STreet;
            this.city = City;
            this.state = State;
            this.country = Country;
            this.postcode = Postcode;
            this.coordinates = COordinates;
            this.timezone = TImezone;
        }
    }

    [System.Serializable] public class Street
    {
        public int number { get; set; }
        public string name { get; set; }

        public Street() {}

        public Street(int Number, string Name)
        {
            this.number = Number;
            this.name = Name;
        }
    }

    [System.Serializable] public class Coordinates
    {
        public string latitude { get; set; }
        public string longitude { get; set; }

        public Coordinates() {}

        public Coordinates(string Latitude, string Longitude)
        {
            this.latitude = Latitude;
            this.longitude = Longitude;
        }
    }

    [System.Serializable] public class Timezone
    {
        public string offset;
        public string description;

        public Timezone() {}

        public Timezone(string Offset, string Description)
        {
            this.offset = Offset;
            this.description = Description;
        }
    }

    [System.Serializable] public class Login
    {
        public string uuid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }

        public Login() {}

        public Login(string Uuid, string Username, string Password, string Md5, string Sha1, string Sha256)
        {
            this.uuid = Uuid;
            this.username = Username;
            this.password = Password;
            this.md5 = Md5;
            this.sha1 = Sha1;
            this.sha256 = Sha256;
        }

    }

    [System.Serializable] public class Dob
    {
        public string date { get; set; }
        public int age { get; set; }

        public Dob() {}

        public Dob(string Date, int Age)
        {
            this.date = Date;
            this.age = Age;
        }
    }

    [System.Serializable] public class Registered
    {
        public string date { get; set; }
        public int age { get; set; }

        public Registered() {}

        public Registered(string Date, int Age)
        {
            this.date = Date;
            this.age = Age;
        }
    }

    [System.Serializable] public class Id
    {
        public string name { get; set; }
        public string value { get; set; }

        public Id() {}

        public Id(string Name, string Value)
        {
            this.name = Name;
            this.value = Value;
        }
    }

    [System.Serializable] public class Picture
    {
        public string large { get; set; }
        public string medium { get; set; }
        public string thumbnail { get; set; }

        public Picture() {}

        public Picture(string Large, string Medium, string Thumbnail)
        {
            this.large = Large;
            this.medium = Medium;
            this.thumbnail = Thumbnail;
        }
    }

    [System.Serializable] public class Info
    {
        public string seed { get; set; }
        public int results { get; set; }
        public int page { get; set; }
        public string version { get; set; }
        
        public Info() {}

        public Info(string Seed, int Results, int Page, string Version)
        {
            this.seed = Seed;
            this.results = Results;
            this.page = Page;
            this.version = Version;
        }

    }

    [System.Serializable] public class TrueGender
    {
        public int count { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public double probability { get; set; }

        public TrueGender() { }

        public TrueGender(int Count, string Name, string Gender, double Probability)
        {
            this.count = Count;
            this.name = Name;
            this.gender = Gender;
            this.probability = Probability;
        }
    }
}