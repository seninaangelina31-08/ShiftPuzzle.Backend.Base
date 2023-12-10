namespace Practice4;

class Program
{
    static void Main(string[] args)
    {
        int a = 57;
        Console.WriteLine(chet(a));
    }

    public static bool chet(int a){
        if (a % 2 == 0){
            return true;
        }
        else{
            return false;
        }
    }
}
