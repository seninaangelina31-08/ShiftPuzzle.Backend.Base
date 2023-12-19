namespace ABC;

class Class1
{
    static void Main(string[] args)
    {
        Person p1 = new Person("Петя", 10);
        Person p2 = new Person("Ваня", 30);
        Person p3 = new Person("Катя", 20);

        Person[] people = { p1, p2, p3 };

        foreach (Person p in people)
        {
            p.Introduce();
        }

        p1.SetAge(-10);
    }
}
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
        Console.WriteLine("Привет, моё имя " + name);
    }

    public void SetAge(int age)
    {
        if (age >= 0)
        {
            this.age = age;
        }
        else
        {
            Console.WriteLine("Возраст не может быть отрицательным.");
        }
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