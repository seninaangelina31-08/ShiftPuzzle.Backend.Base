namespace PracticeC;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"{a + 5}");
    }
}
