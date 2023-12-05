using System;

namespace LessonProject
{
    public class Task1
    {
        static Task1()
        {
            Console.WriteLine("Задача 1: Найти в массиве целых чисел первый подмассив длиной N, сумма элементов которого максимальна. Вывести найденный подмассив.");
            Console.WriteLine("РЕШЕНИЕ:");
             int[] arr = { 1, 2, 3, 4, -5, 6, -7, 8 };
             int N = 3;
             if (arr.Length < N)
            {
                Console.WriteLine("Размер массива меньше заданной длины N.");
                return;
            }

            int maxSum = int.MinValue;
            int maxSumIndex = 0;

            for (int i = 0; i <= arr.Length - N; i++)
            {
                int sum = 0;
            
                for (int j = i; j < i + N; j++)
            {
                sum += arr[j];
            }

            if (sum > maxSum)
            {
                maxSum = sum;
                maxSumIndex = i;
            }
            }

            int[] subarr = new int[N];
            Array.Copy(arr, maxSumIndex, subarr, 0, N);

            Console.WriteLine("Подмассив с максимальной суммой элементов:");
            foreach (int num in subarr)
            {
            Console.Write(num + " ");
            }
        }
    }

    public class Task2
    {
        static Task2()
        {
            Console.WriteLine("\n\n\nЗадача 2: Создать массив случайных чисел, сортировать его по возрастанию, затем найти количество уникальных чисел. Вывести отсортированный массив и количество уникальных чисел.");
            Console.WriteLine("РЕШЕНИЕ:");
             Random rand = new Random();
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
    
            {
            arr[i] = rand.Next(1, 100); 
            }

            Array.Sort(arr);

            HashSet<int> unicalNumbers = new HashSet<int>(arr);

            Console.WriteLine("Отсортированный массив:");
            foreach (int number in arr)
    
            {
            Console.Write(number + " ");
            }
            Console.WriteLine("\nКоличество уникальных чисел: " + unicalNumbers.Count);



        }
    }

    public class Task3
    {
        static Task3()
        {
            Console.WriteLine("\n\n\nЗадача 3: Анализировать массив целых чисел и определить число, которое встречается чаще всего. Если таких чисел несколько, вывести их все и указать, сколько раз каждое из них встречается в массиве.");
            Console.WriteLine("РЕШЕНИЕ:");

             {
            
            int[] arr = {1, 2, 3, 4, 6, 3, 2, 3, 5, 6, 7, 8, 2, 0};

            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int number in arr)
            {
    
                if (counts.ContainsKey(number))
                {
                counts[number]++;
                }
    
                else
                {
                counts[number] = 1;
                }
    
            }
            int maxCount = counts.Values.Max();

            Console.WriteLine("Числа, которые встречаются чаще всего:");
            foreach (var  chashe in counts)
            {
                if (chashe.Value == maxCount)
                {
                    Console.WriteLine("Число " + chashe.Key + " встречается " + chashe.Value + " раз.");
                }
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
            
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int K = 4;
            
            int[] rotatedArray = new int[arr.Length];
            
            for (int i = 0; i < arr.Length; i++)
            
            {
                int newIndex = (i + K) % arr.Length;
                rotatedArray[newIndex] = arr[i];
            }
            
            Console.WriteLine("Исходный массив:");
            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }
            
            Console.WriteLine("\nИзмененный массив:");
            foreach (int number in rotatedArray)
            {
                Console.Write(number + " ");
            }
        
        }
    }

    public class Task5
    {
        static Task5()
        {
            Console.WriteLine("\n\n\nЗадача 5: Создать два отдельных массива целых чисел, объединить их в один и вывести числа, встречающиеся в обоих исходных массивах. В результирующем массиве каждое число должно встречаться только один раз.");
            Console.WriteLine("РЕШЕНИЕ:");

        //решайте задачу здесь
        int[] arr1 = {1, 2, 3, 7, 5};
        int[] arr2 = {1, 8, 9, 3, 4};

        int[] result = arr1.Intersect(arr2).ToArray();

        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
}
}
}

