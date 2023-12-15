using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace practicea;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задание 1");
        int n = 5;
        int result = Task1(n);
        Console.WriteLine($"Факториал числа {n} = {result}");
        Console.WriteLine("\n");

        Console.WriteLine("Задание 2");
        int fib_num = 5;
        int result_second = Task2(fib_num);
        Console.WriteLine($"{fib_num}-ое число последовательности: {result_second}");
        Console.WriteLine("\n");

        Console.WriteLine("Задание 3");
        string str = "Привет";
        string result_third = Task3(str);
        Console.WriteLine(result_third);
        Console.WriteLine("\n");

        Console.WriteLine("Задание 4");
        int[] mas_four = {1, 2, 3, 4, 5};
        int result_four = Task4(mas_four);
        Console.WriteLine($"Сумма элементов массива = {result_four}");
        Console.WriteLine("\n");

        Console.WriteLine("Задание 5");
        int result_five = Task5(18, 24);
        Console.WriteLine($"Нод = {result_five}");
        Console.WriteLine("\n");

        Console.WriteLine("Задание 6");
        string str_six = "шалаш";
        bool pal = Task6(str_six);
        if (pal)
        {
            Console.WriteLine($"Строка {str_six} палиндром");
        }
        else
        {
            Console.WriteLine($"Строка {str_six} не палиндром");

        }
        Console.WriteLine("\n");

        Console.WriteLine("Задание 7");
        Console.WriteLine("\n");

        Console.WriteLine("Задание 8");
        Console.WriteLine("\n");

        Console.WriteLine("Задание 9");
        Console.WriteLine("\n");

        Console.WriteLine("Задание 10");
        Console.WriteLine("\n");


    }

    public static int Task1(int n)
    {
        if (n <= 1)
        {
            return 1;
        } else
        {
            return n * Task1(n-1);
        }
    }

    public static int Task2(int n)
    {
        if (n <= 1)
        {
            return 0;
        }
        else if (n == 2 || n == 3) 
        {
            return 1;
        }
        else 
        {
            return Task2(n-1) + Task2(n-2);
        }
    }

    public static string Task3(string str)
    {
        if (str.Length == 0)
        {
            return str;
        }
        else
        {
            return Task3(str.Substring(1)) + str[0];
        }
    }

    public static int Task4(int[] mas)
    {
        if (mas.Length == 0)
        {
            return 0;
        }
        else
        {
            int[] ans = new int[mas.Length-1];

            for (int i = 1; i < mas.Length; i++)
            {
                ans[i-1] = mas[i];
            }
            return mas[0] + Task4(ans);
        }
    }

    public static int Task5(int a, int b)
    {
        if (a <= 0)
        {
            return b;
        }
        else
        {
            if (a > b)
            {
                return Task5(a % b, b);
            } else if (a < b)
            {
                return Task5(a, b % a);
            }
            else 
            {
                return Task5(a % b, b);
            }
        }
    }

    public static bool Task6(string str)
    {
        if (str == Task3(str))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
