namespace Homework_Tsk_1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите 1 число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите 2 число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());


        int sum = num1 + num2;
        Console.WriteLine(sum);
    }
}
