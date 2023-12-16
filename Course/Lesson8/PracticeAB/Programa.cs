namespace PracticeAB;

class Programa
{
    // Творим тут

    //1
    public class Task1
    {
        public static int num(int a, int b)
        {
        return (a + b);
        }
    }

    // //2
    public class Task2
    {
    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }
    }


    // //3
    public static class Task3
    {
    public static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    }

    // //4
    public class Task4
    {
    public int FindMax(int[] arr)
    {
        return arr.Max();
    }
    }


    // // 5
    public class Task5
    {
    public decimal Factorial(decimal salary)
    {
        return salary * 12;
    }
    }
    
    //ПРАКТИКА В
    
    // // 6
    public class Task6
    {
    public double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }
    }

    // //7
    public class Task7
    {
    public int CountVowels(string s)
    {
        string vowels = "аиоуеэАИОУЕЭ";
        return s.Count(c => vowels.Contains(c));
    }
    }

    public class Task8
    {
    public int CountVowels(string s)
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
    }
    
    public int GeneratePassword(string passtohack)
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
        // Task1
        Console.WriteLine(Task1.num(1, 2));

        // Task2
        Task2 task2 = new Task2();
        Console.WriteLine(task2.IsEven(5));

        // Task3
        Console.WriteLine(Task3.ReverseString("PRIVET"));

        // Task4
        Task4 task4 = new Task4();
        int[] numbers = { 3, 7, 2, 9, 5 };
        Console.WriteLine(task4.FindMax(numbers));

        // Task5
        Task5 task5 = new Task5();
        Console.WriteLine(task5.Factorial(100));

        // Task6
        Task6 task6 = new Task6();
        Console.WriteLine(task6.CelsiusToFahrenheit(30));

        // Task7
        Task7 task7 = new Task7();
        Console.WriteLine(task7.CountVowels("BIMABAMBUM"));

        // Task8
        Task8 task8 = new Task8();
        Console.WriteLine(task8.CountVowels("BIMBAM"));

        // Вызов метода GeneratePassword
        Programa programa = new Programa();
        Console.WriteLine(programa.GeneratePassword("1010"));
    
    }
}