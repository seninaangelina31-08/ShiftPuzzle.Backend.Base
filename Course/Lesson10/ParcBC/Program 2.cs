using System;
using System.Collections.Generic;
using System.IO;
// using Newtonsoft.Json;


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
    public static void WritePeopleToFile(Person people)
    {   
        string[] lines = new string[1];
        lines[0] = people.Name + ", " + people.Age;
        File.WriteAllLines("test.txt", lines);
    }
    public static Person[] ReadPeopleFromFile()
    {
        string[] lines = File.ReadAllLines("test.txt");
        Person[] peoples = new Person[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] per = line.Split(',');
            peoples[i] = new Person(per[0], Int32.Parse(per[1]));
        }
        return peoples;
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
        // PersonFileService.WritePeopleToFile(people[0]);


        // Reading people from the file
        var peopleFromFile = PersonFileService.ReadPeopleFromFile();
        
        
        foreach (var person in peopleFromFile)
        {
            person.Introduce();
        }
    }
}
