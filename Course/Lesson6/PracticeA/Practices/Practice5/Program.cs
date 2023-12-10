namespace Practice5;

class Program
{
    static void Main(string[] args)
    {
        int a = 6;
        Console.WriteLine(Faren(a));
    }

    public static double Faren(int a){
        return (a*1.8 + 32);
    }
}
