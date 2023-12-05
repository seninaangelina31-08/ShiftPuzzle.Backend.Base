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
            int[] array1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            string c = Console.ReadLine() ?? "1";
            int c1 = Convert.ToInt32(c);
            int c2 = 0;
            int sum1 = 0;
            for (int i = 0; i < c1; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (c2 < array1[j])
                    {
                        c2 = array1[0];
                        array1[0] = array1[j];
                        array1[j] = c2;
                    }
                }
                c2 = 0;
                sum1 += array1[0];
                array1[0] = 0;
                if (i == array1.Length)
                {
                    break;
                }
            }
            Console.WriteLine(sum1);
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
            int[] array2= {3, 4, 2, 1, 2, 3, 4, 1, 1, 1, 1, 2, 2, 3, 4, 5, 5, 6, 6, 7};
            int count = 0;
            int s = 0;
            Array.Sort(array2);
            foreach (int arr in array2)
            {
                Console.Write(arr + " ");
            }
            Console.WriteLine();
            s = array2[0];
            for (int i = 0; i < array2.Length; i++)
            {
                if (s != array2[i])
                {
                    s = array2[i];
                    count++;
                }
            }
            Console.WriteLine(count);
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
            int[] array3 = {1, 1, 1, 2, 2, 3, 4, 4, 4};
            Array.Sort(array3);
            int count = 0;
            int count_max = 0;
            int count_max1 = 0;
            int max = 0;
            int a3;
            for (int i = 0; i < array3.Length; i++)
            {
                count = 0;
                for (int j = 0; j < array3.Length; j++)
                {
                    if (array3[i] == array3[j])
                    {
                        count++;
                    }
                
                }
                if (count > count_max)
                {
                    count_max = count;
                    count_max1 = 1;
                    max = array3[i];
                }
                else if (count == count_max)
                {
                    count_max1++;
                }
                a3 = array3[i];
                while (i < array3.Length)
                {
                    if (a3 != array3[i])
                    {
                        break;
                    }
                    i++;
                }
            }
            if (count_max1 == 1)
            {
                Console.WriteLine(max);
            }
            else if (count_max1 > 1)
            {
                int i1 = 0;
                for (int i = 0; i < array3.Length; i++)
                {
                    count = 0;
                    for (int j = 0; j < array3.Length; j++)
                    {
                        if (array3[i] == array3[j])
                        {
                            count++;
                        }
            
                    }
                    a3 = array3[i];
                    i1 = i;
                    while (i < array3.Length)
                    {
                        if (a3 != array3[i])
                        {
                            break;
                        }
                        i++;
                    }
                    if (count == count_max)
                    {
                        Console.Write(array3[i1] + " ");
                    }
                }
                Console.WriteLine("Встречались:" + count_max);
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
