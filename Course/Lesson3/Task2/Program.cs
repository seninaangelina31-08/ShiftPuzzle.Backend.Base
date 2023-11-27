namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        string[] myList = new string[3]

        Console.Write("Item 1: ");
        myList[0] = Console.ReadLine() ??"";

        Console.Write("Item 2: ");
        myList[1] = Console.ReadLine() ??"";

        Console.Write("Item 3: ");
        myList[2] = Console.ReadLine() ??"";

        Console.WriteLine($"1. {myList[0]}")
        Console.WriteLine($"2. {myList[1]}")
        Console.WriteLine($"3. {myList[2]}")
    }
}
