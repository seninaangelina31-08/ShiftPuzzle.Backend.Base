namespace PracticeA;
class Program
{
    static int summa(int a, int b)
    {
        return(a+b);
    }
    static void priv(string a)
    {
        Console.WriteLine($"Привет, {a}!");
    }
    static void bolsh(int a, int b)
    {
        if (a > b)
        {
            Console.WriteLine($"Число {a} больше");
        }
        else if (b > a)
        {
            Console.WriteLine($"Число {b} больше");
        }
        else
        {
            Console.WriteLine("Числа равны");
        }
    }
    static bool chet(int a)
    {
        if(a%2==0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static double temp(double a)
    {
        return(a*1.8+32);
    }
    static string rev(string a)
    {
        char[] chars = a.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
    static int count(string a, char b)
    {
        int counter = 0;
        foreach (char i in a)
        {
            if (i==b)
            {
                counter++;
            }
        }
        return counter;
    }
    static int fact(int a)
    {
        if (a == 1)
        {
            return a;
        }
        else
        {
            return (a * fact(a - 1));
        }
    }
    static bool prost(int a)
    {
        for(int i=2; i <= a/2; i++)
        {
            if(a % i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
    }
    static int rand(int a, int b)
    {
        Random rand = new Random();
        int randint = rand.Next(a, b+1);
        return(randint);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(summa(5, 7));
        priv("Никита");
        bolsh(7, 5);
        bolsh(5, 8);
        bolsh(6, 6);
        Console.WriteLine(chet(8));
        Console.WriteLine(chet(11));
        Console.WriteLine(temp(12.2));
        Console.WriteLine(rev("Привет"));
        Console.WriteLine(count("Абракадабра", 'а'));
        Console.WriteLine(fact(5));
        Console.WriteLine(prost(18));
        Console.WriteLine(prost(7));
        Console.WriteLine(rand(17, 25));
    }
}
