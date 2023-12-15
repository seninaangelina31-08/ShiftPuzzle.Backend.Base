namespace Practice5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(EvclidAlg(1071, 462));
    }

    public static int EvclidAlg(int a, int b){
        if (a % b <= 0){
            return b;
        }
        else{
            return EvclidAlg(b, a % b);
        }
    }
}
