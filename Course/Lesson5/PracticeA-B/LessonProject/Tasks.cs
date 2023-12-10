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

            int[][] array = new int[5][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[] {(4 - i) * i, i, 4};
            }
            array[1] = new int[] {3, 7, 5};
            Console.WriteLine("Массив:");
            foreach(int[] array_temp in array)
            {
                Console.Write(" [");
                for (int count = 0; count < array_temp.Length; count++)
                {
                    Console.Write(array_temp[count] + " ");
                }
                Console.Write("] ");
            }
            int[] max_array = array[0];
            int max_array_sum = 0;
            foreach(int count in max_array)
            {
                max_array_sum = max_array_sum + count;
            }
            for (int count = 0; count < array.Length; count++)
            {
                int temp_sum = 0;
                for (int count_1 = 0; count_1 < array[count].Length; count_1++)
                {
                    temp_sum = temp_sum + array[count][count_1];
                }
                if (temp_sum > max_array_sum)
                {
                    max_array_sum = temp_sum;
                    max_array = array[count];
                }
            }
            Console.WriteLine("Наибольший подмассив по сумме чисел: [");
            foreach(int count in max_array)
            {
                Console.Write(count + " ");
            }
            Console.Write("]");
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
            var rand = new Random();
            int[] array = new int[10];
            for (int count = 0; count < array.Length; count++)
            {
                array[count] = rand.Next(10);
            }
            Array.Sort(array);

            Console.Write("Отсортированный массив: [");
            foreach (int count in array)
            {
                Console.Write(count + " ");
            }
            Console.Write("] ");
            int number = 0;
            int[] array_yn = new int[1];
            foreach(int count in array)
            {
                number = 0;
                foreach(int count_1 in array)
                {
                    if(count == count_1)
                    {
                        number++;
                    }
                }
                if ( number == 1)
                {
                    Array.Resize(ref array_yn, array_yn.Length + 1);
                    array_yn[array_yn.Length - 1] = count;

                }

            }
            Console.WriteLine("Кол во уникальных чисел: " + array_yn.Length);


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
            var rand = new Random();
            int number = 10;
            int[] array = new int[10];
            for (int count = 0; count < array.Length; count++)
            {
                array[count] = rand.Next(number);
            }
            int[] array_numbers = new int[number];
            foreach (int temp_count in array)
            {
                array_numbers[temp_count]++;
            }
            int[] number_max = {0};
            for (int temp_count = 0; temp_count < array_numbers.Length; temp_count++)
            {
                if (array_numbers[temp_count] > array_numbers[number_max[0]])
                {
                    Array.Resize(ref number_max, 1);
                    number_max[0] = temp_count;
                }
                else if (array_numbers[temp_count] == array_numbers[number_max[0]])
                {
                    Array.Resize(ref number_max, number_max.Length + 1);
                    number_max[number_max.Length - 1] = temp_count;
                }
            }

            Console.WriteLine("Самое частое число повторяется " + array_numbers[number_max[0]] + " раза.");
            Console.WriteLine("Числа, которые повторяются чаще всего:");
            foreach (int temp_int in number_max)
            {
                Console.Write(" " + temp_int);
            }
            //Console.WriteLine();
            //foreach (int temp_int in array_numbers)
            //{
            //    Console.WriteLine(temp_int);
            //}

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
            var rand = new Random();
            int number = 10;
            int K = 1;
            int[] array = new int[10];
            for (int count = 0; count < array.Length; count++)
            {
                array[count] = rand.Next(number);
            }
            int[] array_edit = new int[10];
            int temp_count = 0;
            for (int count = 0; count < array.Length; count++)
            {
                temp_count = count + K;
                while (temp_count + 1 > array.Length)
                {
                    temp_count = temp_count - array.Length;
                }
                array_edit[temp_count] = array[count];
            }
            Console.WriteLine("Старый массив: ");
            foreach (int text in array)
            {
                Console.Write(text + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Новый массив: ");
            foreach (int text in array_edit)
            {
                Console.Write(text + " ");
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
            var rand = new Random();
            int number = 10;
            int[] array1 = new int[10];
            for (int count = 0; count < array1.Length; count++)
            {
                array1[count] = rand.Next(number);
            }
            int[] array2 = new int[10];
            for (int count = 0; count < array2.Length; count++)
            {
                array2[count] = rand.Next(number);
            }
            int[] array_full = {array1[0]};
            foreach (int temp_count in array1)
            {
                if (!array_full.Contains(temp_count))
                {
                    Array.Resize(ref array_full, array_full.Length + 1);
                    array_full[array_full.Length - 1] = temp_count;
                }
            }
            Console.WriteLine("Новый массив: ");
            foreach (int text in array_full)
            {
                Console.Write(text + " ");
            }
//
            //Console.WriteLine();
            //Console.WriteLine("массив: ");
            //foreach (int text in array1)
            //{
            //    Console.Write(text + " ");
            //}
//
            //Console.WriteLine();
            //Console.WriteLine("массив: ");
            //foreach (int text in array2)
            //{
            //    Console.Write(text + " ");
            //}
            //не выходя за пределы
        }
    }
}
