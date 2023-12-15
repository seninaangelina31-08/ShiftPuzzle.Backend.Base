namespace PracticeAB;

class Program
{

    
    // Творим тут
    //Task1
    public static int Task1(int x, int y)
    {
        return x + y;
    }
    
    //Task2
    public static bool Task2(int x)
    {
        if (x % 2 == 0)
        {
            return true;
        }
        return false;
    }

    //Task3
    public static string Task3(string str)
    {
        char[] char_array = str.ToCharArray();
        Array.Reverse(char_array);
        string rev = "";
        foreach (char el in char_array)
        {
            rev = rev + el;
        }
        return rev;
    }

    //Task4

    public static int Task4(int[] array)
    {
        return array.Max();
    }
    
    //Task5
    public static int Task5(int sallary)
    {
        return sallary * 12;
    }

    //Task 6
    public static double Task6(double celsius)
    {
        return celsius * 9/5 + 32;
    }

    //Task7
    public static int Task7(string str)
    {
        string vowels = "аАеЕиИоОуУыЫэЭюЮяЯaAeEiIoOuUyY";
        int count = 0;
        foreach (char el in str)
        {
            foreach (char glasn in vowels)
            {
                if (el == glasn)
                {
                    count++;
                }
            }
        }
        return count;
        
    }
    public static int Task8(string passtohack)
    {   
        int counter = 0;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int l = 0; l < 10; l++)
                    {
                        counter++;
                        string pass = Convert.ToString(i) + Convert.ToString(j) + Convert.ToString(k) + Convert.ToString(l);
                        if (passtohack == pass)
                        {
                            return counter;
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
        Console.WriteLine(Task3("ABC"));

        int[] array = {1, 2, 3, 4, 5};
        Console.WriteLine(Task4(array));
        Console.WriteLine(Task5(50000));

        //Practice B
        Console.WriteLine(Task6(10));
        Console.WriteLine(Task7("В строке пять гласных"));
        Console.WriteLine(Task8("0001"));


    }
}
