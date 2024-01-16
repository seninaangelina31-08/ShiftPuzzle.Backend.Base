using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace PracticeC;
class Program
{
    public class Actors
    {
        public string name {get; set;}
        public string role {get; set;}

        public Actors (string Name, string Role)
        {
            this.name = Name;
            this.role = Role;
        }
    }
    public class Directors
    {
        public string name {get; set;}
        public string born {get; set;}
        
        public Directors(string Name, string Born)
        {
            this.name = Name;
            this.born = Born;
        }
    }
    public class Ratings
    {
        public float IMDb {get; set;}
        public string Rotten_Tomatoes {get; set;}

        public Ratings(float imdb, string rotten_tomatoes)
        {
            this.IMDb = imdb;
            this.Rotten_Tomatoes = rotten_tomatoes;
        }
    }
    [System.Serializable] public class Movies
    {
        public string title {get; set;}
        public int year {get; set;}
        public List<Directors> director {get; set;}
        public List<Actors> cast {get; set;}
        public string[] genres {get; set;}
        public Ratings ratings {get; set;}

        public Movies() { }

        public Movies(string Title, int Year,  List<Directors> Director, List<Actors> Cast, string[] Genres, Ratings rating)
        {
            this.title = Title;
            this.year = Year;
            this.director = Director;
            this.cast = Cast;
            this.genres = Genres;
            this.ratings = rating;
        }
    }
    static void Main(string[] args)
    {
        var options1 = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic, UnicodeRanges.MathematicalOperators),
            WriteIndented = true
        };

        string jsonFromFile = File.ReadAllText("1.json");
        Movies movie1 = JsonSerializer.Deserialize<Movies>(jsonFromFile);
        List<Directors> dir1 = new List<Directors> {new Directors("Оливье Накаш", "1973-04-15"), new Directors("Эрик Толедано", "1971-07-03")};
        List<Actors> act1 = new List<Actors> {new Actors("Франсуа Клюзе", "Филипп"), new Actors("Омар Си", "Дрисс")};
        string[] genr1 = {"Драма", "Комедия", "Биография"};
        Ratings Intouchables = new Ratings(8.5f, "93%");
        Movies movie2 = new Movies("Intouchables", 2011, dir1, act1, genr1, Intouchables);
        List<Directors> dir2 = new List<Directors> {new Directors("Пит Доктер", "1968-10-09"), new Directors("Кемп Пауэрс", "1973")};
        List<Actors> act2 = new List<Actors> {new Actors("Джейми Фокс", "Джо Гарднер"), new Actors("Тина Фей", "22"), new Actors("Грэм Нортон", "Лунветр")};
        string[] genr2 = {"Мультфильм", "Фэнтези", "Комедия", "Приключения", "Семейный", "Музыка"};
        Ratings Soul = new Ratings(8f, "95%");
        Movies movie3 = new Movies("Душа", 2020, dir2, act2, genr2, Soul);
        List<Directors> dir3 = new List<Directors> {new Directors("Боб Персичетти", "none"), new Directors("Питер Рэмзи", "1962-12-23"), new Directors("Родни Ротман", "none")};
        List<Actors> act3 = new List<Actors> {new Actors("Шамеик Мур", "Майлз Моралес"), new Actors("Джейк Джонсон", "Человек-Паук"), new Actors("Хейли Стайнфлд", "Женщина-Паук"), new Actors("Махершала Али", "Бродяга / Аарон Дэвис")};
        string[] genr3 = {"Мультфильм", "Фантастика", "Боевик", "Комедия", "Приключения", "Семейный"};
        Ratings SM = new Ratings(8.4f, "97%");
        Movies movie4 = new Movies("Человек-паук: Через вселенные", 2018, dir3, act3, genr3, SM);
        string json1 = JsonSerializer.Serialize(movie1, options1);
        string json2 = JsonSerializer.Serialize(movie2, options1);
        string json3 = JsonSerializer.Serialize(movie3, options1);
        string json4 = JsonSerializer.Serialize(movie4, options1);
        string json = "[\n" + json1 + ",\n" + json2 + ",\n" + json3 + ",\n" + json4 + "\n]";
        File.WriteAllText("1_finish.json", json);
    }
}
