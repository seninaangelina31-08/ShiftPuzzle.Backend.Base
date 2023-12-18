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
        people[0] = new Person("Nikita");
        people[1] = new Person("Karina");
        foreach (Person people_one in people)
        {
            people_one.Introduce();
        }
        
        // 5
        people[0].Age_cheak(17);
        people[1].Age_cheak(-16);
        Employee Nik = new Employee("Nikita", "Arkhangels");
        
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
    
    public Person(string name)
    {
        this.Name = name;
    }

    public void Age_cheak(int age)
    {
        if (age > -1){
            this.Age = age;
        }
        else{
            Console.WriteLine("Значение не может быть отрицательным!");
        }
    }
}

public class Employee : Person
{
    public Employee(string name, string position) : base(name) {}
}