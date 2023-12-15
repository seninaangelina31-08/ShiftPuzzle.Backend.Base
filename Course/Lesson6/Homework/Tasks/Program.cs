using System;
using System.Linq;
using System.Collections.Generic;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Задание 1 ---");
            Task1();
            Console.WriteLine("--- Задание 2 ---");
            Task2();
        }

        static void Task1() {
            // Исходный массив с числами
            int[] numbers = {4, 45, 45, 3, 3, 0, 1, 32, 100, 777, 454, 111};
            if (numbers.Length > 0) {
                // Группируем массив, используя как ключи сами числа, а значения - количество данных чисел в массиве
                var grouped_numbers = numbers.GroupBy(x => x);
                // Располагаем элементы группы в порядке убывания их количества в массиве
                grouped_numbers = grouped_numbers.OrderByDescending(x => x.Count());
                // Выводи самое часто встречающееся число - первый элемент нашей новой последовательности
                Console.WriteLine($"Самое часто встречающееся число - {grouped_numbers.First().Key}");
            } else {
                // Чтоб ничего не поламалось
                Console.WriteLine("Массив пустой!!!");
            }
        }

        static void Task2() {
                // Создадим думерный массив, который выполнит роль матрицы
                int[,] matrix = new int[2, 3] {{0, 2, 5}, {0, 1, 3}};

                // Это будет транспонированная матрица
                var new_matrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
                
                // Транспонируем матрицу
                for (int j = 0; j < new_matrix.GetLength(0); ++j)
                    for (int i = 0; i < new_matrix.GetLength(1); ++i)
                        new_matrix[j, i] = matrix[i, j];

                // Распечатаем транспонированную матрицу
                for (int i = 0; i < new_matrix.GetLength(0); ++i) {
                    for (int j = 0; j < new_matrix.GetLength(1); ++j) {
                        Console.Write($"{new_matrix[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
}
