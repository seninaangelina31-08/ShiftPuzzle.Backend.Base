using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CompanyAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyJson = File.ReadAllText("2.json");
            var company = JsonSerializer.Deserialize<Company>(companyJson);
            company.Employees.Add(new Employee
            {
                Id = 1003,
                Name = "Иван Петров",
                Position = "Программист",
                Skills = new List<string> { "Программирование", "Разработка", "Тестирование" },
                Salary = 250000
            });
            string jsonString = JsonSerializer.Serialize(company, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("2_new.json", jsonString);

            // Создаем новый JSON для хранения количества работников по каждой специальности
            // var employeesByPosition = company.Employees.GroupBy(e => e.Position)
            //                                           .ToDictionary(g => g.Key, g => g.Count());
            // var employeesByPositionJson = JsonSerializer.Serialize(employeesByPosition, new JsonSerializerOptions { WriteIndented = true });
            // File.WriteAllText("employeesByPosition.json", employeesByPositionJson);

            // Анализ по ЗП в компании - выводим среднюю ЗП
            // var averageSalary = company.Employees.Average(e => e.Salary);
            // Console.WriteLine($"Средняя ЗП в компании: {averageSalary}");

            // Выводим информацию о компании
            // Console.WriteLine(updatedCompanyJson);
        }
    }

    public class Company
    {
        public string CompanyName { get; set; }
        public List<Employee> Employees { get; set; }
        public Location Location { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public List<string> Skills { get; set; }
        public int Salary { get; set; }
    }

    public class Location
    {
        public string City { get; set; }
        public string Address { get; set; }
    }
}
