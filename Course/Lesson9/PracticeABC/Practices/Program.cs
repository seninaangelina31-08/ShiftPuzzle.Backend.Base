namespace Practices;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Valery", 16);
        Person person2 = new Person("Ivan", 8);
        Person person3 = new Person("Eugene", -26);
        Person person4 = new Person("Branislav", 43);

        Person[] array_persons = {person1, person2, person3, person4};

        for (int i = 0; i < array_persons.Length; i++){
            array_persons[i].Introduce();
        }
    }
}

public class Person{

    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = set_age(age);
    }

    public int set_age(int age){
        if (age < 0){
            Console.WriteLine($"Uncorrect Value (age is not negative num) in {Name}! Have been set age = 0");
            return 0;
        }
        return age;
    }
    public void Introduce(){
        Console.WriteLine($"Hello, my name is {Name}");
    }
}
