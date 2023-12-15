namespace PracticeAB;

class Program
{

    
    // Творим тут


    //1
    public static int Task1(int a, int b)
    {
        return (a + b);
    }

    //2
    static bool Task2(int a)
    {
        return (a % 2 == 0);
    }

    //3
    static string Task3(string s)
    {
        char[] charsArray = s.ToCharArray();
        Array.Reverse(charsArray);
        return new string(charsArray);
    }

    //4
    static int Task4(int[] arr)
    {
        return arr.Max();
    }

    // 5
    static double Task5(double a)
    {
        return a * 12;
    }

    // 6
    static double Task6(double cels)
    {
        return cels * 1.8 + 32;
    }

    //7
    static int Task7(string s)
    {
        string vowels = "уеыаоэяиюУЕЫАОЭЯИЮ";
        int sum = 0;
        foreach (char ch in s)
        {
            if (vowels.Contains(ch))
                sum++;
        }
        return sum;
    }

    //8
    static int Task8(string pass)
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
                        string a = Convert.ToString(x) + Convert.ToString(y) + Convert.ToString(z) + Convert.ToString(h);
                        if (a == pass)
                        {
                            Console.WriteLine("Ура! Вы взломали пароль теперь вы хакер");
                            return count;
                        }
                    }
                }
            }
        }
        return 0;
    }

    static void Main(string[] args)
    {
        // это функция мейн которая вызывает все отсальные функции для практики А и Б
        //вызов первой функци.... и т.п.
        Console.WriteLine(Task1(1, 2));
        Console.WriteLine(Task2(7));
        Console.WriteLine(Task3("Hello KOD"));
        int[] a = {15, 28, 46, -48, -71, 0, 5, 48, -4};
        Console.WriteLine(Task4(a));
        Console.WriteLine(Task5(83400));
        Console.WriteLine(Task6(15.3));
        Console.WriteLine(Task7("Привет, Код! Как дела в Питере?"));
        Console.WriteLine(Task8("7394"));
    }
}
