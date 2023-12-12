namespace PracticeA;
class Program
{
    static int factorial(int a)
    {
        if (a <= 1)
            return 1;
        else
            return a * factorial(a-1);
    }
    static int fibanachi(int a)
    {
        if (a <= 2)
            return 1;
        else
            return fibanachi(a - 1) + fibanachi(a - 2);
    }
    static string reverse(string a)
    {
        if (a == "")
            return a;
        else
            return reverse(a.Substring(1)) + a[0];
    }
    static int sum_arr(int[] a)
    {
        int n = a.Length;
        if (n <= 0)
            return 0;
        else
            return sum_arr(a.SkipLast(1).ToArray()) + a[n - 1];
    }
    static int evklid(int a, int b)
    {
        if (a > b)
            return evklid(a-b, b);
        else if (b > a)
            return evklid(a, b-a);
        else
            return a;
    }
    static bool palindrom(string a)
    {
        int n = a.Length;
        if (n < 2)
            return true;
        if (a[0] != a[n - 1])
            return false;
        return palindrom(a.Substring(1, n-2));
    }
    static void hanoy(int n, string a = "Start", string b = "n", string c = "Finish")
    {
        if (n <= 0)
            return;
        hanoy(n-1, a, c, b);
        Console.WriteLine($"{n} диск с {a} на {b}");
        hanoy(n-1, c, b, a);
    }
    static void subarr(int[] arr, int a = 0, string s = "")
    {
        if (a == arr.Length)
        {
            Console.WriteLine(s);
            return;
        }
        subarr(arr, a+1, s);
        s = s + Convert.ToString(arr[a]) + ' ';
        subarr(arr, a+1, s);
    }
    static void swap(string[] a, int index = 0)
    {
        string temp = "";
        if (index == a.Length - 1)
            Console.WriteLine(String.Join("",a));
        for(int i = index; i < a.Length; i++)
        {
            temp = a[index];
            a[index] = a[i];
            a[i] = temp;
            swap(a, index + 1);
            temp = a[index];
            a[index] = a[i];
            a[i] = temp;
        }
    }
    static void Main(string[] args)
    {
        
    }
}
