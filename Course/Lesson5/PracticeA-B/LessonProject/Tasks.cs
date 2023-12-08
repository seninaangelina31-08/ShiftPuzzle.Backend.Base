using System;
using System.Collections;
using System.IO.Compression;

namespace LessonProject
{
    public class Task1
    {
        static Task1()
        {
            Console.WriteLine("Задача 1: Найти в массиве целых чисел первый подмассив длиной N, сумма элементов которого максимальна. Вывести найденный подмассив.");
            Console.WriteLine("РЕШЕНИЕ:");
            int n = Int32.Parse (Console.ReadLine()), maxsum = -100000, temp = -10000, ind = 0;
            int[] arr = {1, 5, -9, 6, 7, 4, 5, -5, -3};
            for (int i = 0; i < 9-n-1; i++) {
                temp = 0;
                for (int j = i; j < i+n; j++) {
                    temp += arr[j];
                }
                if (temp > maxsum) {
                    maxsum = temp;
                    ind = i;
                }
            }
            for (int i = ind; i < ind + n; i++) {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
        }
    }

    public class Task2
    {
        static Task2()
        {
            Console.WriteLine("\n\n\nЗадача 2: Создать массив случайных чисел, сортировать его по возрастанию, затем найти количество уникальных чисел. Вывести отсортированный массив и количество уникальных чисел.");
            Console.WriteLine("РЕШЕНИЕ:");

            int[] arr = {1, 5, -9, 6, 7, 4, 5, -5, -3};
            int[] fin = new int[9];
            int cnt = 0;
            Array.Sort(arr);
            for (int i = 0; i < 9; i++) {
                Console.Write(arr[i]); Console.Write(' ');
            }
            var set = new HashSet<int>(arr);
            Console.Write('\n');
            foreach (var item in set) {
                cnt++;
            }
            Console.Write(cnt);
        }
    }

    public class Task3
    {
        static Task3()
        {
            Console.WriteLine("\n\n\nЗадача 3: Анализировать массив целых чисел и определить число, которое встречается чаще всего. Если таких чисел несколько, вывести их все и указать, сколько раз каждое из них встречается в массиве.");
            Console.WriteLine("РЕШЕНИЕ:");

            int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 5, 5};

            Dictionary<int, int> countDict = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (countDict.ContainsKey(num))
                {
                    countDict[num]++;
                }
                else
                {
                    countDict[num] = 1;
                }
            }

            int maxCount = 0;
            List<int> mostFrequentNumbers = new List<int>();

            foreach (var kvp in countDict)
            {
                if (kvp.Value > maxCount)
                {
                    maxCount = kvp.Value;
                    mostFrequentNumbers.Clear();
                    mostFrequentNumbers.Add(kvp.Key);
                }
                else if (kvp.Value == maxCount)
                {
                    mostFrequentNumbers.Add(kvp.Key);
                }
            }

            foreach (int num in mostFrequentNumbers)
            {
                Console.WriteLine(num + " occurs " + countDict[num] + " times");
            }
        }
    }

    public class Task4
    {
        static Task4()
        {
            Console.WriteLine("\n\n\nЗадача 4: Выполнить циклическую ротацию массива на K позиций вправо. Вывести исходный и измененный массивы.");
            Console.WriteLine("РЕШЕНИЕ:");
            int[]arr = {1, 2, 3, 4, 5};
            int n = arr.Length;
            int k = Int32.Parse (Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
            Console.Write('\n');
            int[] temp = new int[n];

            for (int i = 0; i < n; i++)
            {
                temp[(i + k) % n] = arr[i];
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = temp[i];
            }
            for (int i = 0; i < n; i++) {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
        }
        
    }
    

    public class Task5
    {
        static Task5()
        {
            Console.WriteLine("\n\n\nЗадача 5: Создать два отдельных массива целых чисел, объединить их в один и вывести числа, встречающиеся в обоих исходных массивах. В результирующем массиве каждое число должно встречаться только один раз.");
            Console.WriteLine("РЕШЕНИЕ:");

            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 3, 4, 5, 6, 7 };
            bool flag = true;
            int[] mergedArr = new int[arr1.Length+arr2.Length];
            for (int i = 0; i < arr1.Length; i++) {
                flag = true;
                for (int j = 0; j < mergedArr.Length; j++) {
                    if (arr1[i] == mergedArr[j]) {
                        flag = false;
                    }
                }
                if (flag) {
                    mergedArr[i] = arr1[i];
                }
            }
            for (int i = 0; i < arr2.Length; i++) {
                flag = true;
                for (int j = 0; j < mergedArr.Length; j++) {
                    if (arr2[i] == mergedArr[j]) {
                        flag = false;
                    }
                }
                if (flag) {    
                    mergedArr[i+arr1.Length] = arr2[i];
                }
            }
            for (int i = 0; i < arr1.Length; i++) {
                for (int j = 0; j < arr2.Length; j++) {
                    if (arr1[i] == arr2[j]) {
                        Console.Write(arr1[i]+" ");
                        break;
                    }
                }
            }
            Console.Write('\n');
            for (int i = 0; i < mergedArr.Length; i++) {
                if (mergedArr[i] != 0) {
                    Console.Write(mergedArr[i]+" ");
                }
            }
        }
    }
}
