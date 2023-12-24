using System;
using System.Collections.Generic;
using System.IO;


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }


    public Person(string name, int age)
    {
        this.Name = name;
        SetAge(age);
    }


    public void Introduce()
    {
        Console.WriteLine("Hello, my name is " + this.Name);
    }


    public void SetAge(int newAge)
    {
        if (newAge >= 0)
        {
            this.Age = newAge;
        }
        else
        {
            Console.WriteLine("Age cannot be negative.");
        }
    }

    public virtual string Info()
    {
        return $"{this.Name},{this.Age}";
    }
}


public class Employee : Person
{
    public string Position { get; set; }


    public Employee(string name, int age, string position) : base(name, age)
    {
        this.Position = position;
    }
    public override string Info()
    {
        return $"{base.Info()},{this.Position}";
    }
}


public class PersonFileService
{
   public static void WritePeopleToFile(Person[] people)
   {
        string[] array = new string[people.Length];
        for (int i = 0; i < array.Length; i++)
        {
        
            array[i] = people[i].Info();
        }
        File.WriteAllLines("People.txt", array);
   } 

   public static Person[] ReadPeopleFromFile(string loc)
   {
        string[] array = File.ReadAllLines("People.txt");
        int i = 0;
        Person[] array_to_return = new Person[array.Length];
        foreach (string el in array)
        {
            string[] person_info = el.Split(",");
            if (person_info.Length == 2)
            {
                array_to_return[i] = new Person(person_info[0], Convert.ToInt32(person_info[1]));
                i++;
            }
            else
            {
                array_to_return[i] = new Employee(person_info[0], Convert.ToInt32(person_info[1]), person_info[2]);
                i++;
            }

        }
        return array_to_return;
   }
}



public class Program
{

    public static void Markdown(string[] array)
    {
        File.WriteAllLines("Markdown.md", array);
    }
    public static void Main()
    {
        // List of people to write to and read from the file
        Person[] people = new Person[3];
        people[0] = new Person("Alice", 28);
        people[1] = new Person("Bob", 35);
        people[2] = new Employee("Charlie", 42, "Manager");


        // Writing people to the file
        PersonFileService.WritePeopleToFile(people);


        // Reading people from the file
        Person[] peopleFromFile = PersonFileService.ReadPeopleFromFile("People.txt");
        
        
        foreach (Person person in peopleFromFile)
        {
            person.Introduce();
        }

        string[] md_array = {
            "# Абоба",
            "## Абоба_Two",
            "### Абоба_Three",
            "* Список1",
            "* Список2",
            "    + Список_level2_1",
            "    + Список_level2_2"
            
            };
        Markdown(md_array);
    }
}
