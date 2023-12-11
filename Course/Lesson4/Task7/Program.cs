namespace Task7;

class Program
{
    static void Main(string[] args)
    {
        int[] num = { 2, 5, 7, 9, 12, 15, 20 };

        int min = num[0];
        int max = num[0];

        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
            }

            if (num[i] > max)
            {
                max = num[i];
            }
        }

        Console.WriteLine($"Минимальный элемент в массиве: {min}");
        Console.WriteLine($"Максимальный элемент в массиве: {max}");
    }
}