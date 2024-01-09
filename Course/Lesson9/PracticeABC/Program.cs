using System;
using System.Collections.Generic;

namespace SimpleBD
{     

        class Program
{
    static void Main()
    {
        Person[] people = new Person[4];

        people[0] = new Person("Настя", 17);
        people[1] = new Person("Паша", 12);
        people[2] = new Person("Саша", 13);
        people[2] = new Person("Ашкин", 100);

        foreach (Person person in people)
        {
            person.Introduce();
        }
    }
}

public class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public virtual void Introduce()
    {
        Console.WriteLine($"Привет, мое имя {Name}");
    }

    public void SetAge(int new_age)
    {
        if (new_age >= 0)
        {
            this.Age = new_age;
        }
        else
        {
            Console.WriteLine("Возраст не бывает отрицательный");
        }
    }
}

    class Employee : Person
{
    public string Position;

    public Employee(string name, int age, string position) : base(name, age)
    {
        this.Position = position;
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