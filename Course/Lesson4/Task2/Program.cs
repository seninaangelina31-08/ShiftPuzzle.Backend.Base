namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {100000, 23, 101230, -100, 23923};
        int max_el = 0;

        foreach (int el in array)
        {
            if (max_el < el)
            {
                max_el = el;
            }

        }
        Console.WriteLine($"Наибольший элемент в массиве: {max_el}");
    }
}
