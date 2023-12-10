namespace Practice8;

class Program
{
    static void Main(string[] args)
    {
        int a = 4;
        Console.WriteLine(Factorial(a));
    }

    public static int Factorial(int a){
        if (a == 0)
            return 1;
        return a*Factorial(a-1);
    }
}
