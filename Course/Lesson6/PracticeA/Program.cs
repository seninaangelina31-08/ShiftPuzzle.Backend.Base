namespace PracticeA;
class Program
{
    static void Main(string[] args)
    {
        int result1 = Sum(1,2);
        Console.WriteLine($"1) Сумма чисел: {result1}");
        
        string result2 = Hello("Kirill");
        Console.WriteLine($"2) {result2}");

        int result3 = Max(4,5);
        Console.WriteLine($"3) Максимальное число: {result3}");

        bool result4 = Chetnost(4);
        Console.WriteLine($"4) Четное число?: {result4}");

        double result5 = Temperature(1.00000);
        Console.WriteLine($"5) Перевод из C в F: {result5}");

        string result6 = Reverse("Hi!");
        Console.WriteLine($"6) Перевернутая строка: {result6}");

        int result7 = Count("Kirill", 'l');
        Console.WriteLine($"7) Кол-во символов: {result7}");

        int result8 = Factorial(5);
        Console.WriteLine($"8) Факториал: {result8}");

        bool result9 = Prime(5);
        Console.WriteLine($"9) Простое ли число?: {result9}");

        int result10 = Rundom_number(5, 7);
        Console.WriteLine($"10) Число из диапозона : {result10}");
    }
    public static int Sum(int a, int b)
    {
        return (a + b);
    }

    public static string Hello(string name)
    {
        return($"Hello, {name}!");
    }

    public static int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }

        if (b > a)
        {
            return b;
        }

        else
        {
            return a;
        }
    }

    public static bool Chetnost(int a)
    {
        if (a % 2 == 0)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public static double Temperature(double t)
    {
        return Convert.ToDouble((t * 9 / 5) + 32);
    }

    public static string Reverse(string str)
    {
        string reversed = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
           reversed += str[i];
        }

        return reversed;
    }

    public static int Count(string str, char k)
    {
        int count = 0;
        foreach (char i in str)
        {
            if(i == k)
            {
                count++;
            }
        }
        return count;
    }

    public static int Factorial(int a)
    {
        int n = 1;
        for (int i = 1; i <= a; i++)
        {
            n *= i;
        }

        return n;
    }

    public static bool Prime(int a)
    {
        if (a < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(a); i++)
        {
            if (a % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static int Rundom_number(int a, int b)
    {
        Random random = new Random();
        return random.Next(a, b + 1);
    }
}
