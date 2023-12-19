namespace L7_T4;

class Program
{
    static int FindSum(int []A, int N) 
    { 
        if (N <= 0) 
            return 0; 
        return (FindSum(A, N - 1) + A[N - 1]); 
    } 
        


    static void Main(string[] args)
    {   
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt16(Console.ReadLine());
        
        Random generator = new();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = generator.Next(-100, 100);
        }

        // вывод
        string numsStr = "{";
        foreach (int num in array)
        {
            numsStr += $"{num}, ";
        }
        Console.WriteLine(numsStr[..^2] + "}");
        
        Console.WriteLine($"Сумма элементов массива = {FindSum(array, array.Length)}");
    }
}
