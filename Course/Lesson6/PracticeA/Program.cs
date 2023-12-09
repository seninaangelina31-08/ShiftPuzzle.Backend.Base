using System.Globalization;

namespace PracticeA;

class Program
{
    static void Main(string[] args)
    {   
        Random numGenerator = new();
        int num1 = numGenerator.Next(10);
        int num2 = numGenerator.Next(-10, 10);
        string niceTeacher = "Akshin Guseinov";
        Console.WriteLine($"Первое число - {num1}");
        Console.WriteLine($"Второе число - {num2}");
        Console.WriteLine("1-я функция");
        Console.WriteLine(Sum(num1, num2));
        Console.WriteLine("2-я функция");
        Greeting(niceTeacher);
        Console.WriteLine("3-я функция");
        Console.WriteLine(Max(num1, num2));
        Console.WriteLine("4-я функция");
        Console.WriteLine(IsEven(num1));
        Console.WriteLine("5-я функция");
        Console.WriteLine(CelsiumToFarengeit(num1));
        Console.WriteLine("6-я функция");
        Console.WriteLine(Reverse(niceTeacher));
        Console.WriteLine("7-я функция");
        Console.WriteLine(CharCount(niceTeacher, niceTeacher[5]));
        Console.WriteLine("8-я функция");
        Console.WriteLine(Factorial(num1));
        Console.WriteLine("9-я функция");
        Console.WriteLine(IsSimple(num1));
        Console.WriteLine("10-я функция");
        Console.WriteLine(RandInt(-10, 10));

    }


    public static float Sum(float num1, float num2)
    {
        return num1 + num2;
    }

    public static void Greeting(string name)
    {
        Console.WriteLine($"Салам алейкум, {name}");
    }

    public static float Max(int num1, int num2)
    {
        if (num1 > num2) return num1;
        return num2;
    }

    public static bool IsEven(int num1)
    {
        return num1 % 2 == 0;
    }

    public static double CelsiumToFarengeit(float temp)
    {
        return temp * 1.8 + 32;
    }

    public static string Reverse(string text)
    {
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public static int CharCount(string text, char symbol)
    {
        return text.Count(f => f == symbol);
    }

    public static int Factorial(int num)
    {   
        int total = 1;
        for (int i = 2; i <= num; i++)
        {
            total *= i;
        }
        return total;
    }

    public static bool IsSimple(int num)
    {
        for (int i = 2; i < Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    public static int RandInt(int start, int end)
    {
        Random numGenerator = new();
        return numGenerator.Next(start, end);
    }
}
