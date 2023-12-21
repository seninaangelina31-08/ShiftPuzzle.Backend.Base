using System;
using System.IO;

namespace task
{
    public class Person
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            SetAge(age);
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
        }

        public void Introduce()
        {
            Console.WriteLine($"Привет! Меня зовут {this.name}");
        }
    }

    public class Employee : Person
    {
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
            Employee[] people = new Employee[3];
            people[0] = new Employee("Alice", 28,"nobody");
            people[1] = new Employee("Bob", 35,"nobody");
            people[2] = new Employee("Charlie", 42, "Product Manager");
            WriteToFile(people);
            ReadFromFileAndPrint();
        }
        public static void WriteToFile(Employee[] people)
        {
            using (StreamWriter file = new StreamWriter("test.txt"))
            {
                foreach (Employee person in people)
                {
                    file.WriteLine($"{person.name},{person.age},{person.position}");
                }
            }
        }
        public static void ReadFromFileAndPrint()
        {
            string[] lines = File.ReadAllLines("test.txt");
            foreach(string line in lines)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                int age = int.Parse(parts[1]);
                string position = parts[2];
                Console.WriteLine($"{name} {age} {position}");
            }
        }
    }
}
