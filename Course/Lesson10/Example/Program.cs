using System;
<<<<<<< HEAD
using System.IO;

namespace Example;

public class Person
{
    // поля класса
    public string name;
    public int age;

    // Конструктор класса Person для инициализации имени и возраста. Вызывается при создании объекта
    public Person(string name, int age)
    {
        this.name = name;
        SetAge(age); // функция для проверки возраста
    }

    public void SetAge(int newAge)
    {
        if(newAge >= 0)
        {
            this.age = newAge;
        }
        else
        {
            Console.WriteLine("Возраст не может быть отрицательным");
        }
=======
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
>>>>>>> d0b1f546 (feat: added answer to task 10)
    }

    public void Introduce()
    {
<<<<<<< HEAD
        Console.WriteLine($"Привет! Меня зовут {this.name}");
=======
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

        // Implement the code to read data from Markdown file using StreamReader

        return people;
>>>>>>> d0b1f546 (feat: added answer to task 10)
    }
}

public class Employee : Person
{
<<<<<<< HEAD
    public string position;

    public Employee(string name, int age, string position) : base(name, age)
    {
        this.position = position;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание массива из объектов Person
        Person[] people = new Person[3];
        people[0] = new Person("Alice", 28);
        people[1] = new Person("Bob", 35);
        people[2] = new Employee("Charlie", 42, "Product Manager");

        foreach(Person person in people)
        {
            person.Introduce();
        }

        // Работа с файлами
        WriteToFile();
        ReadFromFileAndPrint();
    }

    public static void WriteToFile()
    {
        string[] lines = new string[5];
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = "test";
        }
        File.WriteAllLines("test.txt", lines);
    }

    public static void ReadFromFileAndPrint()
    {
        string[] lines = File.ReadAllLines("test.txt");
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
=======
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

        string filePath = "yamd.md";

        PersonFileService.WritePeopleToFile(people, filePath);

        // Чтение людей из файла
        var peopleFromFile = PersonFileService.ReadPeopleFromFile(filePath);

        foreach (var person in peopleFromFile)
        {
            person.Introduce();

            if (person is Employee employee)
            {
                employee.Work();
            }

            Console.WriteLine();
        }
    }
}
>>>>>>> d0b1f546 (feat: added answer to task 10)
