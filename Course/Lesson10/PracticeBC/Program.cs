using System;
using System.Collections.Generic;
using System.IO;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        SetAge(age);
    }

    public void Introduce()
    {
        Console.WriteLine("Привет, меня зовут " + Name);
    }

    public void SetAge(int newAge)
    {
        if (newAge >= 0)
        {
            Age = newAge;
        }
        else
        {
            Console.WriteLine("");
        }
    }
}

public class Employee : Person
{
    public string Position { get; set; }

    public Employee(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }
}

public class PersonFileService
{
    private const string FilePath = "people.md";

    public static void WritePeopleToFile(List<Person> people)
    {
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            foreach (var person in people)
            {
                writer.WriteLine($"## {person.Name}");
                writer.WriteLine($"- Лет: {person.Age}");
                if (person is Employee employee)
                {
                    writer.WriteLine($"- Позиция: {employee.Position}");
                }
                writer.WriteLine();
            }
        }
        Console.WriteLine("Список людей создан");
    }

    public static List<Person> ReadPeopleFromFile()
    {
        List<Person> people = new List<Person>();
        if (File.Exists(FilePath))
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                string name = null;
                int age = 0;
                string position = null;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("## "))
                    {
                        name = line.Substring(3);
                    }
                    else if (line.StartsWith("- Лет: "))
                    {
                        int.TryParse(line.Substring(6), out age);
                    }
                    else if (line.StartsWith("- Позиция: "))
                    {
                        position = line.Substring(12);
                        people.Add(new Employee(name, age, position));
                    }
                }
            }
            Console.WriteLine("Файл прочитан.");
        }
        else
        {
            Console.WriteLine("Файл не прочитан ошибка в коде");
        }

        return people;
    }
}

public class Program
{
    public static void Main()
    {
        // List of people to write to and read from the file
        var people = new List<Person>
        {
            new Person("Алиса", 28),
            new Person("Андрей", 35),
            new Employee("Акшин", 23, "Преподаватель")
        };

        // Writing people to the file
        PersonFileService.WritePeopleToFile(people);

        // Reading people from the file
        var peopleFromFile = PersonFileService.ReadPeopleFromFile();

        foreach (var person in peopleFromFile)
        {
            person.Introduce();
        }
    }
}