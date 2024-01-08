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

public class PersonFileService
{
    public static void WritePeopleToFile(List<Person> people, string filePath)
    {
        List<string> lines = new List<string>
        {
            "# People"
        };

        foreach (var person in people)
        {
            lines.Add($"- Name: {person.Name}");
            lines.Add($"  Age: {person.Age}");

            if (person is Employee employee)
            {
                lines.Add($"  Position: {employee.Position}");
            }

            lines.Add("");
        }

        File.WriteAllLines(filePath, lines);
    }

    public static List<Person> ReadPeopleFromFile(string filePath)
    {
        List<Person> people = new List<Person>();


        return people;
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

public class Program
{
    public static void Main()
    {
        var people = new List<Person>
        {
            new Person("Alice", 28),
            new Person("Bob", 35),
            new Employee("Charlie", 42, "Manager")
        };

       
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "yamd2.md");

        PersonFileService.WritePeopleToFile(people, filePath);
       
    }
}