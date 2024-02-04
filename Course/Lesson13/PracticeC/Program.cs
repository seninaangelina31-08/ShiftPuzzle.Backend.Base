
using System.Text.Json;



namespace PracticeC;

public class Film_Desk
{
    public List<Film>  film_desk { get; set; }
    public Film_Desk() {}

    public Film_Desk(List<Film> Film_desk)
    {
        this.film_desk = Film_desk;
    }
}

[System.Serializable]public class Film
{
    public string title { get; set; }
    public int year { get; set; }
    public Directors director { get; set; }
    public List<Casts> cast { get; set; }
    public List<string> genres { get; set; }
    public Ratings ratings { get; set; }

    public Film() {}

  public Film(string Title, int Year, Directors Derector, List<Casts> Cast, List<string> Genre, Ratings Rating)
    {
        this.title = Title;
        this.year = Year;
        this.cast = Cast;
        this.genres = Genre;
        this.ratings = Rating;
    }
}
  [System.Serializable]public class Directors
{
    public string name { get; set; }
    public string born { get; set; }

    public Directors() {}

    public Directors(string Name, string Born)
    {
        this.name = Name;
        this.born = Born;
    }
}

[System.Serializable] public class Casts
{
    public string name { get; set; }
    public string role { get; set; }

    public Casts() {}

    public Casts(string actor_name, string actor_role)
    {
        this.name = actor_name;
        this.role = actor_role;
    }
}

 [System.Serializable]public class Ratings
{
    public double IMDb { get; set; }
    public string Rotten_Tomatoes { get; set; }

    public Ratings() {}

    public Ratings(double iMDb, string rotten_Tomatoes)
    {
        this.IMDb = iMDb;
        this.Rotten_Tomatoes = rotten_Tomatoes;
    }
}


class Program
{
    static void Main(string[] args)
    {

    const string path = "1.json";
    string jsonFromFile = File.ReadAllText(path);
    Film_Desk film = JsonSerializer.Deserialize<Film_Desk>(jsonFromFile);

    var Ludi_v_Chernom_casts = new List<Casts>
    {
        new Casts {name = "Уилл Смит", role = "Агент Джей"},
        new Casts {name = "Томми Ли Джонс", role = "Агент Кей"}
    };

     Directors Stiv_Perri = new Directors("Стив Перри", "31-08-1947");


     var Ludi_v_Chernom_genres =  new List<string>
     {"Фантастика", "Комедии", "Детективы"};

     Ratings Ludi_v_Chernom_rating = new Ratings(8.0, "80%");
     
    
    var Harry_Potter_casts = new List<Casts>
    {
        new Casts {name = "Дэниэл Рэдклифф", role = "Гарри Потер"},
        new Casts {name = "Руперт Гринт", role = "Рон  Уизли"}
    };

     Directors Kris_Kolambus = new Directors("Крис Коламбус", "10-09-1958");


     List<string>  Harry_Potter_genres =  new List<string>
     {"фэнтези"," приключения", "семейный"};

     Ratings arry_Potter_rating = new Ratings(8.2, "81%");


    var Begishi_v_Lab_casts = new List<Casts>
    {
        new Casts {name = "Дилан О’Брайен", role = "Томас"},
        new Casts {name = "Томас Сангстер", role = "Майк"}
    };

     Directors Wes_Ball = new Directors("Уэс Болл", "28-10-1980");


     List<string>  Begishi_v_Lab_genres =  new List<string>
     {"фантастика", "триллер", "приключения"};

     Ratings Begishi_v_Lab_rating = new Ratings(6.8, "50%");


    Film Ludi_v_Chernom = new Film("Люди в черном", 1997, Stiv_Perri, Ludi_v_Chernom_casts, Ludi_v_Chernom_genres, Ludi_v_Chernom_rating);
    Film Harry_Potter = new Film("Гарри Потер и Филосовский камень", 2001,  Kris_Kolambus, Harry_Potter_casts, Harry_Potter_genres, arry_Potter_rating);
    Film Begishi_v_Lab = new Film("Бегущий в Лабиринте", 2014, Wes_Ball, Begishi_v_Lab_casts, Harry_Potter_genres, Begishi_v_Lab_rating);

    film.film_desk.Add(Ludi_v_Chernom);
    film.film_desk.Add(Harry_Potter);
    film.film_desk.Add(Begishi_v_Lab);
    



    string json_1 = JsonSerializer.Serialize(film);
    File.WriteAllText(path, json_1);
    Console.WriteLine("Your favourite films was added!");
    }
}
