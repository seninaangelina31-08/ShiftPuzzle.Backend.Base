namespace Practice9;

class Program
{
    static void Main(string[] args)
    {
        int a = 7;
        Console.WriteLine(IsPrime(a));
    }

    public static bool IsPrime(int a){
        for (int i = 2; i < a; i++){
            if (a % i == 0){
                return false;
            }
        }
        return true;
    }
}
