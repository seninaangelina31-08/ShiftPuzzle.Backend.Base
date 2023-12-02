namespace Task10;

class Program
{
    static void Main(string[] args)
    {
        int[] garbage = { -1, -2, -3, 4, 0 };   
        for (int i = 0; i < garbage.Length; i++)
        {
            if (garbage[i] < 0)
            {
                garbage[i] = 0;
            }
        }
        Console.WriteLine("Массив после замены отрицательных элементиков:");
        for (int i = 0; i < garbage.Length; i++)
        {
            Console.WriteLine(garbage[i]);
        }
    }
}
