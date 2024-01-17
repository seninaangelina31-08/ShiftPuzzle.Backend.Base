using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace PracticeC
{
    public class Directors{
        public string name { get; set; }
        public string born { get; set; }

         public Directors(string name, string born)
        {
            this.name = name;
            this.born = born;
        }
    }

    public class Cast{
        public string name { get; set; }
        public string role { get; set; }

         public Cast(string name, string role)
        {
            this.name = name;
            this.role = role;
        }
    }

    public class Rate{
        public double imdb { get; set; }
        public string rotten { get; set; }

         public Rate(double imdb, string rotten)
        {
            this.imdb = imdb;
            this.rotten = rotten;
        }
    }

    [System.Serializable] public class Film
    {
        public string title { get; set; }
        public int year { get; set; }
        public List<Directors> director { get; set; }
        public List<Cast> cast { get; set; }
        public string[] genres { get; set; }
        public Rate rating { get; set; }

        //public Film() { }//

        public Film(string title, int year, List<Directors> director, List<Cast> cast, string[] genres, Rate rating)
        {
            this.title = title;
            this.year = year;
            this.director = director;
            this.cast = cast;
            this.genres = genres;
            this.rating = rating;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //const string path = "1.json";
            //string jsonFromFile = File.ReadAllText(path);
            //Film f1 = JsonSerializer.Deserialize<Film>(jsonFromFile);

            List<Directors> director2 = new List<Directors> {new Directors("Cris Colambus", "1958-09-10")};
            List<Cast> cast2 = new List<Cast>{new Cast("Daniel Radcliffe", "Harry Potter"), new Cast("Rupert Grint", "Ron"), new Cast("Emma Watson", "Germiona")};
            string[] genres2 = new string[]{"fantasi", "advanture", "family"};
            Rate rating2 = new Rate(8.3, "94%");
            Film f2 = new Film("Harry Potter and Philosophy stone", 2001, director2, cast2, genres2, rating2);


            List<Directors> director3 = new List<Directors> {new Directors("Konstantin Bronzit", "1965-04-12")};
            List<Cast> cast3 = new List<Cast>{new Cast("Oleg Kulikovich", "Alyosha"), new Cast("Dmitry Vysocky", "Ilya")};
            string[] genres3 = new string[] {"mult", "fantasi", "family"};
            Rate rating3 = new Rate(7.8, "94%");
            Film f3 = new Film("Alyosha Popovich and Zmiy", 2004, director3, cast3, genres3, rating3);

            List<Directors> director4 = new List<Directors>{new Directors("Anton Fedotov", "1963-05-12"), new Directors("Anton Maslov", "1978-04-22"), new Directors("Ekaterina Zabulonskaya", "1992-10-02")};
            List<Cast> cast4 = new List<Cast>{new Cast("Milosh Bikovich", "Pasha"), new Cast("Diana Pozharskaya", "Dasha")};
            string[] genres4 =  new string[] {"comedy"};
            Rate rating4 = new Rate(7.4, "84%");
            Film f4 = new Film("Hotel Eleon", 2017, director4, cast4, genres4, rating4);

            //string json1 = JsonSerializer.Serialize(f1);
            string json2 = JsonSerializer.Serialize(f2);
            string json3 = JsonSerializer.Serialize(f3);
            string json4 = JsonSerializer.Serialize(f4);

            string json = "[\n" + json2 + ",\n" + json3 + ",\n" + json4 + "\n]";

            File.WriteAllText("1.json", json);
        }
    }
}
