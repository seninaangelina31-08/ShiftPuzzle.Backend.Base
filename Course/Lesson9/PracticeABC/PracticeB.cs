namespace ShiftPuzzle.Backend.Base.Course.Lesson9.PracticeABC;

public class PracticeB
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

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Эвелина", 17);
        person.Introduce();

        // Попытка установить отрицательный возраст
        person.Age = -5;
    }
}