using System;
using System.Collections.Generic;
using System.Text.Json;

namespace FilmSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Film film1 = new Film
            {
                Title = "Назад в будущее",
                Year = 1985,
                Director = new Director
                {
                    Name = "Роберт Земекис",
                    Born = new DateTime(1952, 5, 14)
                },
                Cast = new List<Actor>
                {
                    new Actor { Name = "Майкл Дж. Фокс", Role = "Марти МакФлай" },
                    new Actor { Name = "Кристофер Ллойд", Role = "Доктор Эмметт Браун" }
                },
                Genres = new List<string> { "Приключения", "Комедия", "Научная фантастика" },
                Ratings = new Ratings
                {
                    IMDb = 8.5,
                    RottenTomatoes = "96%"
                }
            };
            Film film2 = new Film
            {
                Title = "Назад в будущее2",
                Year = 1985,
                Director = new Director
                {
                    Name = "Роберт Земекис",
                    Born = new DateTime(1952, 5, 14)
                },
                Cast = new List<Actor>
                {
                    new Actor { Name = "Майкл Дж. Фокс", Role = "Марти МакФлай" },
                    new Actor { Name = "Кристофер Ллойд", Role = "Доктор Эмметт Браун" }
                },
                Genres = new List<string> { "Приключения", "Комедия", "Научная фантастика" },
                Ratings = new Ratings
                {
                    IMDb = 8.5,
                    RottenTomatoes = "96%"
                }
            };
            Film film3 = new Film
            {
                Title = "Назад в будущее3",
                Year = 1985,
                Director = new Director
                {
                    Name = "Роберт Земекис",
                    Born = new DateTime(1952, 5, 14)
                },
                Cast = new List<Actor>
                {
                    new Actor { Name = "Майкл Дж. Фокс", Role = "Марти МакФлай" },
                    new Actor { Name = "Кристофер Ллойд", Role = "Доктор Эмметт Браун" }
                },
                Genres = new List<string> { "Приключения", "Комедия", "Научная фантастика" },
                Ratings = new Ratings
                {
                    IMDb = 8.5,
                    RottenTomatoes = "96%"
                }
            };

            string jsonString = JsonSerializer.Serialize(new { films = new List<Film> { film1, film2, film3 } });
            var path = "1_new.json";
            File.WriteAllText(path, jsonString);
        }
    }

    public class Director
    {
        public string Name { get; set; }
        public DateTime Born { get; set; }
    }

    public class Actor
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }

    public class Ratings
    {
        public double IMDb { get; set; }
        public string RottenTomatoes { get; set; }
    }

    public class Film
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Director Director { get; set; }
        public List<Actor> Cast { get; set; }
        public List<string> Genres { get; set; }
        public Ratings Ratings { get; set; }
    }

    public class RootObject
    {
        public List<Film> Films { get; set; }
    }
}
