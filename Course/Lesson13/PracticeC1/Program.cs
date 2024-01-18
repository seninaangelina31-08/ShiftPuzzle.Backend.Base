using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
namespace PracticeC;



[System.Serializable]public class Director
{
    // поля класса
    public string name { get; set; }
    public DateTime born { get; set; }
    public Director() { } // Пустой конструктор для десериализации
    public Director(string a, DateTime b)
    {
        this.name = a;
        this.born = b;
    }
}
[System.Serializable]public class Cast
{
    // поля класса
    public string name { get; set; }
    public string role { get; set; }
    public Cast() { } // Пустой конструктор для десериализации
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
[System.Serializable]public class Film
{
    // поля класса
    public string title { get; set; }
    public int year { get; set; }
    Director director { get; set; }
    public List<Cast> cast { get; set; }
    public List<string> genres { get; set; }
    Rate ratings { get; set; }

    public Film() { } // Пустой конструктор для десериализации
    public Film(string a, int b, Director d, List<Cast> c, List<string> g, Rate r)
    {
        this.title = a;
        this.year = b;
        this.director = d;
        this.cast = c;
        this.genres = g;
        this.ratings = r;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Director a = new Director("Роберт Земекис", DateTime.ParseExact("1952-05-14", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));

        Cast b1 = new Cast("Майкл Дж. Фокс", "Марти МакФлай");
        Cast b2 = new Cast("Кристофер Ллойд", "Доктор Эмметт Браун");
        List<Cast> c = new List<Cast> { b1, b2 };

        Rate r = new Rate(8.5,"31%");
        List<string> s = new List<string> { "Приключения", "Комедия", "Научная фантастика" };
        Film f1 = new Film("Назад в будущее", 1985, a, c, s, r);
        //-------

        Film f2 = new Film("Harry Potter", 2001, new Director("Крис Коламбус", DateTime.ParseExact("1958-09-10", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture)), new List<Cast> { new Cast("Дэниел Рэдклифф", "Гарри Поттер"), new Cast("Том Фелтон", "Драко Малфой") }, new List<string> { "Приключения", "Фэнтези", "Семейное" }, new Rate(6.5,"91%"));
        //--------

        Film f3 = new Film("Очень странные дела", 2016, new Director("братьями Даффер", DateTime.ParseExact("1984-02-15", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture)), new List<Cast> { new Cast("Финн Вулфхард", "Майк Уилер"), new Cast("Милли Бобби Браун", "11") }, new List<string> { "Хоррор", "Драма", "Научная фантастика" }, new Rate(10.0,"100%"));
        //------------
        Film[] f4 = new Film[]{f1,f2,f3};

        // Сериализация в JSON
        string json = JsonSerializer.Serialize(f4);
        //Console.WriteLine(json); // вывод сериализованного объекта в консоль
        const string path = "1.json";
        
        File.WriteAllText(path, json); // запись объекта в JSON файл
        // Десериализация из JSON
        string jsonFromFile = File.ReadAllText(path);
        Film[] read_f = JsonSerializer.Deserialize<Film[]>(jsonFromFile);
    }
}
