namespace PracticeA;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(fac(5));
        Console.WriteLine(fib(7));
        Console.WriteLine(reverse("улыбок тебе дед макар"));
        int[] a = { 0, 1, 2, 3, 4 };
        Console.WriteLine(sum(a, a.Length - 1));
        Console.WriteLine(nod(15, 10));
        Console.WriteLine(is_palindrom("дед"));
        hanoi(1, 2, 3);
        Subsets(a, 0, "");

    }
    static int fac(int n)
    {
        if (n <= 1){
            return 1;
        }
        return n * fac(n - 1);
    }
    static int fib(int n)
    {
        if (n <= 2){
            return 1;
        }
        return fib(n - 1) + fib (n - 2);
    }
    static string reverse(string str)
    {
        if (str.Length <= 1)
        {
            return str;
        }
        return reverse(str.Substring(1)) + str[0];
    }
    static int sum(int[] arr, int index)
    {
        if (index < 0)
        {
            return 0;
        }
        return arr[index] + sum(arr, index - 1);
                
    }
    static int nod(int a, int b)
    {
        if (b == 0){
            return a;
        }
        return nod(b, a % b);
    }
    static bool is_palindrom(string str)
    {
        if (str.Length <= 1)
        {
            return true;
        }
        else
        {
            if (str[0] != str[str.Length - 1])
            {
                return false;
            }
            return is_palindrom(str.Substring(1, str.Length - 2));
        }
    }
    static void hanoi(int n, int fromPeg, int toPeg)
    {
        if (n == 1)
        {
            Console.WriteLine("Move disk from peg " + fromPeg + " to peg " + toPeg);
            return;
        }
        int unusedPeg = 6 - fromPeg - toPeg;
        hanoi(n - 1, fromPeg, unusedPeg);
        Console.WriteLine("Move disk from peg " + fromPeg + " to peg "+ toPeg);
        hanoi(n - 1, unusedPeg, toPeg);
    }
    static void Subsets(int[] arr, int index, string subset)
    {
        if (index == arr.Length)
        {
            Console.WriteLine(subset);
            return;
        }
        Subsets(arr, index + 1, subset);
        Subsets(arr, index + 1, subset + " " + arr[index]);
    }
    
}
