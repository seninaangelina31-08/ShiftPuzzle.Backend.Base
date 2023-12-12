namespace task5;

class Program
{
    static void Main(string[] args)
    {
        int num1=12, num2=36;
        int gcd = Euclid(num1, num2);
        Console.WriteLine(gcd);
    }
    public static int Euclid(int a, int b)
    {
        if (b == 0)
            return a;
        else
            return Euclid(b, a % b);
    }
}
