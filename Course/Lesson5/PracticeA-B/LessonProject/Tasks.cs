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

            int[] array = {0, 0, 100000, 0, 1, 0};
            int n = 4;
            long max_sum = -10000000000;
            int start = 0;

            if (array.Length < n)
            {
                Console.WriteLine("Массив меньше числа N");
            }

            for (int i = 0; i <= array.Length - n; i++)
            {
                int cur_sum = 0;

                for (int j = i; j < i + n; j++)
                {
                    cur_sum += array[j];
        
                }

                if (cur_sum > max_sum)
                {
                    max_sum = cur_sum;
                    start = i;
                }

            }
            for (int i = start; i < start + n; i++ )
            {
                Console.Write(array[i] + " ");

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
            
            int[] array = {5, 2, 4, 7, 2, 3, 5, 8, 9, 1, 4, 6};
            
            Array.Sort(array);
            
            foreach (int number in array)
        {
            Console.WriteLine(number + " ");
        }
        
        int unique_сount = 1;
         for (int i = 1; i < array.Length; i++)
        {
            if (array[i] != array[i - 1])
            {
                unique_сount++;
            }
            
        }   
            Console.WriteLine("Число уникальных элементов: " + unique_сount);
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
            
            int[] numbers = { 4, 5, 2, 7, 8, 5, 2, 5, 4, 8, 6, 5, 4, 9, 5 }; // Пример массива
            int maxCount = 0;
            int popularNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    popularNumber = numbers[i];
                }
            }

            Console.WriteLine("Число, которое встречается чаще всего: " + popularNumber + " (встречается " + maxCount + " раз(а))");    

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
            
        int[] array = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;

        Console.WriteLine("Исходный массив:");
        foreach (var i in array)
        {
            Console.Write(i + " ");
        }

        int[] tempArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            tempArray[(i + k) % array.Length] = array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = tempArray[i];
        }

        Console.WriteLine("\nРезультирующий массив:");
        foreach (var i in array)
        {
            Console.Write(i + " ");
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

        int[] array1 = {1, 2, 3, 4, 5};
        int[] array2 = {3, 4, 5, 6, 7};
        
        int maxLength = array1.Length + array2.Length;
        int[] resultArray = new int[maxLength];
        
        int index = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            bool flag = true;
            for (int j = 0; j < resultArray.Length; j++)
            {
                if (resultArray[j] == array1[i])
                {
                    flag = false;
                }
            }
            if (flag)
            {
                resultArray[index] = array1[i];
                index++;
            }
        }
    
        for (int i = 0; i < array2.Length; i++)
        {
            bool flag = true;
            for (int j = 0; j < resultArray.Length; j++)
            {
                if (resultArray[j] == array2[i])
                {
                    flag = false;
                }
            }
            if (flag)
            {
                resultArray[index] = array1[i];
                index++;
            }
        }

        foreach (int num1 in array1)
        {
            bool found = false;
            foreach (int num2 in array2)
            {
                if (num1 == num2)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.Write(num1 + " ");
            }
        }
        }    
            //не выходя за пределы
    }   
}
