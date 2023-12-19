using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // №1
            // Закомментил, т.к. при наличии конструктора оно ломается, оставил так, что б код не дублировать
            // Person person = new Person();
            // person.age = 16;
            // person.name = "NoName";
            // №3
            Person super_person = new Person("RandomName", 18);
            // №2
            super_person.Introduce();
            // №4
            Person[] array = {new Person("Саня", 24), new Person("Ваня", 21), new Person("Римас", 23)};
            foreach (Person elem in array) {
                elem.Introduce();
            }
        }
    }
}

public class Person
{
    // Поля класса (№1)
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // №2
    public void Introduce()
    {
        Console.WriteLine($"Привет, мое имя - {this.name}");
    }
}