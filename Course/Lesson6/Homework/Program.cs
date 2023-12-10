namespace homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задание 1");
        int[] mas = {1, 2, 3, 3, 3, 4, 5, 4, 5, 4};
        int ans = Task1(mas);
        Console.WriteLine($"В массиве чаще всего повторяется - {ans}");
        Console.WriteLine("\n");

        Console.WriteLine("Задание 2");
        int[,] Matrix = new int[3, 3];
 

        Random random = new Random();
        int rand;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                rand = random.Next(0, 100);
                Matrix[i, j] = rand;
            }
        }
        Console.WriteLine("Исходная матрица");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{Matrix[i, j]} ");
            }
            Console.WriteLine();
        }

        int[,] massiv = Task2(Matrix);
        Console.WriteLine("Транспортированная матрица");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{massiv[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static int Task1(int[] mas)
    {
        int count_el = 0;
        int max_count = 0;
        int ans = mas[0];

        for (int i = 0; i < mas.Length; i++)
        {
            count_el = 0;
            for (int j = 0; j < mas.Length; j++)
            {
                if (mas[i] == mas[j] && i != j)
                {
                    count_el++;
                }
            }

            if (count_el > max_count) {
                max_count = count_el;
            }
        }

        for (int i = 0; i < mas.Length; i++)
        {
            count_el = 0;
            for (int j = 0; j < mas.Length; j++)
            {
                if (mas[i] == mas[j] && i != j)
                {
                    count_el++;
                }
            }

            if (count_el == max_count) {
                ans = mas[i];
            }
        }

        return ans;
    }


    public static int[,] Task2(int[,] mas)
    {
        int tmp;
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                tmp = mas[i, j];
                mas[i, j] = mas[j, i];
                mas[j, i] = tmp;
            }
        }
        return mas;
    }

}
