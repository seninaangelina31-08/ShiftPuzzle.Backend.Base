namespace L7_T2;

class Program
{
    public static int Fibonachi(int num)
    {
        if (num == 0 || num == 1) return num;
        else return Fibonachi(num - 1) + Fibonachi(num - 2);
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Введите n-ое число Фибоначии");
        int answer = Fibonachi(Convert.ToInt16(Console.ReadLine()));
        Console.WriteLine(answer);
    }
}
