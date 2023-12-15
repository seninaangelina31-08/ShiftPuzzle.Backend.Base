namespace PracticeAB;

class Program
{

    
    // Творим тут


    //1
    // public static int Task1(int a, int b){
    //     return (a + b);
    // }
        public static int Task1(int a, int b)
    {
        return (a+b);
    }


    // //2
    public static bool Task2(int x)
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

    // //3
    public static string Task3(string s)
    {
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);

    return new string(charArray);
    }

    // //4
      public static int Task4(int[] arr)
      {
        int max_num = arr.Max();
        return max_num;
    }

    // // 5
    public static int Task5(int sallary)
    {
        return sallary*12;
    }
    // // 6
     public static double Task6(int celsius)
     {
        return ((celsius * 9/5) + 32);

    }

    // //7
    public int Task7(string s)
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

    // //8
  public int Task8(string passtohack)
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
                    string generatedpass = "{x}{y}{z}{h}";
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

    static void Main(string[] args)
    {
        // это функция мейн которая вызывает все отсальные функции для практики А и Б
        //вызов первой функци.... и т.п.
        

        Console.WriteLine(Task1(2, 3));

        Console.WriteLine(Task2(3));

        Console.WriteLine(Task3("Слово"));

        Console.WriteLine(Task4(1, 3, -5, 2, 3));

        Console.WriteLine(Task5(20000));

        Console.WriteLine(Task6(30));

        Console.WriteLine(Task7("Есть хочу"));

        Console.WriteLine(Task8("1234"));

    }
   
}
