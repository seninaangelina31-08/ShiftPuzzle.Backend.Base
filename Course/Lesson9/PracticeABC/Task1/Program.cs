namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        Human human = new Human("");
        human.Name();
        human.age();
    }
}

public Class Preson
{
    public string Name;
    public int Age;

    public Preson(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public virtual void Name()
    {
        Name = "Vanya";
    }

    public void Age()
    {
        Age =+ 17;
    }

    Console.WriteLine($"Имя: {Name} Возвраст: {Age}");

    class virtual void AgeA()
    {
        if (age >= 0)
        {
            this.Age = age;
        }
        else
        {
            this.Age - age;
        }
    }

    public class Employee: Human
    {
        public string Position;
        public Employee(string name, int age, string Position) : base(name, age)
    }

}