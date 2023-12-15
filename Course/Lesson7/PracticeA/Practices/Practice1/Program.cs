namespace Practice1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(factorial(5));
    }
    public static int factorial(int a){

        int index = 1;
        if (a <= index){
            return 1;
        }
        else{
            return a*factorial(a-1);
        }
    }
}
