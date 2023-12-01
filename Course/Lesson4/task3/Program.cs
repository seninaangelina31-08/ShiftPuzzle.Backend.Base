namespace task3;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int n = numbers.Length;
        
        for (int i = 0; i < 1; ++i)
        {
            int x = numbers[i];
            numbers[i] = numbers[n-1-i];
            numbers[n-1-i] = x;
        foreach (int el in numbers)
        {
            Console.Write(el + " ");
            }
        }
        
        
        
       
    }
}

