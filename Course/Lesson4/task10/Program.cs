namespace task10;

class Program
{
    static void Main(string[] args)
    {
        
        int[] arr = { 1, -2, -3, 4, 5, -6 };
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                arr[i] = 0;
            }
            }
            Console.Write("Новый массив: ");
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
        }

}

