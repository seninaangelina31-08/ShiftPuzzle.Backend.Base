namespace Practice;

using System;

class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Introduce()
    {
        Console.WriteLine("Привет, мое имя {0}", name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[3];

        people[0] = new Person("Гриша", 10);
        people[1] = new Person("Петя", 20);
        people[2] = new Person("Алексей", 30);

        foreach (Person person in people)
        {
            person.Introduce();
        }

        Console.ReadKey();
    }
}