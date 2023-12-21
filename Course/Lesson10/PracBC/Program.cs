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
}

public class Employee : Person
    {
        public string position;

        public Employee(string name, int age, string position) : base(name, age)
        {
            this.position = position;
        }
    }

class FileOperations
{

    public static void WriteToFile()
    {
        string[] lines = new string[1];
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = "lena, 13, ghjhg";
        }
        File.WriteAllLines("lesson10.txt", lines);
    }


    public static void ReadFromFileAndPrint()
    {
        string[] lines = File.ReadAllLines("lesson10.txt");
        foreach(string line in lines)
        {
            char[] delimiterChars = {','};


            string[] els = line.Split(delimiterChars);

            if (els.Length == 3)
            {
                string Name = els[0];
                int Age = Int32.Parse(els[1]);
                string Position = els[2];
                
                Employee chel = new Employee (Name, Age, Position);

                chel.Introduce();
            }

            else
            {
                string Name = els[0];
                int Age = Int32.Parse(els[1]);
                
                Person chel = new Person (Name, Age);

                chel.Introduce();
            }

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

        FileOperations.WriteToFile();
        FileOperations.ReadFromFileAndPrint();

        Employee person2 = new Employee("Dasha", 17, "sdgdsgsd");
    }
}

