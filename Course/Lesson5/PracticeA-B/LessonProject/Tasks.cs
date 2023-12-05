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
            Console.Write("Введите длину основного массива: ");
            int m = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[m];
            Console.WriteLine($"Введите массив длинной {m}:");
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write($"Введите {i+1} элемент: ");
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.Write("Введите длину подмассива: ");
            int n = Convert.ToInt16(Console.ReadLine());
            while(n > m)
            {
                Console.Write("Длинна подмассива должна быть меньше длины массива: ");
                n = Convert.ToInt16(Console.ReadLine());
            }
            int[] arr2 = new int[n];
            for(int i=0; i<arr2.Length; i++)
            {
                int max = arr.Max();
                arr2[i] = max;
                int index = Array.IndexOf(arr, max); 
                arr = arr.Where((e, j) => j != index).ToArray();
            }
            Console.WriteLine("Найденный подмасив: ");
            Console.WriteLine(String.Join(", ", arr2));
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
            Random rand = new Random();
            int[] arr = new int[15];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 51);
            }
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int c = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = c;
                    }
                }
            }
            bool unique = true;
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                unique = true;
                for(int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        unique = false;
                        break;
                    }
                }
                if (unique)
                    count++;
            }
            Console.WriteLine(String.Join(", ", arr) + $"\nКоличество уникальных элементов: {count}");
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
            Random rand = new Random();
            int[] arr = new int[15];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 11);
            }
            var dict = new Dictionary<int, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                int rep_count = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        rep_count++;
                    }
                }
                dict.TryAdd(arr[i], rep_count);
            }
            Console.WriteLine("Массив: ");
            Console.WriteLine(String.Join(", ", arr));
            foreach( KeyValuePair<int, int> kvp in dict)
            {
                if (kvp.Value > 1)
                    Console.WriteLine($"Число = {kvp.Key}, количесвто повторений {kvp.Value}");
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
            Random rand = new Random();
            int[] arr = new int[15];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 11);
            }
            int[] arr2 = new int[15];
            Console.Write("Введите на сколько сдвинуть массив вправо: ");
            int n = Convert.ToInt16(Console.ReadLine());
            for(int i = 0; i< arr.Length; i++)
            {
                if (i+n<arr.Length)
                    arr2[i+n] = arr[i];
                else
                    arr2[i+n-arr.Length] = arr[i];
            }
            Console.WriteLine("Исходный массив: ");
            Console.WriteLine(String.Join(", ", arr));
            Console.WriteLine("Изменённый массив: ");
            Console.WriteLine(String.Join(", ", arr2));
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
            Random rand = new Random();
            int[] arr = new int[15];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 16);
            }
            int[] arr2 = new int[15];
            for(int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rand.Next(0, 16);
            }
            List<int> arr3 = new List<int>();
            foreach(int i in arr)
            {
                foreach(int j in arr2)
                {
                    if (i == j && !arr3.Contains(i))
                        arr3.Add(j);
                }
                
            }
            Console.WriteLine("Исходные массивы: ");
            Console.WriteLine("Первый: ");
            Console.WriteLine(String.Join(", ", arr));
            Console.WriteLine("Второй: ");
            Console.WriteLine(String.Join(", ", arr2));
            Console.WriteLine("Изменённый массив: ");
            Console.WriteLine(String.Join(", ", arr3));
            //не выходя за пределы
        }
    }
}
