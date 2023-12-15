namespace Practice4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(sumarray(5));
    }
    public static int sumarray(int a){

        int index = 1;
        if (a <= index){
            return 1;
        }
        else{
            return a + sumarray(a-1);
        }
    }
}
