namespace Practice;

using System;

public class Person
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

    static public void AgeLie(int age){
        if (age < 0){
            System.Console.WriteLine("Возраст не может быть отрицательным");
        }
    }
   
}
public class Employee : Person{
    public string position;

    public Employee(string name, int age, string position) : base(name, age){}
}

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[3];
        Person person1 = new Person("Витя", -1);

        people[0] = new Person("Гриша", 10);
        people[1] = new Person("Петя", 20);
        people[2] = new Person("Алексей", 30);

        foreach (Person person in people)
        {
            person.Introduce();
        }
        Person.AgeLie(person1.age);

    }
}