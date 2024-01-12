<<<<<<< HEAD
﻿// Практика А:
// Task1


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
     void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Эвелина";
        person.Age = 17;

        Console.WriteLine("Имя: " + person.Name);
        Console.WriteLine("Возраст: " + person.Age);
=======
﻿using System;
using System.Collections.Generic;

namespace SimpleBD
{     
    class Student
    {
        public string Name { get; set; }
        public Dictionary<string, int> Grades { get; set; }
        public List<string> Attendance { get; set; }

        public Student(string name)
        {
            Name = name;
            Grades = new Dictionary<string, int>();
            Attendance = new List<string>();
        }

        public void AddGrade(string subject, int grade)
        {
            Grades[subject] = grade;
        }

        public void AddAttendance(string date)
        {
            Attendance.Add(date);
        }
>>>>>>> main
    }

<<<<<<< HEAD
// Task2
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine("Привет, мое имя " + Name);
    }
}

class Program
{
    void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Эвелина";
        person.Age = 17;

        person.Introduce();
    }
}

// Task3
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine("Привет, мое имя " + Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Эвелина", 17);
        person.Introduce();
    }
}

// Task4
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine("Привет, мое имя " + Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[]
        {
            new Person("Эвелина", 17),
            new Person("Анна", 34),
            new Person("Сергей", 20)
        };

        foreach (Person person in people)
        {
            person.Introduce();
=======
    class SimpleDB
    {
        private Dictionary<string, Student> students = new Dictionary<string, Student>();

        public void AddStudent(Student student)
        {
            students[student.Name] = student;
        }

        public void RemoveStudent(string name)
        {
            students.Remove(name);
        }

        public void ShowStudentInfo(string name)
        {
            if (students.ContainsKey(name))
            {
                var student = students[name];
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine("Grades:");
                foreach (var grade in student.Grades)
                {
                    Console.WriteLine($"{grade.Key}: {grade.Value}");
                }
                Console.WriteLine("Attendance:");
                foreach (var date in student.Attendance)
                {
                    Console.WriteLine(date);
                }
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello world!")
>>>>>>> main
        }
    }
}