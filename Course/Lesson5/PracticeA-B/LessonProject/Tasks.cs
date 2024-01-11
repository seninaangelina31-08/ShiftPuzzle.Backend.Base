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
            int[] numbers1 = { 1, 2, 1, 2, 3, 4, 3, 4};

            Array.Sort(numbers1); // Сортировка по возрастанию

            int num = numbers1.Distinct().Count();
            Console.WriteLine("Количество уникальных чисел в списке: " + num);


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
            int[] array = { 4, 3, 2, 2, 3, 4, 5, 4, 4 };

        Dictionary<int, int> occurrences = new Dictionary<int, int>();

        foreach (int num in array)
        {
            if (occurrences.ContainsKey(num))
            {
                occurrences[num]++;
            }
            else
            {
                occurrences[num] = 1;
            }
        }

        int maxOccurrences = occurrences.Max(x => x.Value);
        var mostFrequentNumbers = occurrences.Where(x => x.Value == maxOccurrences).Select(x => x.Key);

        Console.WriteLine("Наиболее часто встречающиеся числа и их количество в массиве:");
        foreach (var number in mostFrequentNumbers)
        {
            Console.WriteLine($"Число: {number}, количество раз: {occurrences[number]}");
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
            int[] array4 = {1, 2, 3, 4, 5, 6, 7};
            int[] array41 = new int[array4.Length];
            foreach (int arr in array4)
            {
                Console.Write(arr + " ");
                }
                Console.WriteLine();
                int i1 = 0;
                string s = Console.ReadLine() ?? "1";
                int s1 = Convert.ToInt32(s);
                for (int i = 0; i < array4.Length; i++)
                {
                    i1 = i + s1;
                    while ((i1 > array4.Length) || (i1 == array4.Length))
                    {
                        i1 -= array4.Length;
                        }
                        array41[i1] = array4[i];
                        }
                        foreach (int arr in array41)
                        {
                            Console.Write(arr + " ");
                            }
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
            int[] array51 = {5, 1, 2, 3, 4};
            int[] array52 = {5, 1, 3, 3, 1, 7};
            int[] array53 = new int[(array51.Length + array52.Length)];
            for (int i = 0; i < array53.Length; i++)
            {
                if (i < array51.Length)
                {
                    array53[i] = array51[i];
                }
                else
                {
                    array53[i] = array52[(i - array51.Length)];
                }
            }
            foreach (int arr in array53)
            {
                Console.Write(arr + " ");
            }
            Console.WriteLine();
            Array.Sort(array51);
            Array.Sort(array52);
            int a5 = array51[0];
            int a51;
            for (int i = 0; i < array51.Length; i++)
            {
                for (int j = 0; j < array52.Length; j++)
                {
                    if (array51[i] == array52[j])
                    {
                        Console.Write(array51[i] + " ");
                        a51 = array51[i];
                        while (j < array52.Length)
                        {
                            if (a51 != array52[j])
                            {
                                break;
                            }
                            j++;
                        }
                    }
                }
                a5 = array51[i];
                while (i < array51.Length)
                {
                    if (a5 != array51[i])
                    {
                        break;
                    }
                    i++;
                }
            }
            //не выходя за пределы
        }
    }
}
