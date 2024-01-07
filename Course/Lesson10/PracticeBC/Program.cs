using System;
using System.Collections.Generic;
using System.IO;
//using Newtonsoft.Json;


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
    public List<Person> People;
    public PersonFileService(List<Person> people)
    {
        this.People = people;
    }

    public static void WritePeopleToFile(List<Person> people)
    {   
        string[] lines = new string[5];
    
        int c = 0;
        foreach (var ar in people)
        {
            if (ar.GetType() == typeof(Employee))
            {
                lines[c] = $"{ar.Name} {ar.Age}";
            }

            if (ar.GetType() == typeof(Person))
            {
                lines[c] = $"{ar.Name} {ar.Age}";
            }

            c++;
        }


        File.WriteAllLines("test.txt", lines);
    }
    public static Person[] ReadPeopleFromFile(string name_file)
    {
        string[] lines = File.ReadAllLines(name_file);

        Person[] ans = new Person[lines.Length-2];


        for (int i = 0; i < lines.Length-2; i++)
        {
            string[] line = lines[i].Split(' ');
            ans[i] = new Person(line[0], Convert.ToInt32(line[1]));
        }

        return ans;
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
        var peopleFromFile = PersonFileService.ReadPeopleFromFile("test.txt");
        
        foreach (var person in peopleFromFile)
        {
            person.Introduce();
        }
    }
}
