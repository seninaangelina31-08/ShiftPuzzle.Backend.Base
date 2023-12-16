namespace _4;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 5, 6, 5, 5, 5, 2, };
        int sum = nymnum(arr, 0);
        Console.WriteLine("Сумма элементов массива: " + sum);
    }

    static int nymnum(int[] nym, int num)
    {
        if (num == nym.Length)
        {
            return 0;
        }
        else
        {
            return nym[num] + nymnum(nym, num + 1);
        }
    }
}