namespace Practice
{
class Person
{
    public string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.Age = age;
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
                throw new Exception($"{name} такой возраст и ты сидишь дома.");
            else
                age = value;
        }
    }

    public void Introduce()
    {
        Console.WriteLine($"Привет, мое имя {name}");
        Console.WriteLine($"Мне {Age} лет");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person("Андрей", 20),
                new Person("Акшин", 23),
                new Person("Миша", -10)
            };

            foreach (var person in people)
            {
                person.Introduce();
            }
      }
    }
  }
}