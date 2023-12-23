using System;

namespace LessonProject
{
    public class Task1
    {
        static Task1()
        {
            Console.WriteLine("Задача 1: Найти в массиве целых чисел первый подмассив длиной N, сумма элементов которого максимальна. Вывести найденный подмассив.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь
            int[] arr = { 4, -3, 5, -2, -1, 2, 6, -2, 100 };
            int n = 2;

            int maksimum = int.MinValue;
            int startIndex = -1;

            for (int i = 0; i <= arr.Length - n; i++)
            {
                int currentSum = 0;
                for (int j = i; j < i + n; j++)
                {
                    currentSum += arr[j];
                }

                if (currentSum > maksimum)
                {
                    maksimum = currentSum;
                    startIndex = i;
                }
            }

            Console.Write("Maksimalnia summa {0}: [", n);
            for (int i = startIndex; i < startIndex + n; i++)
            {
                Console.Write(arr[i] + " ,");
            
            }
            Console.Write("0]");
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
            // -
            //не выходя за пределы
        }
    }

    public class Task3
    {
        static Task3()
        {
            Console.WriteLine("\n\n\nЗадача 3: Анализировать массив целых чисел и определить число, которое встречается чаще всего. Если таких чисел несколько, вывести их все и указать, сколько раз каждое из них встречается в массиве.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь

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
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = 2;

            int n = arr.Length;

            
            Array.Reverse(arr, 0, n);
            Array.Reverse(arr, 0, k);
            Array.Reverse(arr, k, n - k);
            Console.WriteLine(string.Join(", ", arr));
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

            //не выходя за пределы
        }
    }
}
