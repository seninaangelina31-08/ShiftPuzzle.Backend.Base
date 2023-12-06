namespace Homework;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] array1 = new int[10];
        int[] array2 = new int[array1.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = random.Next(1, 11);
            array2[i] = random.Next(1, 11);
        }

        int[] b = new int[array1.Length + array2.Length];

        for (int i = 0; i < b.Length; i++)
        {
            if (i < array1.Length)
            {
                b[i] = array1[i];
            } else {
                b[i] = array2[i - array1.Length];
            }
        }

        Console.WriteLine("Объединённый массив: " + string.Join(", ", b));

    }
}
