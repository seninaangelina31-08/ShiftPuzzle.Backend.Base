namespace PracticeAB;

class Program
{

    
    // Творим тут
    static void Main()
    {
        // это функция мейн которая вызывает все отсальные функции для практики А и Б
        //вызов первой функци.... и т.п.
        int[] arr = {12,4,5};
        int sallary = 300;
        string s = "Опять работать";
        /*System.Console.WriteLine(Add(6, 4));
        System.Console.WriteLine(IsEven(6));
        System.Console.WriteLine(ReverseString("Я люблю C#"));
        System.Console.WriteLine(FindMax(arr));
        System.Console.WriteLine(Factorial(sallary));
        System.Console.WriteLine(Celsius_to_farenheit(12));
        System.Console.WriteLine(CountVowels(s));
        */
        System.Console.WriteLine(GeneratePassword("9234"));
    }


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
    public static int Factorial(int sallary)
    {
        return sallary * 12;
    }

    // 6
    public static double Celsius_to_farenheit(int celsius)
    {
        return celsius * 9/5 + 32;
    }

    //7
    public static int CountVowels(string s)
    {
        string vowels = "аиоуеэАИОУЕЭ";
        int count = 0;
    
        foreach(char c in s)
        {
            if(vowels.Contains(c))
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
                        Console.WriteLine("Ура! Вы взломали пароль, теперь вы хакер");
                        return count;
                    }
                }
            }
        }
    }

    return count;
}

}

