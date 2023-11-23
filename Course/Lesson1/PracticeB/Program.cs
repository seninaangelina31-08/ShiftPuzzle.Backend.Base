namespace PracticeB;
class Program
/* Напишите программу, которая принимает два числа от пользователя и выполняет арифметические операции (сложение, вычитание, умножение, деление) над ними,
выводя результат каждой операции на экран. */
{
    static void Main(string[] args)
    {
        int int_1 = Int32.Parse(Console.ReadLine());
        int int_2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine((int_1 + int_2) + " " + (int_1 - int_2) + " " + (int_1 * int_2) + " " + (int_1 / int_2));


    }
}
