using System;
using System.Collections;

namespace LessonProject
{
    public class Task1
    {
        static Task1()
        {
            Console.WriteLine("Задача 1: Найти в массиве целых чисел первый подмассив длиной N, сумма элементов которого максимальна. Вывести найденный подмассив.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь
            int[] arr = {1,2,3,4,5,6,7,8,9,0};
            int N = 3;
            Array.Sort(arr);
            int[] output = new int[N];
            for(int i = 0; i < N; i++)
            {
                output[i] = arr[arr.Length-1-i];
            }

            foreach(int a in output){
                Console.WriteLine(a);
            }
            //не выходя за пределы
        }
    }

    public class Task2
    {
        static Task2()
        {
            Console.WriteLine("\n\n\nЗадача 2: Создать массив случайных чисел, сортировать его по возрастанию, затем найти количество уникальных чисел. Вывести отсортированный массив и количество уникальных чисел.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь
            int[] arr = { 4, 7, 1, 8, 1, 7 };
            HashSet<int> uniqueHash = new HashSet<int>();
            Array.Sort(arr);

            foreach (int a in arr)
            {
                uniqueHash.Add(a);
                Console.WriteLine(a);
            }
            Console.WriteLine("\n\nУникальныйх чисел: " + uniqueHash.Count());
        }
    }

    public class Task3
    {
        static Task3()
        {
            Console.WriteLine("\n\n\nЗадача 3: Анализировать массив целых чисел и определить число, которое встречается чаще всего. Если таких чисел несколько, вывести их все и указать, сколько раз каждое из них встречается в массиве.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь
            int[] inpArray = {1, 3, 7,1,7,4,12,4,1};

            int maxNumCount = 0;
            HashSet<int> verifiedNumber = new HashSet<int>();
            List<int> numberSameCount = new List<int>();
            for (int i = 0; i < inpArray.Length; i++) 
            {
                if (!verifiedNumber.Contains(inpArray[i]))
                {
                    int maxNumCountNow = 0;
                    for (int j = i; j < inpArray.Length; j++)
                    {
                        if (inpArray[i] == inpArray[j])
                        {
                            maxNumCountNow++;
                        }
                    }

                    verifiedNumber.Add(inpArray[i]);
                    if (maxNumCountNow > maxNumCount)
                    {
                        maxNumCount = maxNumCountNow;
                        numberSameCount = new List<int> { inpArray[i] };
                    }
                    else if (maxNumCountNow == maxNumCount)
                    {
                        numberSameCount.Add(inpArray[i]);
                    }
                }
            }

            foreach (int item in numberSameCount)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("встречаеться " + maxNumCount + " раз");
                        //не выходя за пределы
        }
    }

    public class Task4
    {
        static Task4()
        {
            Console.WriteLine("\n\n\nЗадача 4: Выполнить циклическую ротацию массива на K позиций вправо. Вывести исходный и измененный массивы.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь
            int[] array = { 1, 2, 3, 4, 5 };
            int k = 2;

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            RotateArray(array, k);

            Console.WriteLine("Массив после циклической ротации на " + k + " позиций вправо:");
            PrintArray(array);
            //не выходя за пределы
        
        }
        static void RotateArray(int[] array, int k)
        {
            int n = array.Length;
            k = k % n;

            ReverseArray(array, 0, n - 1);
            ReverseArray(array, 0, k - 1);
            ReverseArray(array, k, n - 1);
        }

        static void ReverseArray(int[] array, int start, int end)
        {
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
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

    public class Task5
    {
        static Task5()
        {
            Console.WriteLine("\n\n\nЗадача 5: Создать два отдельных массива целых чисел, объединить их в один и вывести числа, встречающиеся в обоих исходных массивах. В результирующем массиве каждое число должно встречаться только один раз.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };

            Console.WriteLine("Первый массив:");
            PrintArray(array1);
            Console.WriteLine("Второй массив:");
            PrintArray(array2);

            var commonNumbers = array1.Intersect(array2).Distinct().ToArray();

            Console.WriteLine("Числа, встречающиеся в обоих массивах:");
            PrintArray(commonNumbers);
            //не выходя за пределы
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
}
