namespace A;
public class A
{
    public static int factorial(int num)
    {
        if (num == 0)
            return 1;
    
        
        return num * factorial(num - 1);
    }

    static int fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return fibonacci(n - 1) + fibonacci(n - 2);
    }

   static string RString(string str)
    {
        if (str.Length <= 1)
        {
            return str;
        }

        return RString(str.Substring(1)) + str[0];
    }

    static int sum(int[] m, int index)
    {
        if (index >= m.Length) 
        {
            return 0;
        }
        
        return m[index] + sum(m, index + 1);
    }

    static int nod(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return nod(b, a % b);
        }
    }

    public static bool palindrome(string str)
    {
    if (str.Length <= 1)
        return true;
    
    if (str[0] != str[str.Length - 1])
        return false;

    return palindrome(str.Substring(1, str.Length - 2));
    }

    public static void tower(int n, char a, char b, char c)
        {
            if (n < 2)
                Console.Write(a.ToString() + "->" + c.ToString() + "|");
            else
            {
                tower(n - 1, a, c, b);
                Console.Write(a.ToString() + "->" + c.ToString() + "|");
                tower(n - 1, b, a, c);
            }
        }


    public static void subsets(int[] a, int index = 0, string str = "")
        {
            if (index == a.Length)
            {
                Console.WriteLine("[" + str + "]");
                return;
            }

            subsets(a, index + 1, str);
            subsets(a, index + 1, str + a[index] + ",");

        }

    // 9
    

    public static void FindPermutations(int[] nums)
    {
        int[] permutation = new int[nums.Length];
        bool[] used = new bool[nums.Length];

        p(nums, permutation, used, 0);
    }
    public static void p(int[] nums, int[] permutation, bool[] used, int rec_depth)
    {
        if (rec_depth == nums.Length)
        {
            printP(permutation);
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i] == false)
            {
                permutation[rec_depth] = nums[i];
                used[i] = true;
                p(nums, permutation, used, rec_depth + 1);
                used[i] = false;
            }
        }
    }
    public static void printP(int[] permutation)
    {
        foreach (int num in permutation)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}