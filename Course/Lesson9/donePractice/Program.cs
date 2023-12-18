namespace donePractice;
class Program
{
    static void Main(string[] args)
    {
        Person personTask1 = new Person();
        personTask1.name = "Ivan";
        personTask1.age = 16;

        Person[] personsTask4 = new Person[] { new Person("Nikita", 10),
                                      new Person("Vasya", 17),
                                      new Person("Gena", 12),
                                      new Person("Sam", 45),
                                      new Person("dead", 90)
                                    };
        foreach (Person personTask4 in personsTask4)
        {
            personTask4.Introduce();
        }

        Employee employee = new Employee();
    }
}
public class Person
{
    public string name;
    public int age;

    public Person(string name = "", int age = 0)
    {
        this.name = name;
        if (age > 0)
        {
            this.age = age;
        }
        else
        {
            this.age = 0;
        }
    }

    public void SetAge(int age)
    {
        if (age > 0)
        {
            this.age = age;
        }
        else
        {
            this.age = 0;
        }
    }

    public void Introduce()
    {
        Console.WriteLine("Hello, my name is " + name);
    }
}

public class Employee : Person
{
    public string position;

    public Employee(string name = "", int age = 0, string position = "") : base(name, age)
    {
        this.position = position;
    }
}
