public class Person
{
    public string name;
    public int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Introduce()
    {
        Console.WriteLine("Hello, my name is " + name);
    }

    public void Pol(int age)
    {
        if (age > 0)
        {
            this.age = age;
        }
        else
        {
            Console.WriteLine("Your age is wrong");
        }
    }

    public class Employee : Person
    {
        public string position;

        public Employee(string name, int age, string position) : base(name, age)
        {
            this.position = position;
        }
    }
}

class Programm 
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Dasha", 17);

        Person[] arr = new Person[3];
        arr[0] = new Person ("Ilmira", 16);
        arr[1] = new Person ("Yura", 18);
        arr[2] = new Person ("Sveta", 17);

        for (int i = 0; i<arr.Length; i++)
        {
            arr[i].Introduce();
        }
    }
}
