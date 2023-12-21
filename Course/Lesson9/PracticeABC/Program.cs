using System;
using System.Collections.Generic;

// namespace SimpleBD
// {     
    // class Student
    // {
    //     public string Name { get; set; }
    //     public Dictionary<string, int> Grades { get; set; }
    //     public List<string> Attendance { get; set; }

    //     public Student(string name)
    //     {
    //         Name = name;
    //         Grades = new Dictionary<string, int>();
    //         Attendance = new List<string>();
    //     }

    //     public void AddGrade(string subject, int grade)
    //     {
    //         Grades[subject] = grade;
    //     }

    //     public void AddAttendance(string date)
    //     {
    //         Attendance.Add(date);
    //     }
    // }

    class Person
    {
        public string Name {get; set;}
        public int Age {get; set;}

        public Person(string name = "", int age = 0)
        {
            this.Name = name;
            if (age > 0)
                this.Age = age;
            else
                this.Age = 0;
        }

        public void Introduce()
        {
            Console.WriteLine($"Привет, мое имя {this.Name}!");
        }
    }

    class Employee : Person
    {
        public int Position {get; set;}

        public Employee(string name, int age) {
            this.Name = name;
            if (age > 0)
                this.Age = age;
            else
                this.Age = 0;
        }
    }


    // class SimpleDB
    // {
    //     private Dictionary<string, Student> students = new Dictionary<string, Student>();

    //     public void AddStudent(Student student)
    //     {
    //         students[student.Name] = student;
    //     }

    //     public void RemoveStudent(string name)
    //     {
    //         students.Remove(name);
    //     }

    //     public void ShowStudentInfo(string name)
    //     {
    //         if (students.ContainsKey(name))
    //         {
    //             var student = students[name];
    //             Console.WriteLine($"Name: {student.Name}");
    //             Console.WriteLine("Grades:");
    //             foreach (var grade in student.Grades)
    //             {
    //                 Console.WriteLine($"{grade.Key}: {grade.Value}");
    //             }
    //             Console.WriteLine("Attendance:");
    //             foreach (var date in student.Attendance)
    //             {
    //                 Console.WriteLine(date);
    //             }
    //         }
    //         else
    //         {
    //             Console.WriteLine("Student not found.");
    //         }
    //     }
    // }

    class Program
    {
        static void Main()
        {
            Person pers1 = new Person();
            pers1.Name = "Пешка";
            pers1.Age = 7;
            pers1.Introduce();
            Console.WriteLine($"{pers1.Name} - {pers1.Age} лет");
            Person pers2 = new Person("Юра", -19);
            pers2.Introduce();
            Console.WriteLine($"{pers2.Name} - {pers2.Age} лет");
            Employee empl = new Employee("Григорий", 43);
            empl.Position = 1;
            empl.Introduce();
            Console.WriteLine($"{empl.Name} - {empl.Age} лет - {empl.Position} место");
            Person[] people = {new Person("Пешка 1", 55), new Person("Пешка 2", -5), new Person("Пешка 3", 12)};
            foreach (Person i in people)
            {
                i.Introduce();
            }

        }
    }
// }