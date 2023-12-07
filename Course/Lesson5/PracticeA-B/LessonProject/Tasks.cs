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
            int[] numbers = { 3, 0, 2, 6, 8, 0, -3, 7, 3 };
            int N = 3;
            int maxSum = int.MinValue;
            int start_Index = 0;

            for (int i = 0; i <= numbers.Length - N; i++)
            {
                int tec_Sum = 0;

                for (int j = i; j < i + N; j++)
                {
                    tec_Sum += numbers[j];
                }

                if (tec_Sum > maxSum)
                {
                    maxSum = tec_Sum;
                    start_Index = i;
                }
            }
            Console.WriteLine("Подмассив с максимальной суммой:");
            for (int i = start_Index; i < start_Index + N; i++)
            {
                Console.Write(numbers[i] + " ");
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
            Random random = new Random();
            int size = 10;
            
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(100);
            }
            
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            int uniqueCount = 1;
            for (int i = 1; i < size; i++)
            {
                if (numbers[i] != numbers[i - 1])
                {
                    uniqueCount++;
                }
            }

            Console.WriteLine("Отсортированный массив:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Количество уникальных чисел: " + uniqueCount);
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
            int[] numbers = {1, 2, 3, 4, 5, 5, 6,7, 7, 7, 7, 8, 9, 9, 9, 9};
            int maxOccurrences = 0;
            for (int i = 0; i < numbers.Length; i++) 
            {
                int count = 1;
                for (int j = i + 1; j < numbers.Length; j++) 
                {
                    if (numbers[i] == numbers[j]) 
                    {
                    count++;
                    }
                }
                if (count > maxOccurrences)
                {
                    maxOccurrences = count;
                }
            }
            Console.WriteLine("Числа, которые встречаются чаще всего:");
            for (int i = 0; i < numbers.Length; i++) 
            {
                int count = 1;
                for (int j = i + 1; j < numbers.Length; j++) 
                {
                    if (numbers[i] == numbers[j]) 
                    {
                        count++;
                    }
                }
                if (count == maxOccurrences) 
                {
                    Console.WriteLine(numbers[i] + " встречается " + count + " раз(а)");
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
            static void Rotate(string[] args)
            {
                int[] array = { 1, 2, 3, 4, 5 };
                int k = 2;
                Console.WriteLine("Исходный массив:");
                PrintArray(array);
                RotateArray(array, k);
                Console.WriteLine("Измененный массив:");
                PrintArray(array);
            }

            static void RotateArray(int[] array, int k)
            {
                int length = array.Length;
                int[] temp = new int[length];

                for (int i = 0; i < length; i++)
                {
                    temp[(i + k) % length] = array[i];
                }

                for (int i = 0; i < length; i++)
                {
                    array[i] = temp[i];
                }
            }

            static void PrintArray(int[] array)
            {
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
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
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 4, 5, 6, 7, 8 };
            int[] resultArray = new int[array1.Length + array2.Length];
            int index = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        bool alreadyExists = false;
                        for (int k = 0; k < index; k++)
                        {
                            if (resultArray[k] == array1[i])
                            {
                            alreadyExists = true;
                            break;
                            }
                        }
                        if (!alreadyExists)
                        {
                            resultArray[index] = array1[i];
                            index++;
                        }
                        break;
                    }
                }
            }

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(resultArray[i]);
            }
            //не выходя за пределы
        }
    }

}
