namespace PracticeB;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите 1 число: ");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите 2 число: ");
        int b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(a+b);
        Console.WriteLine(a-b);
        Console.WriteLine(a*b);
        Console.WriteLine(a/b);
    }
}
