using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace PracticeC2{
    class Program
    {

    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public List<string> skills { get; set; }
        public int salary { get; set; }

        public Employee(int id, string name, string position, List<string> skills, int salary)
        {
            this.id = id;
            this.name = name;
            this.position = position;
            this.skills = skills;
            this.salary = salary;
        }
    }

    public class Location
    {
        public string city { get; set; }
        public string address { get; set; }

        public Location(string city, string address)
        {
            this.city = city;
            this.address = address;
        }
    }

    public class Company
    {
        public string companyName { get; set; }
        public List<Employee> employees { get; set; }
        public Location location { get; set; }

        public Company(string companyName, List<Employee> employees, Location location)
        {
            this.companyName = companyName;
            this.employees = employees;
            this.location = location;
        }
    }


        static void Main(string[] args)
        {
            string companyJson = File.ReadAllText("2.json");

            Company company = JsonSerializer.Deserialize<Company>(companyJson);
            List<string> skills = new List<string> { "Программирование", "Разработка", "Тестирование" };
            Employee emp4 = new Employee(11, "Иван Петров", "Программист", skills, 250000);
            company.employees.Add(emp4);
            string jsonString = JsonSerializer.Serialize(company, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("2copy.json", jsonString);
        }
    }
}
