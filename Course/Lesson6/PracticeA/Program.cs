namespace practicea;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задача 1");
        int r = task1(5, 6);
        Console.WriteLine($"Сумма чисел = {r}");
        Console.Write('\n');

        Console.WriteLine("Задача 2");
        string user_name = "Ilya";
        task2(user_name);
        Console.Write('\n');

        Console.WriteLine("Задача 3");
        int a = 5; 
        int b = 5;
        int max = task3(a, b);
        Console.WriteLine($"Наибольшее число - {max}");
        Console.Write('\n');

        Console.WriteLine("Задача 4");
        int four = 4;
        bool chet = task4(four);
        Console.WriteLine(chet);
        Console.Write('\n');

        Console.WriteLine("Задача 5");
        float temp = 50.0f;
        float f = task5(temp);
        Console.WriteLine(f);
        Console.Write('\n');

        Console.WriteLine("Задача 6");
        string str = "Привет";
        string str_reverse = task6(str);
        Console.WriteLine(str_reverse);
        Console.Write('\n');

        Console.WriteLine("Задача 7");
        string lst = "Водоканал";
        char symbol = 'о';
        int res_seven = task7(lst, symbol);
        Console.WriteLine($"Количество - {res_seven}");
        Console.Write('\n');

        Console.WriteLine("Задача 8");
        int n = 5;
        int fact = task8(n);
        Console.WriteLine($"Факториал числа {n} = {fact}");
        Console.Write('\n');

        Console.WriteLine("Задача 9");
        int number = 7;
        task9(number);
        Console.Write('\n');

        Console.WriteLine("Задача 10");
        int value = task10(10, 20);
        Console.WriteLine($"Случайное число - {value}");
        Console.Write('\n');

    }

    public static int task1(int a, int b)
    {
        int res = a + b;
        return res;
    }

    public static void task2(string name_user)
    {
        Console.WriteLine($"Привет, {name_user}");
    }

    public static int task3(int a, int b)
    {
        if (a > b) 
        {
            return a;
        }
        else if (a < b)
        {
            return b;
        }
        else
        {
            return a;
        }
    }

    public static bool task4(int a)
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

    public static float task5(float a)
    {
        float res = (a * 1.8f) + 32;
        return res;
    }

    public static string task6(string str)
    {
        string res = "";

        for (int i = 0; i < str.Length; i++) 
        {
            res += str[str.Length - i - 1];
        }

        return res;
    }

    public static int task7(string stroka, char sym)
    {
        int c = 0;
        foreach (char ar in stroka) 
        {
            if (ar == sym) 
            {
                c++;
            }
        }

        return c;
    }

    public static int task8(int n)
    {
        int res = 1;

        for (int i = 1; i <= n; i++)
        {
            res *= i;
        }

        return res;
    }

    public static void task9(int n)
    {
        int count = 0;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }

        if (count == 0)
        {
            Console.WriteLine($"Число {n} - простое");
        } 
        else {
            Console.WriteLine($"Число {n} - непростое");
        }

    }

    public static int task10(int start, int finish)
    {
        Random rnd = new Random();
        int value = rnd.Next(start, finish);
        return value;
    }

}
