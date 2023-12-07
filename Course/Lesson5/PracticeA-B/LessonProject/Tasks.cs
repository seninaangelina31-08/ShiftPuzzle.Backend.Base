using System;

namespace LessonProject
{
    public class Task1
    {
        static Task1()
        {
            Console.WriteLine("Задача 1: Найти в массиве целых чисел первый подмассив длиной N, сумма элементов которого максимальна. Вывести найденный подмассив.");
            Console.WriteLine("РЕШЕНИЕ: ");

            int[] numbers = {-1, 2, 3, 4, 5, 6, 7, 8};
            int n = 4;
            int max_sum = numbers[0];
            int first_index = 0;

            for (int i = 0; i <= numbers.Length - n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += numbers[i + j];
                }
                if (sum > max_sum)
                {
                    max_sum = sum;
                    first_index = i;
                }
            }

            int[] numbers2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers2[i] = numbers[first_index + i];
            }

            Console.WriteLine($"Подмассив с максимальной суммой: ");
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }
        }
    }

    public class Task2
    {
        static Task2()
        {
            Console.WriteLine("\n\n\nЗадача 2: Создать массив случайных чисел, сортировать его по возрастанию, затем найти количество уникальных чисел. Вывести отсортированный массив и количество уникальных чисел.");
            Console.WriteLine("РЕШЕНИЕ:");

            int[] array = {-1, 0, 5, 1, 2, 4, 6, 3, 4};
        
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int g = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = g;
                    }
                }
            }

            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            int unique = 0;
        
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    unique++;
                }
            }
            Console.WriteLine($"Количество уникальных элементов: {unique}");
        }
    }

    public class Task3
    {
        static Task3()
        {
            Console.WriteLine("\n\n\nЗадача 3: Анализировать массив целых чисел и определить число, которое встречается чаще всего. Если таких чисел несколько, вывести их все и указать, сколько раз каждое из них встречается в массиве.");
            Console.WriteLine("РЕШЕНИЕ:");

            int[] numbers = {1, 2, 3, 4, 5, 4, 5, 4};
            int max_cnt = 0;
            int often_number = 0;

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

                if (count > max_cnt)
                {
                    max_cnt = count;
                    often_number = numbers[i];
                }
            }

            Console.WriteLine($"Число: {often_number}. Кол-во раз: {max_cnt}");
        }
    }

    public class Task4
    {
        static Task4()
        {
            Console.WriteLine("\n\n\nЗадача 4: Выполнить циклическую ротацию массива на K позиций вправо. Вывести исходный и измененный массивы.");
            Console.WriteLine("РЕШЕНИЕ:");

            int[] array = { 1, 2, 3, 4, 5 };
            int k = 2;

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            int[] g = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                g[(i + k) % array.Length] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = g[i];
            }

            Console.WriteLine("Измененный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

    public class Task5
    {
        static Task5()
        {
            Console.WriteLine("\n\n\nЗадача 5: Создать два отдельных массива целых чисел, объединить их в один и вывести числа, встречающиеся в обоих исходных массивах. В результирующем массиве каждое число должно встречаться только один раз.");
            Console.WriteLine("РЕШЕНИЕ:");

            int[] array1 = { 1, 2, 3, 4, 5, 0 };
            int[] array2 = { 1, 7, 8, 5, 5, 2, 0 };

            int[] intersectionArray = new int[array1.Length];
            int intersectionLength = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    intersectionArray[intersectionLength] = array1[i];
                    intersectionLength++;
                }
            }
        
            Console.WriteLine("Числа, встречающиеся в обоих массивах:");
            for (int i = 0; i < intersectionLength; i++)
            {
                Console.WriteLine(intersectionArray[i]);
            }
        }
    }
}
