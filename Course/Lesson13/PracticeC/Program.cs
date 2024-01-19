using System;
using System.Collections.Generic; // библиотека для работы с List и Dictionary
using System.Text.Json;
using practicec;

namespace practicec;

class Program
{
    static void Main(string[] args)
    {
        // Задание 1
        Console.WriteLine("Task1");
        const string path = "1.json";
        string jsonFromFile = File.ReadAllText(path);
        Movie movei1 = JsonSerializer.Deserialize<Movie>(jsonFromFile);
        string json1 = JsonSerializer.Serialize(movei1);
        //File.WriteAllText(path, json1);

        // Первый фильм
        Director director1 = new Director("Джеймс Кэмерон", "1954-08-16");
        Actor actor1 = new Actor("Леонардо Ди Каприо", "Джек Доусон");
        Rate ratings1 = new Rate(8.4f, "96%"); 
        List<string> genres1 = new List<string>{"Романтика", "Приключения"};
        List<Actor> cast1 = new List<Actor>{actor1};
        Movie movie2 = new Movie("Титаник", 1997, director1, cast1, genres1, ratings1);
        string json2 = JsonSerializer.Serialize(movie2);
        //File.WriteAllText(path, json2);

        // Второй фильм
        Director director2 = new Director("Джеймс Кэмерон", "1954-08-16");
        Actor actor2 = new Actor("Леонардо Ди Каприо", "Джек Доусон");
        Rate ratings2 = new Rate(8.4f, "96%"); 
        List<string> genres2 = new List<string>{"Романтика", "Приключения"};
        List<Actor> cast2 = new List<Actor>{actor1};
        Movie movie3 = new Movie("Форсаж", 2001, director2, cast2, genres2, ratings2);
        string json3 = JsonSerializer.Serialize(movie3);
        List<string> json_movies = new List<string>{json1, json2, json3};
        //var json_m = JsonSerializer.Serialize(json_movies);
        //File.WriteAllLines(path, json1);
        //File.WriteAllLines(path, json2);
        //File.WriteAllLines(path, json3);

        // Задание 2
        Console.WriteLine("Task2");
        const string path2 = "2.json";
        string jsonFromFile2 = File.ReadAllText(path2);
        Company company = JsonSerializer.Deserialize<Company>(jsonFromFile2);
        Console.WriteLine(company.companyName);
        List<string> skills_proger = new List<string>{"Коммуникабельность", "Умение работать в команде", "Адаптивность"};
        Employ proger = new Employ(1003, "Александр Иванов", "Программист", skills_proger, 250000);
        company.Add_employ(proger);
        string json_comp = JsonSerializer.Serialize(company);
        File.WriteAllText(path2, json_comp);

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
        this.name = name;
        this.role = Role;
    }
}

[System.Serializable] public class Rate 
{
    public float IMDb;
    public string RottenTomatoes;

    public Rate() {}

    public Rate(float imdb, string rottenTomatoes) 
    {
        this.IMDb = imdb;
        this.RottenTomatoes = rottenTomatoes;
    }
}

[System.Serializable] public class Movie
{
    public string title { get; set; }
    public int year { get; set; }
    public Director director { get; set; }
    public List<Actor> cast;
    public List<string> genres;
    public Rate ratings;

    public Movie() {}

    public Movie(string Title, int Year,  Director Director, List<Actor> Cast, List<string> Genres, Rate Ratings)
    {
        this.title = Title;
        this.year = Year;
        this.director = Director; 
        this.cast = Cast;
        this.genres = Genres;
        this.ratings = Ratings;
    }
}

[System.Serializable] public class Employ
{
    public int id;
    public string name;
    public string position;
    public List<string> skills;
    public int salary;

    public Employ() {}

    public Employ(int Id, string Name, string Position, List<string> Skills, int Salary)
    {
        this.id = Id;
        this.name = Name;
        this.position = Position;
        this.skills = Skills;
        this.salary = Salary;
    }
}

[System.Serializable] public class Location
{
    public string city { get; set; }
    public string addres { get; set; }

    public Location() {}
    
    public Location(string City, string Addres)
    {
        this.city = City;
        this.addres = Addres;
    }
}


[System.Serializable] public class Company
{
    public string companyName { get; set; }
    public List<Employ> employees { get; set; }
    public Location location { get; set; }

    public Company() {}

    public Company(string CompanyName, List<Employ> Employees, Location locations)
    {
        this.companyName = CompanyName;
        this.employees = Employees;
        this.location = locations;
    }

    public void Add_employ(Employ emp)
    {
        employees.Add(emp);
    }
}
