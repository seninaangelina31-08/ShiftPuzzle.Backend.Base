using System;
using System.Collections.Generic;
using System.Text.Json;

namespace с2;

[System.Serializable]public class Emp
{
    public int id { get; set; }
    public string name { get; set; }
    public string position { get; set; }
    public List<string> skills { get; set; }
    public int salary { get; set; }

    public Emp() 
    { }
    public Emp(int i, string n, string p, List<string> sk, int sa)
    {
        this.id = i;
        this.name = n;
        this.position = p;
        this.skills = sk;
        this.salary = sa;
    }
}
[System.Serializable]public class Location
{
    public string city { get; set; }
    public string address { get; set; }

    public Location() 
    { }
    public Location(string n, string p)
    {
        this.city = n;
        this.address = p;
    }
}
[System.Serializable]public class Company
{
    public string companyName { get; set; }
    public List<Emp> employees { get; set; }
    public Location location { get; set; }

    public Company() { }
    public Company(string c, List<Emp> e, Location l)
    {
        this.companyName = c;
        this.employees = e;
        this.location = l;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Company c = new Company(
            "ООО Рога и Копыта",
            new List<Emp>{
                new Emp(1001,"Алексей Иванов","Директор", 
                new List< string>{"Управление", "Планирование", "Коммуникация"}, 150000), 
                new Emp(1002,"Мария Смирнова","Главный бухгалтер",
                new List< string>{"Бухгалтерский учет", "Финансовый анализ"}, 120000),
                new Emp(1003,"Иван Петров","Программист", 
                new List< string>{"Командная работа", "Кодинг"}, 160000)},
            new Location("Москва","ул. Пушкина, д. 10"));

        string json = JsonSerializer.Serialize(c);
        const string path = "2.json";
        File.WriteAllText(path, json);

        var employee = c.employees.GroupBy(e => e.position).ToDictionary(g => g.Key, g => g.Count());
        var emplJSON = JsonSerializer.Serialize(employee, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("employee.json", emplJSON);

        var avarage = c.employees.Average(e => e.salary);
        Console.WriteLine($"Средняя ЗП: {avarage}");
    }
}