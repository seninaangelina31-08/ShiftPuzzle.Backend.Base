using System.Diagnostics.Contracts;
using System.Security.Cryptography;

namespace PracticeABC;



class Program
{
    static void Main(string[] args)
    { 
    ////прямое обращение
    ////создания экземпляра класса
        Person[] people = new Person[3];
        people[0] = new Person("John", 30);
        people[1] = new Person("Jane", 25);
        people[2] = new Person("Bob", 40);
        

        Person person = new Person(" ", 0);




        person.name = "Lurri";
        person.age = 20;
        person.Introduce();

        foreach (Person Person in people)
        {
            person.Introduce();

        }
    }

    
}
public class Person
{

    //// поля
 
 
    public string name;
    public int age;
    
    public void Introduce() 
    {
        Console.WriteLine ("Привет, мое имя" + name);
    }
    
    

    public Person ( string name, int age)
    {
        this.name = name;
        this.age = age;
    }


}


public class Employee : Person
{

    //// поля 
   


    public string position;

    public Employee(string name, int age, string position) : base(name, age) 
    {
        this.position = position;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Имя: " + name);
        Console.WriteLine("Возраст: " + age);
        Console.WriteLine("Работа: " + position);
    }

}

