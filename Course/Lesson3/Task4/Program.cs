namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {1, 2, 3, 14, 56, 600, 723};
        numbers[5] = 100;
        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);
        Console.WriteLine(numbers[3]);
        Console.WriteLine(numbers[4]);
        Console.WriteLine("Изменённое значение: " + numbers[5]);
        Console.WriteLine(numbers[6]);
    }
}
