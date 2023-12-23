using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;


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


public static class PersonFileService
{
    static void writePersonToFile(string fileName, Person person)
    {
        string jsonString = JsonSerializer.Serialize(person);
        File.WriteAllText(fileName, jsonString);
    }
    static Person readPersonToFile(string fileName)
    {
        string jsonString = File.ReadAllText(filepath);
        return JsonConvert.DeserializeObject<Person>(jsonString);
    }

    static void writePersonToMDFile(string fileName, Person person)
    {
        File.WriteLines(fileName, "Name: " + person.Name);
        File.WriteLines(fileName, "Age: " + person.Age);
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
        //PersonFileService.WritePeopleToFile(people);


        // Reading people from the file
        //var peopleFromFile = PersonFileService.ReadPeopleFromFile();


        foreach (var person in peopleFromFile)
        {
            person.Introduce();
        }
    }
}
