using System;
using System.ComponentModel;
using System.Globalization;

namespace LessonProject
{
    public class Task1
    {
        static Task1()
        {
            Console.WriteLine("Задача 1: Найти в массиве целых чисел первый подмассив длиной N, сумма элементов которого максимальна. Вывести найденный подмассив.");
            Console.WriteLine("РЕШЕНИЕ:");
            int[] mas = {1, 2, 3, 4, 5, 71, 12, 1, 3, 5, 1, 9};
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int max_sum = 0;
            int first_index = 0;
            int second_index = 0;


            for (int i = 0; i < mas.Length - n; i++) {
                sum = 0;
                for (int j = 0; j < n; j++){
                    sum += mas[i+j];
                }
                if (sum > max_sum) {
                    first_index = i;
                    second_index = i + n;
                    max_sum = sum;
                }
            }

            for (int a = first_index; a < second_index; a++) {
                Console.Write($"{mas[a]} ");
            }

            Console.WriteLine($"\nМаксимальная сумма - {max_sum}"); 
        }
    }

    public class Task2
    {
        static Task2()
        {
            Console.WriteLine("\n\n\nЗадача 2: Создать массив случайных чисел, сортировать его по возрастанию, затем найти количество уникальных чисел. Вывести отсортированный массив и количество уникальных чисел.");
            Console.WriteLine("РЕШЕНИЕ:");
            int[] mas = new int[10];
            Random rand = new Random();
            int count = 0;
            bool found = false;

            for (int i = 0; i < mas.Length; i++) {
                mas[i] = rand.Next(100);
            }

            Array.Sort(mas);

            for (int j = 0; j < mas.Length; j++) {
                found = false;

                for (int a = 0; a < mas.Length; a++) {
                    if (mas[j] == mas[a] && j != a) {
                        found = true;
                        break;
                    }  
                }
                
                if (found == false) {
                    count++;
                } 
            }

            Console.WriteLine($"Уникальных чисел в массиве: {count}");

            foreach (int arr in mas) {
                Console.WriteLine(arr);
            }

        }
    }

    public class Task3
    {
        static Task3()
        {
            Console.WriteLine("\n\n\nЗадача 3: Анализировать массив целых чисел и определить число, которое встречается чаще всего. Если таких чисел несколько, вывести их все и указать, сколько раз каждое из них встречается в массиве.");
            Console.WriteLine("РЕШЕНИЕ:");

            int[] mas = {1, 2, 3, 4, 5, 6, 7, 7, 8, 8, 8};
            int count = 0;
            int max_count = 0;

            for (int i = 0; i < mas.Length; i++) {
                count = 1;

                for (int j = 0; j < mas.Length; j++) {
                    if (mas[j] == mas[i] && i != j) {
                        count += 1;
                    }
                }
                if (max_count < count) {
                    max_count = count;
                }
            }

            for (int i = 0; i < mas.Length; i++) {
                count = 1;

                for (int j = 0; j < mas.Length; j++) {
                    if (mas[j] == mas[i] && i != j) {
                        count += 1;
                    }
                }

                if (count == max_count) {
                    Console.WriteLine($"Число {mas[i]} повторяется {count} раз.");
                    break;
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

            int[] mas = {1, 2, 3, 4, 5, 6};

            int[] new_mas = new int[mas.Length];

            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < mas.Length; i++) {
                if (i < mas.Length - 4){
                    new_mas[i+k] = mas[i];
                }
                else {
                new_mas[i + k - mas.Length] = mas[i];
                }
            }

            foreach (int a in mas) {
                Console.Write($"{a} ");
            }
            Console.Write("\n");
            foreach (int a in new_mas) {
                Console.Write($"{a} ");
            }
        
        }
    }

    public class Task5
    {
        static Task5()
        {
            Console.WriteLine("\n\n\nЗадача 5: Создать два отдельных массива целых чисел, объединить их в один и вывести числа, встречающиеся в обоих исходных массивах. В результирующем массиве каждое число должно встречаться только один раз.");
            Console.WriteLine("РЕШЕНИЕ:");

            int[] mas_1 = {1, 2, 3, 4, 5};
            int[] mas_2 = {1, 5, 7, 8, 9};
            int count_remember = 0;

            Console.Write("Повторяющиеся числа: ");
            for (int i = 0; i < mas_1.Length; i++) {
                for (int j = 0; j < mas_2.Length; j++){
                    if (mas_1[i] == mas_2[j]) {
                        count_remember++;
                        Console.Write($"{mas_1[i]} ");
                    }
                }
            }

            Console.WriteLine("\nИтоговый массив: ");
            int[] mas_combine = mas_1.Concat(mas_2).ToArray();
            int[] ans = new int[mas_1.Length + mas_2.Length];
            Array.Sort(mas_combine);
            ans[0] = mas_combine[0];

            for (int i = 1; i < mas_combine.Length; i++) {
                if (mas_combine[i] != mas_combine[i-1]) {
                    ans[i] = mas_combine[i];
                }
            }

            foreach (int ar in ans) {
                if (ar != 0) {
                    Console.Write($"{ar} ");
                }
            }
        }
    }
}
