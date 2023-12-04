namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        int[] num = {2, 5, 7, 9, 12, 15, 20};
        int targetElement = 9;

        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == targetElement)
            {
                Console.WriteLine($"Элемент {targetElement} найден в массиве на позиции {i}");
                return;
            }
        }

        Console.WriteLine($"Элемент {targetElement} не найден в массиве");
    }
}