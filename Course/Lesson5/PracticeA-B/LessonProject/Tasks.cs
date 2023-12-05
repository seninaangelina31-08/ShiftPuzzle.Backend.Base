using System;

namespace LessonProject
{
    public class Task1
    {
        static Task1()
        {
            Console.WriteLine("Задача 1: Найти в массиве целых чисел первый подмассив длиной N, сумма элементов которого максимальна. Вывести найденный подмассив.");
            Console.WriteLine("РЕШЕНИЕ:");

            int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int N = 4; 

            int maxSum = -10000;
            int startIndex = 0;

            for (int i = 0; i <= array.Length - N; i++)
            {
                int sum = 0;
                for (int j = i; j < i + N; j++)
                {
                    sum += array[j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    startIndex = i;
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(array[startIndex + i] + " ");
            }
        }
    }

    public class Task2
    {
        static Task2()
        {
            Console.WriteLine("\n\n\nЗадача 2: Создать массив случайных чисел, сортировать его по возрастанию, затем найти количество уникальных чисел. Вывести отсортированный массив и количество уникальных чисел.");
            Console.WriteLine("РЕШЕНИЕ:");

            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 11);
            }
            Array.Sort(array);
            Console.WriteLine("Отсортированный массив: " + string.Join(", ", array));
            int cnt_uniq = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int cnt = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        cnt++;
                    }
                }
                if (cnt == 1){
                    cnt_uniq++;
                }
            }
            Console.WriteLine(cnt_uniq);
        }
    }

    public class Task3
    {
        static Task3()
        {
            Console.WriteLine("\n\n\nЗадача 3: Анализировать массив целых чисел и определить число, которое встречается чаще всего. Если таких чисел несколько, вывести их все и указать, сколько раз каждое из них встречается в массиве.");
            Console.WriteLine("РЕШЕНИЕ:");

            Random random = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 11);
            }

            Console.WriteLine("Исходный массив: " + string.Join(", ", array));

            int max_cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int cnt = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        cnt++;
                    }
                }
                if (cnt > max_cnt){
                    max_cnt = cnt;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                int cnt = 0;
                if (Array.IndexOf(array, array[i]) == i)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            cnt++;
                        }
                    }
                    if (cnt == max_cnt){
                        Console.WriteLine(array[i]);
                        Console.WriteLine("Количество вхождений: " + Convert.ToString(max_cnt));
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

            Random random = new Random();
            int[] array = new int[10];
            int k = 3;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 11);
            }

            Console.WriteLine("Исходный массив: " + string.Join(", ", array));

            int[] b = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {   
                if (i + k >= array.Length)
                {
                    b[(i + k) - array.Length] = array[i];
                } else
                {
                    b[i + k] = array[i];
                }
            }

            Console.WriteLine("Измененный массив: " + string.Join(", ", b));
        
        }
    }

    public class Task5
    {
        static Task5()
        {
            Console.WriteLine("\n\n\nЗадача 5: Создать два отдельных массива целых чисел, объединить их в один и вывести числа, встречающиеся в обоих исходных массивах. В результирующем массиве каждое число должно встречаться только один раз.");
            Console.WriteLine("РЕШЕНИЕ:");

            Random random = new Random();
            int[] array1 = new int[10];
            int[] array2 = new int[array1.Length];
            

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(1, 11);
                array2[i] = random.Next(1, 11);
            }
            Console.WriteLine("Объединённый массив: " + string.Join(", ", array1));
            Console.WriteLine("Объединённый массив: " + string.Join(", ", array2));
            int count = 0;

            Console.Write("Повторы: ");
            for (int i = 0; i < array1.Length; i++) {

                for (int j = 0; j < array2.Length; j++){
                    if (array1[i] == array2[j]) {
                        count++;
                        Console.Write(array1[i] + " ");
                    }
                }
            }

            int[] b = new int[array1.Length * 2];
            int new_index = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (Array.IndexOf(b, array1[i]) == -1)
                {
                    b[new_index] = array1[i];
                    new_index++;
                }
            }
            for (int i = 0; i < array2.Length; i++)
            {
                if (Array.IndexOf(b, array2[i]) == -1)
                {
                    b[new_index] = array2[i];
                    new_index++;
                }
            }
            int[] c = new int[new_index];
            for (int i = 0; i < new_index; i++)
            {
                c[i] = b[i];
            }
            Console.WriteLine("\nОбъединённый массив: " + string.Join(", ", c));
        }
    }
}
