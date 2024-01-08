<<<<<<< HEAD
<<<<<<< HEAD
﻿
=======
﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

=======
﻿using System;
using System.Collections.Generic;
using System.IO;
>>>>>>> d0b1f546 (feat: added answer to task 10)

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

<<<<<<< HEAD

=======
>>>>>>> d0b1f546 (feat: added answer to task 10)
    public Person(string name, int age)
    {
        Name = name;
        SetAge(age);
    }

<<<<<<< HEAD

=======
>>>>>>> d0b1f546 (feat: added answer to task 10)
    public void Introduce()
    {
        Console.WriteLine("Hello, my name is " + Name);
    }

<<<<<<< HEAD

=======
>>>>>>> d0b1f546 (feat: added answer to task 10)
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

<<<<<<< HEAD
=======
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
>>>>>>> d0b1f546 (feat: added answer to task 10)

public class Employee : Person
{
    public string Position { get; set; }

<<<<<<< HEAD

=======
>>>>>>> d0b1f546 (feat: added answer to task 10)
    public Employee(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }
<<<<<<< HEAD
}


public class PersonFileService
{
    
}


=======
    
}

>>>>>>> d0b1f546 (feat: added answer to task 10)
public class Program
{
    public static void Main()
    {
<<<<<<< HEAD
        // List of people to write to and read from the file
=======
>>>>>>> d0b1f546 (feat: added answer to task 10)
        var people = new List<Person>
        {
            new Person("Alice", 28),
            new Person("Bob", 35),
            new Employee("Charlie", 42, "Manager")
        };

<<<<<<< HEAD

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
>>>>>>> main
=======
       
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "yamd2.md");

        PersonFileService.WritePeopleToFile(people, filePath);
       
    }
}
>>>>>>> d0b1f546 (feat: added answer to task 10)
