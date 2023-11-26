namespace task4;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        string s = Console.ReadLine();
        while (s == "") {
            count += 1;
            s = Console.ReadLine();
        }
        Console.Write(count);
    }
}
