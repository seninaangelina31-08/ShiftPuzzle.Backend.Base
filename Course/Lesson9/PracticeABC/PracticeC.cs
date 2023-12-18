namespace ShiftPuzzle.Backend.Base.Course.Lesson9.PracticeABC;

public class PracticeC
{
    
}

public class Person
{
    public string Name { get; set; }
    private int age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Возраст не может быть отрицательным!");
            }
            else
            {
                age = value;
            }
        }
    }

    public void Introduce()
    {
        Console.WriteLine("Привет, мое имя " + Name);
    }
}

public class Employee : Person
{
    public string Position { get; set; }

    public Employee(string name, int age, string position)
        : base(name, age)
    {
        Position = position;
    }

    public void Introduce()
    {
        Console.WriteLine("Привет, мое имя " + Name + ", я работаю на должности " + Position);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Эвелина", 17, "будущий педагог!");
        employee.Introduce();
    }
}
