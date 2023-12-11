    using System;

namespace LessonProject
{
    public class Task1
    {
        static Task1()
        {
            Console.WriteLine("Задача 1: Найти в массиве целых чисел первый подмассив длиной N, " +
                              "сумма элементов которого максимальна. Вывести найденный подмассив.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь
            int[] array = {42, 5, 51, 25, 58, 11, 13, 4, 23, 96, 7, 56};
            Console.Write("Введите длину подмассива: ");
            int N = int.Parse(Console.ReadLine()!);
            int[] maxArray = new int[N];
            int maxSum = 0;
            Console.WriteLine("Исходный массив: " + "[" + string.Join(", ", array) + "]");

            for (int i = 0; i < array.Length - N + 1; i++)
            {
                int tempSum = 0;
                int[] subArray = new int[N];
                for (int j = 0; j < N; j++)
                {
                    subArray[j] = array[i + j];
                    tempSum += array[i + j];
                }

                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    maxArray = subArray;
                }
            }
            Console.WriteLine("Подмассив с максимальной суммой элементов: " + "[" + string.Join(", ", maxArray) + "]");
            
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
            int[] array = {42, 5, 51, 25, 58, 11, 7, 13, 4, 23, 7, 56, 5};
    		Console.WriteLine("Массив до сортировки: [" + string.Join(", ", array) + "]");
    		Array.Sort(array);
    		Console.WriteLine("Массив после сортировки: [" + string.Join(", ", array) + "]");
    		int uniqueElements = array.Distinct().Count(); // метод Distinct() записывает в переменную только уникальные элементы массива, метод Count() подсчитывает количество элементов
    		Console.WriteLine($"Количество уникальных элементов = {uniqueElements}");
			//не выходя за пределы
        }
    }

    public class Task3
    {
        static Task3()
        {
            Console.WriteLine("\n\n\nЗадача 3: Анализировать массив целых чисел и определить число, которое встречается чаще всего." +
											"Если таких чисел несколько, вывести их все и указать, сколько раз каждое из них встречается в массиве.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь
            int[] arr = {42, 7, 5, 5, 51, 25, 58, 11, 7, 13, 4, 5, 23, 7, 56, 5, 7};

            int maxCount = 0;
            int[] counts = new int[arr.Max()+1];

            for (int i = 0; i < arr.Length; i++)
            {
                counts[arr[i]]++;
                if (counts[arr[i]] > maxCount)
                {
                    maxCount = counts[arr[i]];
                }
            }

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] == maxCount)
                {
                    Console.WriteLine($"Число {i} встречается {maxCount} раз(а)");
                }
            }
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
            int[] array = {1, 2, 3, 4, 5};
            int[] resArray = new int[array.Length];
            Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");
            Console.Write("Введите число позиций ротации: ");
            int K = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < array.Length; i++)
            {
                resArray[(i + K) % array.Length] = array[i];
            }

            Console.WriteLine("Массив с ротацией вправо на К позиций: [" + string.Join(", ", resArray) + "]");
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
            int[] arrayOne = {1, 2, 3, 4, 5, 11, 12, 13, 14};
            int[] arrayTwo = {3, 6, 7, 4, 8, 2, 9, 5, 10, 1};
            int[] mergedArray = arrayOne.Concat(arrayTwo).ToArray();
            int count = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    if (arrayOne[i] == arrayTwo[j]) count++;
                }
            }

            int[] resArray = new int[count];

            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    if (arrayOne[i] == arrayTwo[j]) resArray[i] = arrayOne[i];
                }
            }

            Console.WriteLine("Объединенные массивы [" + string.Join(", ", mergedArray) + "]");
            Console.WriteLine("Числа встречающиеся в обоих массивах: " + string.Join(" ", resArray));
            //не выходя за пределы
        }
    }
}
