namespace Practice;

class Program
{
    static void Main(string[] args)
    {
    //Person name = new Person("Pablo", -1);
    Person[] people = new Person[3];
    people[0] = new Person("Max", 15);
    people[1] = new Person("Stas",15 );
    people[2] = new Person("Artem", 16);

    Employee pers = new Employee("Sasha", -15, "disigner");

    foreach (var i in people)
    {
        i.Introduce();
    }


    }
}

public class Person 
{
    public string Name;
    public int Age;

    public Person( string name, int age)
    {
        this.Name = name;
        this.Age = age;

    }
    public void Introduce()
    {
    Console.WriteLine($"Привет, меня зовут {Name}");
    if (Age <= 0)
    {
        Console.WriteLine("Недопустимый возраст");
    }
    else
    {
        Console.WriteLine($"Возраст: {Age}");
    }

    }

}

public class Employee : Person
{
    public Employee(string name, int age, string position) : base(name, age)
    {
            
    }

}




