namespace task7;

class Program
{
    static void Main(string[] args)
    {
        int discs = 5; // Количество дисков
        string first = "A"; // Исходный столбец
        string third = "C"; // Конечный столбец
        string second = "B"; // Вспомогательный столбец

        tower(discs, first, third, second);
    }
    public static void tower(int discs, string first, string third, string second)
    {
        if (discs == 1)
        {
            Console.WriteLine($"Перенести диск 1 со столбца {first} на столбец {third}");
            return;
        }
        tower(discs - 1, first, second, third);
        Console.WriteLine($"Перенести диск {discs} со столбца {first} на столбец {third}");
        tower(discs - 1, second, third, first);
    }

}
