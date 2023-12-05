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
            int[] array_nums = {1, 3, 5, 2, 4, 6, 3};
            int N = Convert.ToInt32(Console.ReadLine());
            Array.Sort(array_nums);
            Array.Reverse(array_nums);
            int sum = 0;
            for (int i = 0; i < N; i++){
                sum += array_nums[i];
            }
            Console.WriteLine(sum);
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
            int[] array_random = new int[10];
            Random rdn = new Random();
            for (int i = 0; i < 10; i++){
                int rd_num = rdn.Next(1, 11);
                array_random[i] = rd_num;
            }
            Array.Sort(array_random);
            Console.WriteLine(array_random.Length);
            int unique_nums = 1;
            int cons = 1;
            for (int i = 0; i < array_random.Length - 1; i++){
                if (array_random[i] != array_random[i+1]){
                    unique_nums += 1;
                }
            }
            Console.WriteLine(string.Join(",", array_random));
            Console.WriteLine(unique_nums);
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
            int[] array_nums = {1, 3, 121, 32, 23, 54, 1, 3, 1, 3, 1};
            int max_count = 1;
            int count_n = 0;
            for (int i = 0; i < array_nums.Length; i++){
                for (int j = i; j < array_nums.Length; j++){
                    if (array_nums[i] == array_nums[j]){
                        count_n += 1;
                    }
                }
                if (count_n > max_count){
                    max_count = count_n;
                }
                count_n = 0;
            }

            for (int i = 0; i < array_nums.Length; i++){
                for (int j = i; j < array_nums.Length; j++){
                    if (array_nums[i] == array_nums[j]){
                        count_n += 1;
                    }
                }
                if (count_n == max_count){
                    Console.WriteLine(array_nums[i]);
                }
                count_n = 0;
            }
            Console.WriteLine("Максимальное кол-во повторов: " + max_count);
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
            int[] array_nums = {1, 2, 3, 4, 5};
            int[] array_nums_copy = new int [array_nums.Length];
            int K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(string.Join(",", array_nums));
            int[] array_new = array_nums[(array_nums.Length - K)..array_nums.Length];

            for (int i = 0; (i + K) < array_nums.Length; i++)
            {
                array_nums_copy[i + K] = array_nums[i];
            }

            for (int i = 0; i < array_new.Length; i++)
            {
                array_nums_copy[i] = array_new[i];
            }
            Console.WriteLine(string.Join(",", array_nums_copy));

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
            int[] array2 = {1, 4, 9, 16, 25};

            int[] array_conc = new int[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++){
                array_conc[i] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++){
                array_conc[i + array1.Length] = array2[i];
            }

            Array.Sort(array_conc);

            int unique_nums = 1;
            for (int i = 0; i < (array_conc.Length - 1); i++){
                if (array_conc[i] != array_conc[i+1]){
                    unique_nums += 1;
                }
                else{
                }
            }

            for (int i = 0; i < array1.Length; i++){
                for (int j = 0; j < array2.Length; j++){
                    if (array1[i] == array2[j]){
                        Console.WriteLine(array1[i]);
                    }
            }
            }

            int[] result_array = new int[unique_nums];
            
            result_array[0] = array_conc[0];
            int countr = 1;
            for (int i = 0; i < (array_conc.Length - 1); i++){
                if (array_conc[i] != array_conc[i+1]){
                    result_array[countr] = array_conc[i+1];
                    countr += 1;
                }
            }

            Console.WriteLine(string.Join(", ", result_array));
            //не выходя за пределы
        }
    }
}

