namespace Practice3;

class Program
{
    static void Main(string[] args)
    {
        int a = 8;
        int r = 7;
        Console.WriteLine(max(a, r));
    }

    public static int max(int a, int b){
        if (a > b){
            return a;
        }
        else if (a < b){
            return b;
        }
        else{
            return a;
        }
    }
}
