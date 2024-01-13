using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace L10_PracticeBC;
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

    public string Info()
    {
        return $"{this.Name}, {this.Age}";
    }
}


public class Employee : Person
{
    public string Position { get; set; }


    public Employee(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }

    public new string Info()
    {
        return $"{base.Info()}, {this.Position}";
    }
}


public class PersonFileService
{
    public static void WritePeopleToFile(List<Person> people)
    {   
        string[] info = new string[people.Count];
        for (int i = 0; i < people.Count; i++)
        {
            info[i] = people[i].Info();
        }
        File.WriteAllLines("info.md", info);
    }

    public static Person[] ReadPeopleFromFile()
    {
        string[] infos = File.ReadAllLines("info.md");
        Person[] answer = new Person[infos.Length];
        for (int i = 0; i < infos.Length; i++)
        {
            string[] info = infos[i].Split(separator:", ");
            answer[i] = new Person(info[0], Convert.ToInt16(info[1]));
        }

        return answer;
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
public class FileIO
    {
        public static void WriteToFile(string[] lines, string name)
        {
            File.WriteAllLines(name, lines);
        }

        public static string[] ReadFromFile(string name)
        {
            return File.ReadAllLines(name);
        }
    }
