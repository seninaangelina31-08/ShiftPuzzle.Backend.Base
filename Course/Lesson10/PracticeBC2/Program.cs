namespace PracticeBC2;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Ura", 16);
        Person person2 = new Person("Nikita", 8);
        Person person3 = new Person("Gleb", -26);
        Person person4 = new Person("Grisha", 43);
        Employee employee = new Employee("Dasha", 43, "clerk");

        Person person5 = new Person("Stan", 10);
        Person person6 = new Person("Kyle", 9);
        Person person7 = new Person("Kain", 11);
        Person person8 = new Person("Cartman", 12);

        Person[] array_persons1 = {person1, person2, person3, employee};
        Person[] array_persons2 = {person5, person6, person7, person8};
        
        WriteFunc(array_persons1);
        WriteFuncMd(array_persons2);
        Console.WriteLine("Txt");
        ReadFunc();
        Console.WriteLine("Md");
        ReadFuncMd();
    }

    public static void WriteFunc(Person[] array_persons){
        string[] persons = new string[array_persons.Length];
        for (int i = 0; i < array_persons.Length; i++){
            persons[i] = $"{array_persons[i].Name}: {array_persons[i].Age}";
        }
        File.WriteAllLines("persons.txt", persons);
    }

    public static void ReadFunc(){
        string[] persons = File.ReadAllLines("persons.txt");
        foreach (string person in persons){
            Console.WriteLine(person);
        }
    }

    public static void WriteFuncMd(Person[] array_persons){
        string[] persons = new string[array_persons.Length];
        for (int i = 0; i < array_persons.Length; i++){
            persons[i] = $"{array_persons[i].Name}: {array_persons[i].Age}";
        }
        File.WriteAllLines("persons.md", persons);
    }

    public static void ReadFuncMd(){
        string[] persons = File.ReadAllLines("persons.md");
        foreach (string person in persons){
            Console.WriteLine(person);
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

public class Employee : Person{
    string Position;
    public Employee(string Name, int Age, string Position) : base(Name, Age) {
        this.Position = Position;
    }
}