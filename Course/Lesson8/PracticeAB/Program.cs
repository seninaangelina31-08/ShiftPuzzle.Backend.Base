namespace PracticeAB;

class Program
{

    
    // Творим тут


    //1
    public static int Add(int a, int b)
    {
        return a + b;
    }

    //2
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }


    //3
    public static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    //4
    public static int FindMax(int[] arr)
    {
        return arr.Max();
    }   

    // 5
    public static int factorial(int sallary)
    {
        return sallary * 12;
    }

    // 6
    public static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9/5 + 32;
    }

    //7
    public static int CountVowels(string s)
    {
        string vowels = "аиоуеэАИОУЕЭ";
        int count = 0;
        foreach (char c in s)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }
        return count;
    }

    //8
    public static int GeneratePassword(string passtohack)
    {
        int count = 0;
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                for (int z = 0; z < 10; z++)
                {
                    for (int h = 0; h < 10; h++)
                    {
                        count++;
                        string generatedpass = x.ToString() + y.ToString() + z.ToString() + h.ToString();
                        if (generatedpass == passtohack)
                        {
                            Console.WriteLine("Ура! Вы взломали пароль теперь вы хакер");
                            return count;
                        }
                    }
                }
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        // это функция мейн которая вызывает все отсальные функции для практики А и Б
        //вызов первой функци.... и т.п.
        // 1
        int a = 1;
        int b = 2;
        Console.WriteLine(Add(a, b));
        // 2
        int num = 4;
        bool ise = IsEven(num);
        Console.WriteLine(ise);

        // 3
        string s = "Hello";
        string r = ReverseString(s);
        Console.WriteLine(r);

        // 4
        int[] arr = {1, 3, 4, 2};
        Console.WriteLine(FindMax(arr));

        // 5
        int sal = 2;
        Console.WriteLine(factorial(sal));

        // 6
        double cels = 12;
        Console.WriteLine(CelsiusToFahrenheit(cels));

        // 7
        string str = "аио";
        Console.WriteLine(CountVowels(str));

        // 8
        string passtohack = "1ab";
        Console.WriteLine(GeneratePassword(passtohack));
    }
}
