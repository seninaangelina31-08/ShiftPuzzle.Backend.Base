namespace Practice;


public class Person
{
    public int Age;
    public string Name;
    
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;

    }

    public void Introduce()
    {
         Console.WriteLine($"Привет, мое имя {this.Name}");
    }
}


class Program
{
    static void Main(string[] args)
    {
         Person Mihail = new Person("Mihail", 16);
         //Mihail.Age = 16;
         //Mihail.Name = "Mihail";
         //Mihail.Introduce();

        
        Person[] array = new Person[5];
        for (int i = 0; i < array.Length; i++)
        {   
            Console.WriteLine($"Введите возраст {i + 1} человека: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите имя {i + 1} человека: ");
            string name = Console.ReadLine();
            array[i] = new Person(name, age);
        }

        foreach (Person el in array)
        {
            el.Introduce();
        }
    }
}
