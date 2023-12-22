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
    public static void WritePeopleToFile(List<Person> a)
    {
        string[] b = (a.Select(x => (x.Name) + "," + Convert.ToString(x.Age))).ToArray();
        // string[] b = new string[3];
        // for (int i = 0; i < b.Length; i++)
        // {
        //     b[i] = a[i].Name + "," + Convert.ToString(a[i].Age);
        // }
        // File.WriteAllLines("People.txt", b);
        File.WriteAllLines("People.md", b);
    }

    public static List<Person> ReadPeopleFromFile()
    {
        string[] lines = File.ReadAllLines("People.md");
        List<Person> lst = new List<Person>{};
        foreach (string line in lines)
        {
            lst.Add(new Person(line.Split(',')[0],Convert.ToInt16(line.Split(',')[1])));
        }
        return lst;
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
