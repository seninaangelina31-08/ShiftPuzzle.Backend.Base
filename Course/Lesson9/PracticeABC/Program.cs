<<<<<<< HEAD
﻿using System.Diagnostics.Contracts;
using System.Security.Cryptography;

namespace PracticeABC;



class Program
{
    static void Main(string[] args)
    { 
    ////прямое обращение
    ////создания экземпляра класса
        Person[] people = new Person[3];
        people[0] = new Person("John", 30);
        people[1] = new Person("Jane", 25);
        people[2] = new Person("Bob", 40);
        

        Person person = new Person(" ", 0);




        person.name = "Lurri";
        person.age = 20;
        person.Introduce();

        foreach (Person Person in people)
        {
            person.Introduce();

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
>>>>>>> main
        }
    }

    class SimpleDB
    {
        private Dictionary<string, Student> students = new Dictionary<string, Student>();

<<<<<<< HEAD
public class Person
{

    //// поля
 
 
    public string name;
    public int age;
    
    public void Introduce() 
    {
        Console.WriteLine ("Привет, мое имя" + name);
    }
    
    

    public Person ( string name, int age)
    {
        this.name = name;
        this.age = age;
    }


}


public class Employee : Person
{

    //// поля 
   


    public string position;

    public Employee(string name, int age, string position) : base(name, age) 
    {
        this.position = position;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Имя: " + name);
        Console.WriteLine("Возраст: " + age);
        Console.WriteLine("Работа: " + position);
    }

}

=======
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
        }
    }
}
>>>>>>> main
