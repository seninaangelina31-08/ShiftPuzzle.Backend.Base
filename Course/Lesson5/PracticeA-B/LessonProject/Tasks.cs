using System;
using System.Linq;
using System.Collections.Generic;

namespace LessonProject
{
    public class Task1
    {
        static Task1()
        {
            Console.WriteLine("Задача 1: Найти в массиве целых чисел первый подмассив длиной N, сумма элементов которого максимальна. Вывести найденный подмассив.");
            Console.WriteLine("РЕШЕНИЕ:");

            //решайте задачу здесь

            int[] numbers = {9, -5, -4, 6, 7, 9, -4, 3, 2, 1};
            Console.Write("Введите N: ");

            int N = Convert.ToInt32(Console.ReadLine());
            int max_index = 0;
            int max_sum = 0;
            int current_sum;

            for (int i=0; i < numbers.Length - N + 1; ++i) {
                current_sum = 0;
                for (int j=i; j < i + N; ++j) {
                    current_sum += numbers[j];
                }
 
                if (max_sum < current_sum) {
                    max_sum = current_sum;
                    max_index = i;
                }
            }
 
            Console.Write("Подмассив: ");
            for (int i=max_index; i < max_index + N; ++i)
                Console.Write($"{numbers[i]} ");
            Console.WriteLine();

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

            Random rnd = new Random();

            int[] numbers = new int[rnd.Next(5, 10)];

            for(int i=0; i < numbers.Length; ++i) {
                numbers[i] = rnd.Next(10);
            }

            Array.Sort(numbers);

            Console.Write($"Отсортированный массив: ");
            foreach(int number in numbers) {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            int unique_numbers = 0;
            bool was_found = false;

            for(int i=0; i < numbers.Length; ++i) {
                was_found = false;

                for (int j=0; j < numbers.Length; ++j) {
                    if (i != j && numbers[i] == numbers[j]) {
                        was_found = true;
                        break;
                    }
                }

                if (!was_found) {
                    ++unique_numbers;
                };
            }
            Console.WriteLine($"Уникальных элементов в массиве: {unique_numbers}");
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

            int[] numbers = {4, 45, 45, 3, 3, 0, 1, 32, 100, 777, 454, 111};
            var grouped_numbers = numbers.GroupBy(x => x);

            grouped_numbers = grouped_numbers.OrderByDescending(x => x.Count());
            int last_frequency = grouped_numbers.First().Count();

            foreach (IGrouping<int, int> group in grouped_numbers) {
                if (group.Count() < last_frequency) {
                    break;
                }
                Console.WriteLine($"Число \"{group.Key}\" встречается {group.Count()} раз(а)");
                last_frequency = group.Count();
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
            int[] numbers = {1, 2, 3, 4, 5};
            int[] rotated_numbers = new int[5];

            Console.Write("Введите k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            
            for (int i=0; i < numbers.Length; i++)
            {
                rotated_numbers[(i + k) % numbers.Length] = numbers[i];
            }
            
            Console.Write("Исходный массив: ");
            foreach (int number in numbers) {
                Console.Write($"{number} ");
            };
            Console.WriteLine();
            
            Console.Write($"Массив со сдвигом {k} вправо: ");
            foreach (int number in rotated_numbers) {
                Console.Write($"{number} ");
            };
            Console.WriteLine();
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

            int[] numbers_1 = {1, 2, 3, 4, 5};
            int[] numbers_2 = {3, 4, 5, 6, 7};
            int[] result = new int[numbers_1.Length + numbers_2.Length];

            numbers_1.CopyTo(result, 0);
            numbers_2.CopyTo(result, numbers_1.Length);

            result = result.Distinct().ToArray();

            Console.Write("Итоговый массив: ");
            foreach(int number in result) {
                Console.Write($"{number} ");
            }

            Console.Write("В массивах повторяются элементы: ");
            foreach(int number in numbers_1.Intersect(numbers_2)) {
                Console.Write($"{number} ");
            }

            //не выходя за пределы
        }
    }
}
