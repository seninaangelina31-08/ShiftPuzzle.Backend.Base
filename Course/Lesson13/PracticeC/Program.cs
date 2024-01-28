//*Часть С:*
//1. Добавь 3 фильма из кинопоиска и сохрани в файл 
//2. Добавь должность программиста с ЗП 250.000. 
//Создай новый JSON который хранит количество работников по каждой специальности. Запись в файл должно прлоисходить только через приложение.
//И сделай анализ по ЗП в компании - нужно вывести среднюю ЗП.
//3. Напиши систему которая будет менять статус и добавлять новых сотрудников
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PracticeC;
    public class Movie
    {
        public string title { get; set; }
        public int year { get; set; }
        public Director director { get; set; }
        public List<CastMember> cast { get; set; }
        public List<string> genres { get; set; }
        public Ratings ratings { get; set; }

        public class Director
        {
            public string name { get; set; }
            public DateTime born { get; set; }
        }

        public class CastMember
        {
            public string name { get; set; }
            public string role { get; set; }
        }

        public class Ratings
        {
            public double IMDb { get; set; }
            public string RottenTomatoes { get; set; }
        }

        public static Movie FromJson(string json)
        {
            return JsonSerializer.Deserialize<Movie>(json);
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public void AddCastMember(string name, string role)
        {
            if (cast == null)
            {
                cast = new List<CastMember>();
            }
            cast.Add(new CastMember { name = name, role = role });
        }
    }

    [System.Serializable]public class Company
    {
        public string companyName { get; set; }
        public List<Employee> employees { get; set; }
        public Location location { get; set; }

        public class Employee
        {
            public int id { get; set; }
            public string name { get; set; }
            public string position { get; set; }
            public List<string> skills { get; set; }
            public int salary { get; set; }
        }

        public class Location
        {
            public string city { get; set; }
            public string address { get; set; }
        }

        public static Company FromJson(string json)
        {
            return JsonSerializer.Deserialize<Company>(json);
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public void AddEmployee(int id, string name, string position, List<string> skills, int salary)
        {
            if (employees == null)
            {
                employees = new List<Employee>();
            }
            employees.Add(new Employee
            {
                id = id,
                name = name,
                position = position,
                skills = skills,
                salary = salary
            });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1. Добавь 3 фильма из кинопоиска и сохрани в файл 
            //2. Добавь должность программиста с ЗП 250.000. 

            //Создай новый JSON который хранит количество работников по каждой специальности. Запись в файл должно происходить только через приложение.

            //И сделай анализ по ЗП в компании - нужно вывести среднюю ЗП.

            //3. Напиши систему которая будет менять статус и добавлять новых сотрудников
            const string path = "2.json";
            string js = File.ReadAllText(path);
            Company company = JsonSerializer.Deserialize<Company>(js);

            company.AddEmployee(464, "Леша Алексеев", "Программист", new List<string> { "Программирует программы" }, 250000);
            foreach (var employee in company.employees)
            {
                Console.WriteLine($"ID: {employee.id}, Name: {employee.name}, Position: {employee.position}, Skills: {string.Join(", ", employee.skills)}, Salary: {employee.salary}");
            }
            double zap = 0;
            foreach (var employee in company.employees)
                {
                    zap += employee.salary;
                }
            double srzap = zap / company.employees.Count;

            Console.WriteLine($"Средняя зарплата в компании: {srzap}");
            // Подсчет количества работников по каждой специальности
            Dictionary<string, int> podschet = new Dictionary<string, int>();
            foreach (var employee in company.employees)
            {
                if (podschet.ContainsKey(employee.position))
                {
                    podschet[employee.position]++;
                }
                else
                {
                    podschet[employee.position] = 1;
                }
            }
            
            string emplcount = JsonSerializer.Serialize(podschet);
            File.WriteAllText("emplcount.json", emplcount);

        }
    }
