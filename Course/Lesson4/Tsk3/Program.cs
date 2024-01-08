namespace Tsk3;

class Program
{
    static void Main()
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        Array.Reverse(numbers);
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}