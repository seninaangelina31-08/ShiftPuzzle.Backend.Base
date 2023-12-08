namespace PracticeA;

class Program
{
    public static int Sum(int x, int y)
    {
        return x + y;
    }

    public static void Hello(string name)
    {
         Console.WriteLine($"Привет {name}. Хорошего вам дня!");   
    }    

    public static int Max(int x, int y)
    {
        if (x > y)
        {
            return x;
        }
        else if(x < y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }

    public static bool Is_prime(int x)
    {

        for (int i = 2; i < x; i++)
        {
            if (x % i == 0)
            {
                return false;
            }

        }
        return true;
    }

    public static bool Even(int x)
    {
        if (x % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static double Convert(double c)
    {
        return c * 1.8 + 32;
    }

    public static string Reverse(string s)
    {
        string reversed_s = "";

        for (int i = s.Length - 1; i >= 0; i--)
        {
            reversed_s = reversed_s + s[i];
        }

        return reversed_s;
    }

    public static int Count(string s, char what_to_count)
    {   int c = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == what_to_count)
            {
                c++;
            }
        }
        return c;
    }

    public static int Factorial(int x)
    {
        int factorial = 1;
        for (int i = 1; i <= x; i++)
        {
            factorial *= i;

        }
        return factorial;
    }

    public static int FullRandom(int x, int y)
    {
        Random random = new Random();
        return random.Next(x, y);
    }
    static void Main(string[] args)
    {
        //Task 1
        int summ = Sum(1, 2);
        Console.WriteLine(summ);

        //Task 2
        Hello("User");

        //Task 3
        int max_number = Max(10000, 5);
        Console.WriteLine(max_number);
        
        //Task 4
        bool result = Even(4);
        Console.WriteLine(result); 

        //Task 5
        double temp = Convert(232.7777777);
        Console.WriteLine(temp);

        //Task 6
        string str = Reverse("1234");
        Console.WriteLine(str);

        //Task 7
        int count = Count("12341123", '1');
        Console.WriteLine(count);

        //Task 8
        int f = Factorial(5);
        Console.WriteLine(f);

        //Task 9
        bool prime = Is_prime(5);
        Console.WriteLine(prime);

        //Task 10
        int trully_random_int = FullRandom(0, 10);
        Console.WriteLine(trully_random_int); 




    }

}
