namespace PracticeA;

class Program
{
    public static int Factorial(int x)
    {
        if (x <= 1)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }

    public static int Fib(int n)
    {
        if (n <= 1) 
        {
            return n;
        }
        else 
        {
            return Fib(n - 1) + Fib(n - 2);
        }
    }  

    public static string Reverse(string str)
    {
        if (str.Length <= 1)
        {
            return str;
        }
        else
        {
            return Reverse(str.Substring(1)) + str[0];
        }
    }    

    public static int Sum(int[] array, int n)
    {
        if (n >= array.Length)
        {
            return 0;
        }
        else
        {
            return Sum(array, n + 1) + array[n];
        }
    }  
    
    public static int NOD(int x, int y)
    {
        if (x == y) return x;
            if (x > y)
            {
                return NOD(x - y, y);
            }

            return NOD(x, y - x);
        
    }

    public static bool Palindrome(string str)
    {
        if (str.Length <= 1) 
        {
            return true;
        }
        else if (str[0] != str[str.Length - 1]) 
        {
            return false;
        }
        else 
        {
            return Palindrome(str.Substring(1, str.Length - 2));
        }
    }

    public static void Hanoi(int n, char from_rod, char to_rod, char aux_rod)
{
    if (n == 1) 
    {
        Console.WriteLine($"Переместить диск 1 с {from_rod} на {to_rod}");
        return;
    }
    Hanoi(n - 1, from_rod, aux_rod, to_rod);
    Console.WriteLine($"Переместить диск {n} с {from_rod} на {to_rod}");
    Hanoi(n - 1, aux_rod, to_rod, from_rod);
}
     public static void GenerateSubsets(int[] set, int index = 0, string subset = "")
    {
        int n = set.Length;

        if (index == n)
        {
            Console.WriteLine("{" + subset + "}");
            return;
        }

        GenerateSubsets(set, index + 1, subset);
        GenerateSubsets(set, index + 1, subset + set[index] + ",");
    }
    public static void FindPermutations(int[] nums)
    {
        int[] permutation = new int[nums.Length];
        bool[] used = new bool[nums.Length];

        Permute(nums, permutation, used, 0);
    }

    public static void Permute(int[] nums, int[] permutation, bool[] used, int rec_depth)
    {
        if (rec_depth == nums.Length)
        {
            PrintPermutation(permutation);
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i] == false)
            {
                permutation[rec_depth] = nums[i];
                used[i] = true;
                Permute(nums, permutation, used, rec_depth + 1);
                used[i] = false;
            }
        }
    }

    public static void PrintPermutation(int[] permutation)
    {
        foreach (int num in permutation)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
     

    static void Main(string[] args)
    {
        //Task1
        Console.WriteLine($"Факториал: {Factorial(5)}");

        //Task2
        Console.WriteLine($"Число Фибоначчи: {Fib(6)}");

        //Task3
        Console.WriteLine($"Переворот строки: {Reverse("123")}");

        //Task4
        int[] array = {1, 2, 3};
        int n = 0;
        Console.WriteLine($"Сумма: {Sum(array, n)}");
        
        //Task5
        int nod = NOD(12, 8);
        Console.WriteLine($"НОД: {nod}");

        //Task6
        string str = "абоба";
        Console.WriteLine($"Палиндром: {Palindrome(str)}"); 

        //Task7
        Console.WriteLine("----Task7----");
        Hanoi(3, 'A', 'C', 'B');

        //Task8
        Console.WriteLine("----Task8----");
        int[] set = {1, 2, 3, 4};
        GenerateSubsets(set);

        //Task10
        Console.WriteLine("----Task10----");
        int[] nums = {1, 2, 3, 4};
        FindPermutations(nums);


    }
}
