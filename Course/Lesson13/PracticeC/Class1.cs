using System;
using System.Collections.Generic;
using System.Text.Json;

namespace PracticeC;

[System.Serializable]public class Film
{
    public string title { get; set; }
    public int year { get; set; }
    Director director { get; set; }
    public List<Cast> cast { get; set; }
    public List<string> genres { get; set; }
    Rate ratings { get; set; }

    public Film() { } 
    public Film(string t, int y, Director d, List<Cast> c, List<string> g, Rate r)
    {
        this.title = t;
        this.year = y;
        this.director = d;
        this.cast = c;
        this.genres = g;
        this.ratings = r;
    }
}

[System.Serializable]public class Director
{
    public string name { get; set; }
    public DateTime born { get; set; }
    public Director() { } 
    public Director(string a, DateTime b)
    {
        this.name = a;
        this.born = b;
    }
}
[System.Serializable]public class Cast
{
    public string name { get; set; }
    public string role { get; set; }
    public Cast() { } 
    public Cast(string a, string b)
    {
        this.name = a;
        this.role = b;
    }
}
[System.Serializable]public class Rate{
    public double imdb { get; set; }
    public string tm { get; set; }
    public Rate(double a, string b)
    {
        this.imdb = a;
        this.tm = b;
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

class Program
{
    static void Main(string[] args)
    {

        Film f1 = new Film("Холоп", 2019, new Director("Клим Шипенко", DateTime.ParseExact("1983-06-16", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture)), new List<Cast> { new Cast("Милош Бикович", "Холоп"), new Cast("Александр Самойленко", "Папа") }, new List<string> {"Комедия", "Мелодрама" }, new Rate(7.1,"70%"));
        Film f2 = new Film("The Good Doctor", 2017, new Director("Фредди Хаймор", DateTime.ParseExact("1992-02-14", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture)), new List<Cast> { new Cast("Фредди Хаймор", "доктор Шон Мерфи"), new Cast("Хилл Харпер", "доктор Маркус Эндрюс") }, new List<string> { "Драма"}, new Rate(8.0,"68%"));
        Film f3 = new Film("Harry Potter", 2001, new Director("Крис Коламбус", DateTime.ParseExact("1958-09-10", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture)), new List<Cast> { new Cast("Дэниел Рэдклифф", "Гарри Поттер"), new Cast("Том Фелтон", "Драко Малфой") }, new List<string> { "Приключения", "Фэнтези", "Семейное" }, new Rate(6.5,"91%"));
        Film[] f4 = new Film[]{f1,f2,f3};

        string json = JsonSerializer.Serialize(f4);
        const string path = "1.json";
        File.WriteAllText(path, json);
        string jsonFromFile = File.ReadAllText(path);
        Film[] read_f = JsonSerializer.Deserialize<Film[]>(jsonFromFile);

        const string path2 = "2.json";
        string jsonFromFile2 = File.ReadAllText(path2);
        Company company = JsonSerializer.Deserialize<Company>(jsonFromFile2);
        List<string> skills_proger = new List<string>{"Коммуникабельность", "Умение работать в команде"};
        Employ proger = new Employ(1003, "Иван Иванов", "Программист", skills_proger, 250000);
        company.Add_employ(proger);
        string json_comp = JsonSerializer.Serialize(company);
        File.WriteAllText(path2, json_comp);
    }
}