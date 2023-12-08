namespace L4_HW_T1;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new();
        
        Console.WriteLine("Введите размер 1 массива");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите размер 2 массива");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int[] nums1 = new int[n1];
        int[] nums2 = new int[n2];

        // создание массива случайно
        for (int i = 0; i < n1; i++)
        {
            nums1[i] = generator.Next(20);
        }

        for (int i = 0; i < n2; i++)
        {
            nums2[i] = generator.Next(20);
        }
        // Объединение массиовов
        int[] mergedArray = new int[nums1.Length + nums2.Length];
        
        for (int i = 0; i < n1; i++)
        {
            mergedArray[i] = nums1[i];
        }

        for (int i = 0; i < n2; i++)
        {   

            mergedArray[i + nums1.Length] = nums2[i];
        }
        // вывод
        string numsStr = "{";
        foreach (int num in mergedArray)
        {
            numsStr += $"{num}, ";
        }
        Console.WriteLine(numsStr.Substring(0, numsStr.Length - 2) + "}");
        

    }
}
