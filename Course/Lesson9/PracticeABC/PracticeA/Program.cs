namespace practicea;

class Program
{
    static void Main(string[] args)
    {
        Person people1 = new Person("Ilya", 17);
        people1.Name = "Danil";
        people1.Age = 18;
        people1.Introduce();
        Person[] mas = {people1, new Person("Egor", 17), new Person("Valera", 17)};
        foreach (var item in mas)
        {
            item.Introduce();
        }

        people1.AgeAgain(10);
        Console.WriteLine(people1.Age);

        Employee person2 = new Employee("Sasha", 25, "Director");
        Console.WriteLine(person2.Position);
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
        Console.WriteLine($"Привет! Моё имя {this.Name}");
    }

    public virtual void AgeAgain(int age)
    {
        if (age >= 0)
        {
            this.Age = age;
        }
        else
        {
            this.Age = - age;
        }
    }
}

public class Employee: Person
{
    public string Position;
    public Employee (string name, int age, string position) : base(name, age) {
        this.Position = position;
    }

}
