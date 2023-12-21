namespace Practice_CW;

class Program
{
    static void Main(string[] args)
    {
        Person teacher = new("Akshin", 24);
        teacher.Introduce();

        Person[] persons = {new("Gleb", 54), new("Elvin", 23), new("Vladimir", 58), new("FJKSDINFD-1234", -123)};

        foreach (Person person in persons)
        {
            person.Introduce();
            Console.WriteLine(person.Age);
            Console.WriteLine();
        }

        Employee poorDude = new("Akshin", 24, "data-scientist");

        Console.WriteLine($"{poorDude.Name}, {poorDude.Age}, {poorDude.Position}");


    }
}


public class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = CheckAge(age);
    }

    public void Introduce()
    {
        Console.WriteLine($"Привет, меня зовут {this.Name}.");

    }

    public int CheckAge(int Age)
    {
        if (Age >= 0) return Age;
        else return -100000000;
    }
}

public class Employee : Person
{
    public string Position;
    
    public Employee(string name, int age, string position) : base(name, age) 
    {
        this.Position = position;
    }
}
