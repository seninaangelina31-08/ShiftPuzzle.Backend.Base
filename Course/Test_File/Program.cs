using System.Text.Json;

namespace PracticeC;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!\n");

        Console.WriteLine("#1");

        const string path_1 = "1.json";
        string jsonFromFile_1 = File.ReadAllText(path_1);
        Film_Catalog films = JsonSerializer.Deserialize<Film_Catalog>(jsonFromFile_1);

        Director Jhames = new Director("Джеймс Кэмерон", "1954-08-16");
        var Avatar_cast = new List <Cast>
        {
            new Cast{ name = "Сэм Уортингтон", role = "Джейк Салли"},
            new Cast{ name = "Зои Салдана", role = "Нейтири"}
        };
        var Avatar_genres = new List <string>
        {
            "Фантастика", "Фэнтези", "Боевик"
        };
        Ratings Avatar_ratings = new Ratings(7.9, "82%");

        var Terminator_cast = new List <Cast>
        {
            new Cast{ name = "Арнольд Шварценеггер", role = "Терминатор"},
            new Cast{ name = "Майкл Бин", role = "Кайл Риз"}
        };
        var Terminator_genres = new List <string>
        {
            "Фантастика", "Боевик", "Триллер"
        };
        Ratings Terminator_ratings = new Ratings(8.1, "100%");

        var Titanic_cast = new List <Cast>
        {
            new Cast{ name = "Арнольд Шварценеггер", role = "Терминатор"},
            new Cast{ name = "Майкл Бин", role = "Кайл Риз"}
        };
        var Titanic_genres = new List <string>
        {
            "Мелодрама", "История", "Триллер"
        };
        Ratings Titanic_ratings = new Ratings(7.9, "88%");

        Film Avatar = new Film("Аватар", 2009, Jhames, Avatar_cast, Avatar_genres, Avatar_ratings);
        Film Terminator = new Film("Тирменатор", 1984, Jhames, Terminator_cast, Terminator_genres, Titanic_ratings);
        Film Titanic = new Film("Титаник", 1997, Jhames, Titanic_cast, Titanic_genres, Titanic_ratings);
        
        films.Film_catalog.Add(Avatar);
        films.Film_catalog.Add(Terminator);
        films.Film_catalog.Add(Titanic);

        string json_1 = JsonSerializer.Serialize(films);
        File.WriteAllText(path_1, json_1);
        Console.WriteLine("Фильмы добавлены.\n");

    }
}

[System.Serializable] public class Director
{
    public string name { get; set; }
    public string born { get; set; }
    public Director() {}
    public Director(string name_copy, string born_copy)
    {
        this.name = name_copy;
        this.born = born_copy;
    }
}

[System.Serializable] public class Cast
{
    public string name { get; set; }
    public string role { get; set; }
    public Cast() {}
    public Cast(string name_copy, string role_copy)
    {
        this.name = name_copy;
        this.role = role_copy;
    }
}


[System.Serializable] public class Ratings
{
    public double IMDb { get; set; }
    public string Rotten_Tomatoes { get; set; }
    public Ratings() {}
    public Ratings(double IMDb_copy, string Rotten_Tomatoes_copy)
    {
        this.IMDb = IMDb_copy;
        this.Rotten_Tomatoes = Rotten_Tomatoes_copy;
    }
}

[System.Serializable] public class Film
{
    public string title { get; set; }
    public int year { get; set; }
    public Director director { get; set; }
    public List <Cast> cast { get; set; }
    public List <string> genres { get; set; }
    public Ratings ratings { get; set; }
    public Film() {}
    public Film(string title_copy, int year_copy, Director director_copy, List <Cast> cast_copy, List <string> gentes_copy, Ratings ratings_copy)
    {
        this.title = title_copy;
        this.year = year_copy;
        this.director = director_copy;
        this.cast = cast_copy;
        this.genres = gentes_copy;
        this.ratings = ratings_copy;
    }
}