<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace Practic;
using System;
=======
﻿using System;
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
>>>>>>> main

=======
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
public class Student
{
    public string Name { get; set; }
    public Dictionary<string, int> Grades { get; set; }
    public Dictionary<string, bool> Attendance { get; set; }

    public Student(string name)
    {
        Name = name;
        Grades = new Dictionary<string, int>();
        Attendance = new Dictionary<string, bool>();
    }

    public void AddGrade()
    {
        Console.Write("Vvedite predmet: ");
        string subject = Console.ReadLine();

        Console.Write("Vvedite ocenku: ");
<<<<<<< HEAD
<<<<<<< HEAD
        if (int.TryParse(Console.ReadLine(), out var grade))
=======
        if (int.TryParse(Console.ReadLine(), out int grade))
>>>>>>> main
=======
        if (int.TryParse(Console.ReadLine(), out int grade))
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
        {
            Grades[subject] = grade;
            Console.WriteLine($"Ocenka {grade} po predmetu '{subject}' dobavlena.");
        }
        else
        {
            Console.WriteLine("Nekorrektnyj vvod. Ocenka ne dobavlena.");
        }
    }

    public void AddAttendance()
    {
        Console.WriteLine("Vvedite dannye o posechaemosti (format: 'data=true/false'):");
        string input = Console.ReadLine();
        var parts = input.Split('=');
        if (parts.Length == 2 && DateTime.TryParse(parts[0], out DateTime date))
        {
            bool wasPresent = parts[1].ToLower() == "true";
            Attendance[date.ToLongDateString()] = wasPresent;
            Console.WriteLine("Dannye o posechaemosti dobavleny.");
        }
        else
        {
            Console.WriteLine("Nekorrektnyj vvod. Dannye o posechaemosti ne dobavleny.");
        }
    }
}


public class StudetnFileService
{
<<<<<<< HEAD
<<<<<<< HEAD
    
=======
>>>>>>> main
=======
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
    public const string FilePath = "students.txt";
    public Dictionary<string, Student> students = new Dictionary<string, Student>();

    public StudetnFileService(Dictionary<string, Student> data)
    {
        students = data;
    }

    public  void SaveToFile(string filePath=FilePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            foreach (var student in students.Values)
            {
                string grades = string.Join(";", student.Grades.Select(g => $"{g.Key}:{g.Value}"));
                string attendance = string.Join(";", student.Attendance.Select(a => $"{a.Key}:{a.Value}"));
                writer.WriteLine($"{student.Name},{grades},{attendance}");
            }
        }
    }
 public void LoadFromFile(string filePath = FilePath)
{
    if (!File.Exists(filePath))
    {
<<<<<<< HEAD
<<<<<<< HEAD
        Console.WriteLine(".");
=======
        Console.WriteLine("���� �� ������.");
>>>>>>> main
=======
        Console.WriteLine("���� �� ������.");
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
        return;
    }

    using (var reader = new StreamReader(filePath))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split(',');
            if (parts.Length < 3)
            {
<<<<<<< HEAD
<<<<<<< HEAD
                continue; 
=======
                continue; // ������� � ��������� ������, ���� ������ �������
>>>>>>> main
=======
                continue; 
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
            }

            var studentName = parts[0];
            var student = new Student(studentName);

<<<<<<< HEAD
<<<<<<< HEAD
         
=======
            // ������ ������
>>>>>>> main
=======
         
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
            var gradesPart = parts[1].Split(':');
            if (gradesPart.Length == 2 && int.TryParse(gradesPart[1], out int grade))
            {
                student.Grades.Add(gradesPart[0], grade);
            }

<<<<<<< HEAD
<<<<<<< HEAD
=======
            // ������ ������ � ������������
>>>>>>> main
=======
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
            var attendancePart = parts[2].Split(':');
            if (attendancePart.Length == 2 && DateTime.TryParse(attendancePart[0], out DateTime date) && bool.TryParse(attendancePart[1], out bool wasPresent))
            {
                student.Attendance.Add(date.ToLongDateString(), wasPresent);
            }

            students.Add(student.Name, student);
        }
    }
}

     
}

class SimpleDB
{
    private StudetnFileService fileService;
    public SimpleDB()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        //сохраняем файл
        fileService = new StudetnFileService(students);
        
=======
        fileService = new StudetnFileService(students);
        LoadDB();
>>>>>>> main
=======
        //сохраняем файл
        fileService = new StudetnFileService(students);
        fileService.LoadDB();
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
    }
    public  Dictionary<string, Student> students = new Dictionary<string, Student>();

    public void SaveDB()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        fileService.SaveToFile();
=======
>>>>>>> main
=======
        fileService.SaveToFile();
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
        Console.WriteLine("Funcional ne realizovan...");
        //  practice B;
    }

    public void LoadDB()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        //загрузка файла
        //просто вызвать методы
        fileService.LoadFromFile();
=======
>>>>>>> main
=======
        //загрузка файла
        //просто вызвать методы
        FilePath.LoadFromFile();
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
        Console.WriteLine("Funcional ne realizovan...");
        //  practice B;
    }
    public void AddStudent(string name)
    {
<<<<<<< HEAD
<<<<<<< HEAD
        students.Add(name, new Student(name));
=======
>>>>>>> main
=======
        students.Add(name, new Student(name));
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
        Console.WriteLine("Funcional ne realizovan...");
         //  practice A;
    }

    public void RemoveStudent(string name)
    {
<<<<<<< HEAD
<<<<<<< HEAD
        students.Remove(name); 
=======
>>>>>>> main
=======
        students.Remove(name); 
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
        Console.WriteLine("Funcional ne realizovan...");
         //  practice A;
    }

    public void ShowStudentInfo(string name)
<<<<<<< HEAD
<<<<<<< HEAD
{
    foreach (var student in students)
    {
        if (student.Name == name)
        {
            Console.WriteLine("Имя: " + student.Value.Name);

            string[] items = student.Grades.Split(',');

            string subject = items[0];
            int value = int.Parse(items[1]);
            DateTime date = DateTime.ParseExact(items[2], "dd MMMM yyyy", CultureInfo.InvariantCulture);
            bool flag = bool.Parse(items[3]);

            Console.WriteLine("Предмет: " + subject);
            Console.WriteLine("Значение: " + value);
            Console.WriteLine("Дата: " + date.ToShortDateString());
            Console.WriteLine("Флаг: " + flag);

            Console.WriteLine("Информация успешно показана.");
            return;
        }
    }
}
=======
    {
=======
    {
        
        foreach (var student in students)
        {
            if (student.Name == name)
            {
                Console.WriteLine("Имя: " + student.Name);

                // Разделить строку с пунктами на отдельные значения
                string[] items = student.Items.Split(',');

                // Получить значения пунктов
                string subject = items[0];
                int value = int.Parse(items[1]);
                DateTime date = DateTime.ParseExact(items[2], "dd MMMM yyyy", CultureInfo.InvariantCulture);
                bool flag = bool.Parse(items[3]);

                Console.WriteLine("Предмет: " + subject);
                Console.WriteLine("Значение: " + value);
                Console.WriteLine("Дата: " + date.ToShortDateString());
                Console.WriteLine("Флаг: " + flag);

                Console.WriteLine("Информация успешно показана.");
                return;
            }
        }

>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
        Console.WriteLine("Funcional ne realizovan...");
         //  practice A;
    }

<<<<<<< HEAD
>>>>>>> main
=======
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
    public Student GetStudent(string name)
    {
        if (students.TryGetValue(name, out var student))
        {
            return student;
        }
        else
        {
            Console.WriteLine("Student ne najden.");
            return null;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var db = new SimpleDB(); 
        while (true)
        {
            Console.WriteLine("\n1. Dobavit' srudenta\n2. Pokazat studenta\n3. Udalit' studenta\n4. Dobavit' ocenku\n5. Dobavit' poseshaemost'\n6 Soxranit' bazu dannix\n0. Vixod");
            Console.Write("Vibor: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Nepravilno. Eshe raz.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Vvedite imia studenta: ");
                    string name = Console.ReadLine();
                    db.AddStudent(name);
                    break;
                case 2:
                    Console.Write("Vvedite imia studenta (info): ");
                    name = Console.ReadLine();
                    db.ShowStudentInfo(name);
                    break;
                case 3:
                    Console.Write("Vvedite imia studenta dlia udalenia: ");
                    name = Console.ReadLine();
                    db.RemoveStudent(name);
                    break;
                case 4:
                    Console.Write("Vvedite imia studenta (ocenka'): ");
                    name = Console.ReadLine();
                    Student student = db.GetStudent(name);
                    student?.AddGrade();
                    break;
                case 5:
                    Console.Write("Vvedite imia studenta (poseshaemost'): ");
                    name = Console.ReadLine();
                    student = db.GetStudent(name);
                    student?.AddAttendance();
                    break;
                case 6:
                    Console.WriteLine("Soxraneno...");
                    db.SaveDB();
                    break;

                case 0:
                    return;
                default:
                    Console.WriteLine("Nepravilno. Eshe raz.");
                    break;
            }
        }
    }
}
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> main
=======
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
