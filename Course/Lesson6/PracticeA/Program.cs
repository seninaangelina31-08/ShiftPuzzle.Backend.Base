namespace practiceA;

class Program
{
    public static int sum(int a, int b)
    {
        return a+b;
    }


    public static void privetstvie(string name)
    {
        Console.WriteLine("Привет, " + name);
    
    }


    public static int max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }


    public static bool chetn(int x)
    {
        if (x%2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public static double vFarengeit(double C)
    {
        double f = (C * 9 / 5) + 32;
        return f;
    }


    public static string reverse(string stroka)
    {
        char[] array = stroka.ToCharArray();
        Array.Reverse(array);

        return new string(array);
    }


    public static int sumsimvol(string str, char a)
    {
        int count = 0;
        foreach (char x in str)
        {
            if (x == a)
            {
                count++;
            }
            
        }
        return count;
        
    }


    public static int factorial(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }
        else
        {
            return num * factorial(num - 1);
        }
    }



    public static bool prostoeslognoe(int number)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            return false;
        }
        return true;
    }

    public static int generator(int a, int b)
    {
        Random random = new Random();
        return random.Next(a, b);
    }
}