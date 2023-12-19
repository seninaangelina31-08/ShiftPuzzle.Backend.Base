namespace SOLUTION;

class Program
{
    static void Main()
    {
        Person[] people = new Person[3];

        people[0] = new Person("Акшин", 23);
        people[1] = new Person("Дима", 5);
        people[2] = new Person("Саша", 92);

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
        Console.WriteLine($"Hi! My name is {Name}");
    }

    public void SetAge(int new_age)
    {
        if (new_age >= 0)
        {
            this.Age = new_age;
        }
        else
        {
            Console.WriteLine("Возраст не может быть отрицательным!");
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