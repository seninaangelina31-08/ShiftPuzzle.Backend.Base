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
        Console.WriteLine("Hello, my name is " + Name+"I'm "+Age.ToString());
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
    static string from_file = "People.txt";
    static string to_file = "Text.txt";

    public static void WritePeopleToFile(List<Person> people)
    {
        List<Person> c = people;
        string[] lines = new string[c.Count];
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = $"My name {c[i].Name}, I'm {c[i].Age} years old";
        }
        File.WriteAllLines(to_file, lines);
    }

    public static List<Person> ReadPeopleFromFile()
    {
        string[] lines = File.ReadAllLines(from_file);
        List<Person> people = new List<Person>();
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            Person copy = new Person(parts[0], Int32.Parse(parts[1]));
            people.Add(copy);
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



        PersonFileService.WritePeopleToFile(people);


        var peopleFromFile = PersonFileService.ReadPeopleFromFile();


        foreach (var person in peopleFromFile)
        {
            person.Introduce();
        }
    }
}
