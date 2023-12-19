using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // №A1
            // Закомментил, т.к. при наличии конструктора оно ломается, оставил так, что б код не дублировать
            // Person person = new Person();
            // person.age = 16;
            // person.name = "NoName";
            // №A3
            Person super_person = new Person("RandomName", 18);
            // №A2
            super_person.Introduce();
            // №A4
            Person[] array = {new Person("Саня", 24), new Person("Ваня", 21), new Person("Римас", 23)};
            foreach (Person elem in array) {
                elem.Introduce();
            }
            // B1
            // Вылетит ошибка
            // Person not_yet_born_person = new Person("NoName", -666);
            // C1
            Employee employee = new Employee("Трудяжка", 25, "Босс");
            employee.Introduce();
        }
    }
}

public class Person
{
    // Поля класса (№A1)
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = this.SetAge(age);
    }

    // №A2
    public void Introduce()
    {
        Console.WriteLine($"Привет, мое имя - {this.name}");
    }

    // №B2
    public int SetAge(int age)
    {
        if (age < 0) {
            // Кидаем ошибку, если неверный врзраст
            throw new ArgumentException("Возраст должен быть положительным!!!");
        }
        return age;
    }
}

// №C1
public class Employee : Person
{
    public string position;
    // переопределение конструктора
    public Employee(string name, int age, string position) : base(name, age)
    {
        this.position = position;
    }
}