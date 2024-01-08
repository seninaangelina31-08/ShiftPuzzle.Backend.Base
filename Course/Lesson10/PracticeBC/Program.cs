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
    public static void WritePeopleToFile(Person[] people) {
        int i = 0;
        string[] lines = new string[people.Length*2];
        foreach (Person person in people) {
            lines[i] = "Name: " + person.Name;
            lines[i+1] = "Age: " + person.Age;
            i += 2;
        }
        File.WriteAllLines("person.txt", lines);
    }

    public static Person[] ReadPeopleFromFile() {
        string[] lines = File.ReadAllLines("person.txt");
        Person[] people = new Person[lines.Length];
        for (int i = 0; i < lines.Length/2; i+=2) {
            string name = lines[i].Substring(6);
            int age = int.Parse(lines[i+1].Substring(5));
            people[i] = new Person(name, age);
        }
        return people;
    }
}


public class Program
{
    public static void Main()
    {
        // List of people to write to and read from the file
        Person[] people = new Person[2];
        {
            new Person("Alice", 28);
            new Person("Bob", 35);
        }


        // Writing people to the file
        PersonFileService.WritePeopleToFile(people);


        // Reading people from the file
        Person[] peopleFromFile = PersonFileService.ReadPeopleFromFile();
        
        
        foreach (Person person in peopleFromFile)
        {
            person.Introduce();
        }
    }
}
