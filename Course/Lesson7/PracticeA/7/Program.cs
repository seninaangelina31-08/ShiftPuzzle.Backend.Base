namespace _7;

class Program
{
    static void Main(string[] args)
    {
        int BB = 3;
        VVV(BB, 'A', 'C', 'B');
    }

    static void VVV(int n, int one, int two, int ther)
    {
        if (n == 1)
        {
            Console.WriteLine($"Переместить диск 1 из {one} на {two}");
            return;
        }

        VVV(n - 1, one, ther, two);
        Console.WriteLine($"Переместить диск {n} из {one} на {two}");
        VVV(n - 1, ther, two, one);
    }
}