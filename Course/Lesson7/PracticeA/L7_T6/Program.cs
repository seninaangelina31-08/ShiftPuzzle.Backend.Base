namespace L7_T6;

class Program
{
    static bool isPalRec(String str, 
                         int s, 
                         int e)
    {
         
        if (s == e)
            return true;

        if ((str[s]) != (str[e]))
            return false;

        if (s < e + 1)
            return isPalRec(str, s + 1, 
                            e - 1);
             return true;
    }
 
    static bool isPalindrome(String str)
    {
        int n = str.Length;
 
        if (n == 0)
            return true;
 
        return isPalRec(str, 0, n - 1);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
