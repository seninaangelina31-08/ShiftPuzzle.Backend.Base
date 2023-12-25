public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }


    public Person(string name, int age)
    {
        Name = name;
        SetAge(age);
    }


    public void Introduce()
    {
        Console.WriteLine("Hello, my name is " + Name);
    }


    public void SetAge(int newAge)
    {
        if (newAge >= 0)
        {
            Age = newAge;
        }
        else
        {
            Console.WriteLine("Age cannot be negative.");
        }
    }

    public virtual string Return_element() {return $"{this.Name};{this.Age}";}

    public string GetType() {return "Person";}
}


public class Employee : Person
{
    public string Position { get; set; }


    public Employee(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }

    public override string Return_element() {return $"{this.Name};{this.Age};{this.Position}";}

    public string  GetType() {return "Employee";}
}


public class PersonFileService
{
    public static void WritePeopleToFile(List<Person> people)
    {
        string[] people_string = new string[people.Count];
        for (int i = 0; i < people.Count; i++)
        {
            people_string[i] = people[i].Return_element();
        }
        File.WriteAllLines("Person.md", people_string);
    }
    public static Person[] ReadPeopleFromFile()
    {
        string[] lines = File.ReadAllLines("Person.md");
        Person[] people_read = new Person[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            string[] line = lines[i].Split(';');
            if (line.Length == 2){people_read[i] = new Person(line[0], Convert.ToInt32(line[1]));}
            else{people_read[i] = new Employee(line[0], Convert.ToInt32(line[1]), line[2]);}
        }
        return people_read;
    }

}


public class Program
{
    public static void Main()
    {
        // List of people to write to and read from the file
        var people = new List<Person>
        {
            new Person("Alice", 28),
            new Person("Bob", 35),
            new Employee("Charlie", 42, "Manager")
        };

        
        // Writing people to the file
        PersonFileService.WritePeopleToFile(people);


        // Reading people from the file
        var peopleFromFile = PersonFileService.ReadPeopleFromFile();
        
        
        foreach (var person in peopleFromFile)
        {
            person.Introduce();
        }
    }
}
