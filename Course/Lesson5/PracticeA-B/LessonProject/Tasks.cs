using System;
using System.Dynamic;

namespace LessonProject
{
    public class Task1
    {
        static Task1()
        {
            Console.WriteLine("Задача 1: Найти в массиве целых чисел первый подмассив длиной N, сумма элементов которого максимальна. Вывести найденный подмассив.");
            Console.WriteLine("РЕШЕНИЕ:");

            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите размер подмассива");
            int n = Convert.ToInt16(Console.ReadLine());
            Random generator = new Random();
            int[] array = new int[size];
            int total = 0;
            int totalMax = array.Min();
            string arrayStr = "{";
            string arrayStrMax = "";

            for (int i = 0; i < size; i++)
            {
                array[i] = generator.Next(100);
            }
            for (int i = 0; i <= array.Length - n; i++)
            {
                
                for (int j = i; j <= i + n - 1; j++)
                {
                    total += array[j];
                    arrayStr += $"{array[j]}, ";
                    
                }
                if (total > totalMax)
                {
                    totalMax = total;
                    arrayStrMax = arrayStr;
                }
                arrayStr = "{";
                total = 0;

            }
            Console.WriteLine(arrayStrMax.Substring(0, arrayStrMax.Length - 2) + "}");

        }
    }

    public class Task2
    {
        static Task2()
        {
            Console.WriteLine("\n\n\nЗадача 2: Создать массив случайных чисел, сортировать его по возрастанию, затем найти количество уникальных чисел. Вывести отсортированный массив и количество уникальных чисел.");
            Console.WriteLine("РЕШЕНИЕ:");

            Random generator = new Random();
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                nums[i] = generator.Next(-1000, 1000);
            }
            Array.Sort(nums);
            for (int i = 0; i < n - 1; i++)
            {
                if (nums[i] != nums[i+1])
                {
                    counter++;
                }
            }
            if (nums[0] != nums[n - 1])
            {
                counter++;
            }
            // вывод массива и счетчика
            string numsStr = "{";
            foreach (int num in nums)
            {
                numsStr += $"{num}, ";
            }
            Console.WriteLine(numsStr.Substring(0, numsStr.Length - 2) + "}");
            Console.WriteLine($"Количество уникальных элементов = {counter}");

        }
    }

    public class Task3
    {
        static Task3()
        {
            Console.WriteLine("\n\n\nЗадача 3: Анализировать массив целых чисел и определить число, которое встречается чаще всего. Если таких чисел несколько, вывести их все и указать, сколько раз каждое из них встречается в массиве.");
            Console.WriteLine("РЕШЕНИЕ:");


            Random generator = new();
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            int answerCounter = 0;

            string answerNum = "";
            int num;

            // создание массива случайно
            for (int i = 0; i < n; i++)
            {
                nums[i] = generator.Next(20);
            }

            // логика
            for (int i = 0; i < nums.Length; i++)
            {
                int counter = 0;
                num = nums[i];
                for (int j = i; j < nums.Length; j++)
                {
                    if (num == nums[j]) counter++;
                }
                if (counter > answerCounter)
                {
                    answerCounter = counter;
                    answerNum = num.ToString();
                }
                else if (counter == answerCounter) 
                {
                    answerNum += $", {num}";
                }
            }
            
            // вывод
            Console.WriteLine($"Чаще всего встречались: {answerNum}");
            Console.WriteLine($"Количество появлений равно {answerCounter}");


        }
    }

    public class Task4
    {
        static Task4()
        {
            Console.WriteLine("\n\n\nЗадача 4: Выполнить циклическую ротацию массива на K позиций вправо. Вывести исходный и измененный массивы.");
            Console.WriteLine("РЕШЕНИЕ:");

            Random generator = new();
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            int[] movedNums = new int[n];

            // создание массива случайно
            for (int i = 0; i < n; i++)
            {
                nums[i] = generator.Next(20);
            }
            // логика
            for (int i = 0; i < nums.Length; i++)
            {
                int index = i - k;
                if (index < 0) index += nums.Length;
                movedNums[i] = nums[index];
            }
            // вывод
            string numsStr = "{";
            foreach (int num in nums)
            {
                numsStr += $"{num}, ";
            }
            Console.WriteLine(numsStr.Substring(0, numsStr.Length - 2) + "}");
            numsStr = "{";
            foreach (int num in movedNums)
            {
                numsStr += $"{num}, ";
            }
            Console.WriteLine(numsStr.Substring(0, numsStr.Length - 2) + "}");
        
        }
    }

    public class Task5
    {
        static Task5()
        {
            Console.WriteLine("\n\n\nЗадача 5: Создать два отдельных массива целых чисел, объединить их в один и вывести числа, встречающиеся в обоих исходных массивах. В результирующем массиве каждое число должно встречаться только один раз.");
            Console.WriteLine("РЕШЕНИЕ:");


            Random generator = new();

            Console.WriteLine("Введите размер 1 массива");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер 2 массива");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int[] nums1 = new int[n1];
            int[] nums2 = new int[n2];
            HashSet<int> mergedArrays = new();

            // создание массива случайно
            for (int i = 0; i < n1; i++)
            {
                nums1[i] = generator.Next(20);
            }
            for (int i = 0; i < n2; i++)
            {
                nums2[i] = generator.Next(20);
            }

            // логика
            foreach (int num in nums1)
            {
                mergedArrays.Add(num);
            }
            foreach (int num in nums1)
            {
                mergedArrays.Add(num);
            }

            // вывод
            string numsStr = "{";
            foreach (int num in mergedArrays)
            {   
                foreach (var num1 in nums1)
                {
                    if (num1 == num)
                    {
                        foreach (int num2 in nums2)
                        {   
                            if (num1 == num2)
                            {
                                numsStr += $"{num}, ";
                                break;
                            }
                            
                        }
                        break;
                    }
                }
            }
            Console.WriteLine($"Числа, присутствующие в обоих массивах{numsStr.Substring(0, numsStr.Length - 2)}" + "}");

            numsStr = "{";
            foreach (int num in mergedArrays)
            {
                numsStr += $"{num}, ";
            }
            Console.WriteLine($"Объединенный массив: {numsStr.Substring(0, numsStr.Length - 2)}" + "}");
        }
    }
}
