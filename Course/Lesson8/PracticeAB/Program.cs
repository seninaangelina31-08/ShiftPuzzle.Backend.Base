namespace PracticeAB;

class Program
{

    
    // Творим тут


    // 1
    public static int Add(int a, int b)
    {
        return a + b;
    }


    // 2
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }


    // 3
    public static string ReverseString(string s)
    { 
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        string answer = "";
        foreach (char letter in charArray)
        {
            answer += letter;
        }
        return answer;
    }


    // 4
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
    public static int CelsiusToFahrenheit(int celsius)
    {
        return celsius * 9/5 + 32;
    }


    // 7
    public static int CountVowels(string s)
    {
        string vowels = "аиоуеэёАИОУЕЭЁ";
        int counter = 0;

        foreach (char letter in s)
        {
            if (vowels.Contains(letter)) counter++;
        }

        return counter;
    }


    // 8
    public static int GeneratePassword(string passtohack)
    {
        int counter = 0;
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                for (int z = 0; z < 10; z++)
                {
                    for (int h = 0; h < 10; h++)
                    {
                        counter++;
                        string generatedpass = $"{x}{y}{z}{h}";
                        if (generatedpass == passtohack)
                        {
                            Console.WriteLine("Ура, вы взломали пароль!!! =)");
                            return counter;
                        }
                    }
                }
            }
        }
        return -1;
    }


    static void Main(string[] args)
    {
        // это функция мейн которая вызывает все остальные функции для практики А и Б
        //вызов первой функци.... и т.п.
        Console.WriteLine("Task 1");
        Console.WriteLine(Add(10, 15));

        Console.WriteLine("Task 2");
        Console.WriteLine(IsEven(16));

        Console.WriteLine("Task 3");
        Console.WriteLine(ReverseString("HELLO THERE!"));

        Console.WriteLine("Task 4");
        Console.WriteLine(FindMax(new int[] {-123, 14, 1, 0, 414, 1231, -123}));

        Console.WriteLine("Task 5");
        Console.WriteLine(Factorial(20_000));

        Console.WriteLine("Task 6");
        Console.WriteLine(CelsiusToFahrenheit(5/9));

        Console.WriteLine("Task 7");
        Console.WriteLine(CountVowels("ДАРОВА"));

        Console.WriteLine("Task 8");
        Console.WriteLine(GeneratePassword("0009"));

    }
}
