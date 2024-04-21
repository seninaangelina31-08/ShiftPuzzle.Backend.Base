using System;

namespace LessonProject
{
    public class Task1
    {
        static Task1()
        {
            Console.WriteLine("Задача 1: Найти в массиве целых чисел первый подмассив длиной N, сумма элементов которого максимальна. Вывести найденный подмассив.");
            Console.WriteLine("РЕШЕНИЕ:");

         using System;
using System.Linq;

class MainClass {
    public static void Main (string[] args) {
        int[] array = {1, -3, 4, -2, -1, 6, -5, 8};

        int N = 3; // длина подмассива
        int maxSum = int.MinValue;
        int[] maxSubarray = new int[N];

        for (int i = 0; i <= array.Length - N; i++) {
            int sum = array.Skip(i).Take(N).Sum();
            if (sum > maxSum) {
                maxSum = sum;
                maxSubarray = array.Skip(i).Take(N).ToArray();
            }
        }

        Console.WriteLine("Подмассив с максимальной суммой: [" + string.Join(", ", maxSubarray) + "]");
    }
}

        }
    }

    public class Task2
    {
        static Task2()
        {
            Console.WriteLine("\n\n\nЗадача 2: Создать массив случайных чисел, сортировать его по возрастанию, затем найти количество уникальных чисел. Вывести отсортированный массив и количество уникальных чисел.");
            Console.WriteLine("РЕШЕНИЕ:");

           using System;
using System.Linq;

class MainClass {
    public static void Main (string[] args) {
        Random random = new Random();
        int[] array = Enumerable.Range(1, 10).Select(x => random.Next(1, 10)).ToArray(); // создаем массив случайных чисел
        Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");

        Array.Sort(array);
        
        int uniqueCount = array.Distinct().Count();
        Console.WriteLine("Отсортированный массив: [" + string.Join(", ", array) + "]");
        Console.WriteLine("Количество уникальных элементов: " + uniqueCount);
    }
}

        }
    }

    public class Task3
    {
        static Task3()
        {
            Console.WriteLine("\n\n\nЗадача 3: Анализировать массив целых чисел и определить число, которое встречается чаще всего. Если таких чисел несколько, вывести их все и указать, сколько раз каждое из них встречается в массиве.");
            Console.WriteLine("РЕШЕНИЕ:");

           using System;
using System.Linq;
using System.Collections.Generic;

class MainClass {
    public static void Main (string[] args) {
        int[] array = {2, 3, 5, 3, 7, 3, 5, 8, 3, 5};

        Dictionary<int, int> count = new Dictionary<int, int>();
        foreach (int num in array) {
            if (count.ContainsKey(num))
                count[num]++;
            else
                count[num] = 1;
        }

        int maxCount = count.Max(x => x.Value);
        var mostFrequent = count.Where(x => x.Value == maxCount).Select(x => x.Key).ToList();
        
        Console.WriteLine("Число(а), которое встречается чаще всего: " + string.Join(", ", mostFrequent) + ". Повторяется " + maxCount + " раз(а).");
    }
}

        }
    }

    public class Task4
    {
        static Task4()
        {
            Console.WriteLine("\n\n\nЗадача 4: Выполнить циклическую ротацию массива на K позиций вправо. Вывести исходный и измененный массивы.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь

            using System;

class Program
{
    static void Main(string[] args)
    {
        // Входные данные
        int[] array = { 1, 2, 3, 4, 5 };
        int k = 2;

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        RotateArray(array, k);

        Console.WriteLine("Измененный массив:");
        PrintArray(array);

        Console.ReadLine();
    }

    static void RotateArray(int[] array, int k)
    {
        
        if(k < 0)
        {
            Console.WriteLine("k должно быть положительным числом.");
            return;
        }

        int length = array.Length;

        
        if(k % length == 0)
        {
            return;
        }

        
        k = k % length;


        int[] tempArray = new int[k];
        
        
        Array.Copy(array, length - k, tempArray, 0, k);

        
        Array.Copy(array, 0, array, k, length - k);

        
        Array.Copy(tempArray, 0, array, 0, k);
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}


            //не выходя за пределы
        
        }
    }

    public class Task5
    {
        static Task5()
        {
            Console.WriteLine("\n\n\nЗадача 5: Создать два отдельных массива целых чисел, объединить их в один и вывести числа, встречающиеся в обоих исходных массивах. В результирующем массиве каждое число должно встречаться только один раз.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь

            using System;

class Program
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 4, 5, 6, 7, 8 };

        int[] mergedArray = MergeArrays(array1, array2);

        int[] resultArray = GetDistinctNumbers(mergedArray);

        Console.WriteLine("Числа, встречающиеся в обоих массивах:");
        foreach (int num in resultArray)
        {
            Console.WriteLine(num);
        }
    }

    static int[] MergeArrays(int[] array1, int[] array2)
    {
        int[] mergedArray = new int[array1.Length + array2.Length];

        Array.Copy(array1, mergedArray, array1.Length);
        Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length);

        return mergedArray;
    }

    static int[] GetDistinctNumbers(int[] array)
    {
        int[] distinctArray = array.Distinct().ToArray();
        return distinctArray;
    }
}

        }
    }
}
