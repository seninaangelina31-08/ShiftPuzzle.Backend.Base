namespace PracticeA;

class Program
{
    static void Main(string[] args)
    {
        int result1 = Factorial(7);
        Console.WriteLine($"1){result1}");

        int result2 = Fib(5);
        Console.WriteLine($"2){result2}");

        string result3 = "Hello";
        Console.WriteLine($"3){Rev(result3)}");

        int[] result4 = { 0, -15, 2, 7, -8 };
        Console.WriteLine($"4){Sum(result4)}");

        int result5 = NOD(12, 18);
        Console.WriteLine($"5){result5}");

        string result6 = "шалаш";
        Console.WriteLine($"6){PAL(result6)}");

        Console.WriteLine($"7) Задание:");
        int number_of_disks = 3;
        Castle(number_of_disks, 'A', 'C', 'B');

        Console.WriteLine($"8) Задание:");
        int[] result8 = { 1, 2, 3};
        Power(result8);

        Console.WriteLine($"9) Задание: ГРОБ");
    }

    public static int Factorial(int a)
    {
        if (a < 0)
        {
            return 0; //Факториал определён только для натуральных чисел. Ноль - исключение(договоренность). Если находить факториал отрицательного числа, будем работать с комплексными числами!
        }
        if (a == 0)
        {
            return 1;
        }
        else
        {
            return (a * Factorial(a-1));
        }
    }

    public static int Fib(int n)
    {
        if (n < 0)
        {
            return 0; //Последовательность рассматривается только для натуральных чисел. Где первые два члена - это 1.
        }

        if (n == 0)
        {
            return 1;
        }

        if (n == 1)
        {
            return 1;
        }

        else
        {
            return (Fib(n-2)+Fib(n-1));
        }
    }

    public static string Rev(string str)
    {
        string reversed = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
           reversed += str[i];
        }

        return reversed;
    }

    public static int Sum(int[] array, int k = 0)
    {
        if (k == array.Length)
        {
            return 0;
        }
        else
        {
            return array[k] + Sum(array, k + 1);
        }
    }
    
    public static int NOD(int a, int b)
    {
        if (a > b)
        {
            a = a - b;
            return NOD(a , b);
        }
        if (b > a)
        {
            b = b - a;
            return NOD(a, b);
        }
        else
        {
            return a;
        }
    }

    public static bool PAL(string str)
    {
        if (str.Length == 1)
        {
            return true;
        }

        if (str[0] == str[str.Length - 1])
        {
            return PAL(str.Substring(1,str.Length - 2));
        }

        else
        {
            return false;
        }
    }

    public static void Castle(int i, char source, char dest, char dop)
    {
        if (i > 0)
        {
            Castle(i-1, source, dop, dest);
            Console.WriteLine($"Диск {i} со стержня {source} на стержень {dest}");
            Castle(i - 1, dop, dest, source);
        }
    }

    public static void Power(int[] kit, int k = 0, string s_kit = "")
    {
        if (k == kit.Length)
        {
            Console.WriteLine($"Подмножество: {{{s_kit}}}");
        }

        else
        {
        Power(kit, k + 1, s_kit + kit[k] + ", ");
        Power(kit, k + 1, s_kit);
        }
    }

}
