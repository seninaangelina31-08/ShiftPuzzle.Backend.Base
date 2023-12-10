using System.Globalization;

namespace PracticeB_С;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задание 1");
        int[] mas = {-5, -10, 1, 2, 3, 6, -1, 5, 6, 1, 1, -1};
        int[] ans = practice_b(mas);

        Console.Write("Итоговый массив: ");

        foreach (int arr in ans) 
        {
            Console.Write($"{arr} ");
        }
        Console.WriteLine("\n");
        Console.WriteLine("Задание 2");
        int[] massiv = {1, 2, 3};
        string[] answer = practice_c(massiv);

        Console.WriteLine("\n");
    }

    public static int[] practice_b(int[] mas)
    {
        int max_sum = 0; 
        int[] sums = new int[mas.Length];
        int start_pos = 0, finish_pos = 0;

        for (int i = 1; i < mas.Length; i++)
        {
            sums[i] = sums[i-1] + mas[i];
        }

        for (int i = 0; i < mas.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (sums[i] - sums[j] > max_sum) 
                {
                    start_pos = j;
                    finish_pos = i;
                    max_sum = sums[i] - sums[j];
                }
            }
        }

        int[] ans = new int[finish_pos - start_pos + 1];
        for (int i = start_pos; i < finish_pos + 1; i++)
        {
            ans[i-start_pos] = mas[i];
        }

        return ans;
    }

    public static string[] practice_c(int[] mas)
    {
        int fact_length = 1;
        for (int i = 1; i <= mas.Length; i++)
        {
            fact_length *= i;
        }

        string[] ans = new string[fact_length];

        for (int i = 0; i < mas.Length; i++)
        {
            
        }

        return ans;
    }
}
