namespace Practice2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(fibonachi(5));
    }

    public static int fibonachi(int a){
        if (a <= 2){
            return 1;
        }
        else{
            return fibonachi(a - 1) + fibonachi(a - 2);
        }
    }
}
