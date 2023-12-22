using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

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
        Console.WriteLine("Hello, my name is " + Name);
    }

    public void SetAge(int newAge)
    {
        if (newAge >= 0)
        {
            Age = newAge;
        }
        else
        {
            Console.WriteLine("Age cannot be negative.");
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
    public static void WritePeopleToFile(List<Person> people)
    {
        List<string> lines = new List<string>();

        foreach (var person in people)
        {
            string line = $"Name: {person.Name}, Age: {person.Age}";

            if (person is Employee)
            {
                line += $", Position: {(person as Employee).Position}";
            }

            lines.Add(line);
        }

        File.WriteAllLines("people.md", lines);
    }

    public static List<Person> ReadPeopleFromFile()
    {
        List<Person> people = new List<Person>();
        string[] lines = File.ReadAllLines("people.md");

        foreach (var line in lines)
        {
            string[] parts = line.Split(", ");
            string name = parts[0].Split(": ")[1];
            int age = int.Parse(parts[1].Split(": ")[1]);

            if (parts.Length == 3)
            {
                string position = parts[2].Split(": ")[1];
                people.Add(new Employee(name, age, position));
            }
            else
            {
                people.Add(new Person(name, age));
            }
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
            new Person("Alice", 28),
            new Person("Bob", 35),
            new Employee("Charlie", 42, "Manager")
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
