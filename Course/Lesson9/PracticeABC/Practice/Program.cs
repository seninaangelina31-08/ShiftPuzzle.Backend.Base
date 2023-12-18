namespace Practice;

class Persone
{
    public string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.Age = age;
    }


    public void Introduce()
    {
        Console.WriteLine($"Привет, меня зовут {name}");
        Console.WriteLine($"Мне {Age} лет");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person("Саша", 25),
                new Person("Антон", 13),
                new Person("Миша", 17)
            };

            foreach (var person in people)
            {
                person.Introduce();
            }
        }
    }
}
