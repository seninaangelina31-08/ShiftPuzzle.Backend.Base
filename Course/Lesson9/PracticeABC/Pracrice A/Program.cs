using System.Runtime.CompilerServices;
using System.Security;

namespace Pracrice_A;



public class Person {

    public string Name;
    public int Age;

    public Person(string name, int age) {
        this.Name = name;
        this.Age = age;
    }

    public void Introduce() {
        Console.WriteLine("Hello, my name is "+this.Name);
    }

    public bool W_age(int age) {
        if (age > 0) {
            this.Age = age;
        } else {
            return false;
        }
        return true;
    }



}

public class Employee : Person {
    public string Position;
    public Employee(string name, int age, string position): base(name, age) {
        this.Position = position;
    }


}



class Program
{
    static void Main(string[] args)
    {
        Person man = new Person("some name", 15);
        man.Name = "abc";
        man.Age = 25;
        Person[] arr = new Person[10];
        for (int i = 0; i < 10; i++) {
            Person mdn = new Person("Clone"+i, 10+i);
            arr[i] = mdn;
            mdn.Introduce();
        }

    }
}
