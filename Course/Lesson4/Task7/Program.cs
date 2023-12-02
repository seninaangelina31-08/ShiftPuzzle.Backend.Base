namespace Task7;

class Program
{
    static void Main(string[] args)
    {
        int[] num = { 2, 5, 7, 9, 12, 15, 20 };

        Console.WriteLine("Элементы на нечетных позициях:");

        for (int i = 1; i < num.Length; i += 2)
        {
            Console.WriteLine(num[i]);
        }
    }
}