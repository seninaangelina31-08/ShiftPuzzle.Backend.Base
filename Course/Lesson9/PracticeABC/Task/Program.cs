namespace Task;

class Program
{
    static void Main(string[] args)
    {
        // // 1
        // Person IAm = new Person();
        // IAm.Name = "Никита";
        // IAm.Age = 17;

        // // 2
        // IAm.Introduce();

        // 4
        Person[] people = new Person[2];
        people[0] = new Person("Nikita", 17);
        people[1] = new Person("Karina", 16);
        foreach (Person people_one in people)
        {
            people_one.Introduce();
        }
 
        
    }
}
public class Person
{
    public string Name;
    public int Age;
    public void Introduce()
    {
        Console.WriteLine($"Привет, мое имя {this.Name}");
    }
    
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}