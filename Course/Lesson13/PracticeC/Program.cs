using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace PracticeC
{
    [Serializable]
    public class Director
    {
        public string Name { get; set; }
        public string Born { get; set; }
    }

    [Serializable]
    public class Actor
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }

    [Serializable]
    public class Ratings
    {
        public double IMDb { get; set; }
        public string RottenTomatoes { get; set; }
    }

    [Serializable]
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Director Director { get; set; }
        public List<Actor> Cast { get; set; }
        public List<string> Genres { get; set; }
        public Ratings Ratings { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public List<string> Skills { get; set; }
        public decimal Salary { get; set; }
    }

    public class Location
    {
        public string City { get; set; }
        public string Address { get; set; }
    }

    public class CompanyData
    {
        public string CompanyName { get; set; }
        public List<Employee> Employees { get; set; }
        public Location Location { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Создание списка фильмов
            List<Movie> movies = new List<Movie>
            {
                new Movie
                {
                    Title = "Назад в будущее",
                    Year = 1985,
                    Director = new Director
                    {
                        Name = "Роберт Земекис",
                        Born = "1952-05-14"
                    },
                    Cast = new List<Actor>
                    {
                        new Actor
                        {
                            Name = "Майкл Дж. Фокс",
                            Role = "Марти МакФлай"
                        },
                        new Actor
                        {
                            Name = "Кристофер Ллойд",
                            Role = "Доктор Эмметт Браун"
                        }
                    },
                    Genres = new List<string>
                    {
                        "Приключения",
                        "Комедия",
                        "Научная фантастика"
                    },
                    Ratings = new Ratings
                    {
                        IMDb = 8.5,
                        RottenTomatoes = "96%"
                    }
                },

                new Movie
                {
                    Title = "Дом Дракона",
                    Year = 2022,
                    Director = new Director
                    {
                        Name = "Клер Килнер",
                        Born = "1972-05-14"
                    },
                    Cast = new List<Actor>
                    {
                        new Actor
                        {
                            Name = "Пэдди Консидайн",
                            Role = "King Viserys I Targaryen"
                        },
                        new Actor
                        {
                            Name = "Мэтт Смит",
                            Role = "Prince Daemon Targaryen"
                        }
                    },
                    Genres = new List<string>
                    {
                        "Фэнтези",
                        "Боевик",
                        "Драма"
                    },
                    Ratings = new Ratings
                    {
                        IMDb = 8.1,
                        RottenTomatoes = "97%"
                    }
                },

                new Movie
                {
                    Title = "Однажды в сказке",
                    Year = 2011,
                    Director = new Director
                    {
                        Name = "Ральф Хемекер",
                        Born = "1962-05-14"
                    },
                    Cast = new List<Actor>
                    {
                        new Actor
                        {
                            Name = "Дженнифер Моррисон",
                            Role = "Эмма Свон"
                        },
                        new Actor
                        {
                            Name = "Лана Паррия",
                            Role = "Регина Миллс"
                        }
                    },
                    Genres = new List<string>
                    {
                        "Фэнтези",
                        "Мелодрама",
                        "Приключения"
                    },
                    Ratings = new Ratings
                    {
                        IMDb = 8.0,
                        RottenTomatoes = "90%"
                    }
                }
            };

            string jsonString = JsonSerializer.Serialize(movies, new JsonSerializerOptions { WriteIndented = true });
            string filePath = "файл1.json";
            File.WriteAllText(filePath, jsonString);

            Console.WriteLine($"Фильмы сохранены в файл: {filePath}");




            //Загрузка данных из файла
            string jsonFilePath = "2.json";
            string jsonString2 = File.ReadAllText(jsonFilePath);
            CompanyData companyData = JsonSerializer.Deserialize<CompanyData>(jsonString2);

            //Добавление нового сотрудника
            Employee newEmployee = new Employee
            {
                Id = 1003,
                Name = "Иван Петров",
                Position = "Программист",
                Skills = new List<string> { "Разработка", "Отладка", "Тестирование" },
                Salary = 250000
            };
            companyData.Employees.Add(newEmployee);

            //Запись данных в файл
            string updatedJsonString2 = JsonSerializer.Serialize(companyData, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonFilePath, updatedJsonString2);

            //Анализ ЗП в компании
            decimal averageSalary = companyData.Employees.Average(e => e.Salary);
            Console.WriteLine("Средняя ЗП в компании: " + averageSalary);

            Console.ReadLine();
        }
    }
}