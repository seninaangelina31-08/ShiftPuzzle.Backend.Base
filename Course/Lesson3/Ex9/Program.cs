namespace Ex9;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[5];
        int n = arr.Length;
        Console.WriteLine("Введите 5 ваших любимых чисел.");
        for(int i=0; i<n; i++)
        {
            Console.Write($"Введите {i+1}-е число: ");
            arr[i] = Convert.ToInt16(Console.ReadLine());
        }
        Console.WriteLine("Вы ввели:");
        foreach(int i in arr)
        {
            Console.Write($"{i} ");
        }
    }
}
