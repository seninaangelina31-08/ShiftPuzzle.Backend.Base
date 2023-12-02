namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {1, 2, 3, 4, 5} ;
        int sum = 0;

        foreach(int item in numbers)
        {
            sum += item;
        }
        
        Console.WriteLine(sum);
    }
}
