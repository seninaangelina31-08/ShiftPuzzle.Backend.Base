namespace PracticeC
{

    [System.Serializable] public class Films
    {
        public List<Film> films { get; set; }

        public Films() {}

        public Films(List<Film> FIlms)
        {
            this.films = FIlms;
        }
    }
    [System.Serializable] public class Film
    {
        public string title { get; set; }
        public int year { get; set; }
        public Director director { get; set; } 
        public List<Actor> cast { get; set; } 
        public List<string> genres { get; set; }
        public Ratings ratings { get; set; }

        public Film() {}

        public Film(string Title, int Year, Director DIrector, List<Actor> Cast, List<string> Genres, Ratings RAtings)
        {
            this.title = Title;
            this.year = Year;
            this.director = DIrector;
            this.cast = Cast;
            this.genres = Genres;
            this.ratings = RAtings;
        }
    }

    [System.Serializable] public class Director
    {
        public string name { get; set; }
        public string born { get; set; }

        public Director() {}

        public Director(string Name, string Born)
        {
            this.name = Name;
            this.born = Born;
        }
    }

    [System.Serializable] public class Actor
    {
        public string name { get; set; }
        public string role { get; set; }

        public Actor() {}

        public Actor(string Name, string Role)
        {
            this.name = Name;
            this.role = Role;
        }
    }

    [System.Serializable] public class Ratings
    {
        public double IMDb { get; set; }
        public string RottenTomatoes { get; set; }

        public Ratings() {}

        public Ratings(double IMDB, string rottenTomatoes)
        {
            this.IMDb = IMDB;
            this.RottenTomatoes = rottenTomatoes;
        }
    }
}


