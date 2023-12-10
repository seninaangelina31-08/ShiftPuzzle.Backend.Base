namespace Practice10;

class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Getrnum(a, b));
    }

    public static int Getrnum (int a, int b){
        Random rnum = new Random();
        int num = rnum.Next(a, b);
        return num;
    }
}
