using System.Formats.Asn1;

namespace PracticeB_С;

class Program
{
    public static int[] MaxSubArray(int[] nums)
    {
        int size = nums.Length;
        if (size <= 1) return nums; 

        int maxSoFar = int.MinValue;
        int maxEndingHere = 0;

        int start = 0, end = 0;
        int beg = 0;

        for (int i = 0; i < size; i++)
        {
            maxEndingHere += nums[i];

            if (maxEndingHere < nums[i])
            {
                maxEndingHere = nums[i];
                beg = i;
            }

            if (maxSoFar < maxEndingHere)
            {
                maxSoFar = maxEndingHere;
                start = beg;
                end = i;
            }
        }

        int[] answer = new int[end - start + 1];
        Array.ConstrainedCopy(nums, start, answer, 0, end - start + 1);
        return answer;
    }

    static IEnumerable<IEnumerable<T>> 
    GetPermutationsWithRept<T>(IEnumerable<T> list, int length)
    {
        if (length == 1) return list.Select(t => new T[] { t });
        return GetPermutationsWithRept(list, length - 1)
            .SelectMany(t => list, 
                (t1, t2) => t1.Concat(new T[] { t2 }));
    }


    static void Main(string[] args)
    {   
        // Первая функция
        Console.WriteLine("Первая функция");
        Console.WriteLine();
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt16(Console.ReadLine());
        
        Random generator = new();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = generator.Next(-100, 100);
        }

        // вывод
        int[] answer = MaxSubArray(array);
        string numsStr = "{";
        foreach (int num in array)
        {
            numsStr += $"{num}, ";
        }
        Console.WriteLine(numsStr.Substring(0, numsStr.Length - 2) + "}");
        numsStr = "{";
        foreach (int num in answer)
        {
            numsStr += $"{num}, ";
        }
        Console.WriteLine(numsStr.Substring(0, numsStr.Length - 2) + "}");


        // Вторая функция
        Console.WriteLine("Вторая функция");
        Console.WriteLine();
        Console.WriteLine("Введите размер массива");
        int size2 = Convert.ToInt16(Console.ReadLine());
        
        Random generator2 = new();
        int[] array2 = new int[size2];

        for (int i = 0; i < size2; i++)
        {
            array2[i] = generator2.Next(-100, 100);
        }

        // вывод
        numsStr = "{";
        foreach (int num in array2)
        {
            numsStr += $"{num}, ";
        }
        Console.WriteLine(numsStr.Substring(0, numsStr.Length - 2) + "}");

        foreach (var arr in GetPermutationsWithRept(array2, size2))
        {   
            numsStr = "{";
            foreach (var num in arr)
            {
                numsStr += $"{num}, ";
            }
            Console.WriteLine(numsStr.Substring(0, numsStr.Length - 2) + "}");
        }



    }
}
