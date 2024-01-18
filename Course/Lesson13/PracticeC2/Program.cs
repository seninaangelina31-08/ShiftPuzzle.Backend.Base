using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;


[System.Serializable]public class Emp
{
    // поля класса
    public int id { get; set; }
    public string name { get; set; }
    public string position { get; set; }
    public List<string> skills { get; set; }
    public int salary { get; set; }

    public Emp() 
    { } // Пустой конструктор для десериализации
    public Emp(int i, string n, string p, List<string> sk, int sa)
    {
        this.id=i;
        this.name=n;
        this.position=p;
        this.skills=sk;
        this.salary=sa;
    }
}
[System.Serializable]public class Location
{
    // поля класса
    public string city { get; set; }
    public string address { get; set; }

    public Location() 
    { } // Пустой конструктор для десериализации
    public Location(string n, string p)
    {
        this.city=n;
        this.address=p;
    }
}
[System.Serializable]public class Company
{
    // поля класса
    public string companyName { get; set; }
    public List<Emp> employees { get; set; }
    public Location location { get; set; }

    public Company() { } // Пустой конструктор для десериализации
    public Company(string c, List<Emp> e, Location l)
    {
        this.companyName=c;
        this.employees=e;
        this.location=l;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Company c= new Company(
            "ООО Рога и Копыта",
            new List<Emp>{
                new Emp(1001,"Алексей Иванов","Директор", 
                new List< string>{"Управление", "Планирование", "Коммуникация"},
                150000), 
                new Emp(1002,"Мария Смирнова","Главный бухгалтер",
                new List< string>{"Бухгалтерский учет", "Финансовый анализ"},
                120000),
                new Emp(1003,"Сергей Мышкин","Приграммист", 
                new List< string>{"Кодинг", "Командная работа", "Лень"},
                160000)},
            new Location("Москва","ул. Пушкина, д. 10"));

        // Сериализация в JSON
        string json = JsonSerializer.Serialize(c);
        //Console.WriteLine(json); // вывод сериализованного объекта в консоль
        const string path = "2.json";
        
        File.WriteAllText(path, json); // запись объекта в JSON файл

         // Создаем новый JSON для хранения количества работников по каждой специальности
        var empl = c.employees.GroupBy(e => e.position).ToDictionary(g => g.Key, g => g.Count());
        var emplJSON = JsonSerializer.Serialize(empl, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("empl.json", emplJSON);
        // Анализ по ЗП в компании - выводим среднюю ЗП
        var averageSalary = c.employees.Average(e => e.salary);
        Console.WriteLine($"Средняя ЗП в компании: {averageSalary}");

    }
}
