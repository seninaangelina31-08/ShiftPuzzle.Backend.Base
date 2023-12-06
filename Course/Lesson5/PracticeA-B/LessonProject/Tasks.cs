using System;

namespace LessonProject
{
    public class Task1
    {
        static Task1()
        {
            Console.WriteLine("Задача 1: Найти в массиве целых чисел первый подмассив длиной N, сумма элементов которого максимальна. Вывести найденный подмассив.");
            Console.WriteLine("РЕШЕНИЕ:");

            var mass = new[] { 6, 1, 3, 5, 4, 2 };
            Console.WriteLine('Введите N - длину подмассива');
            int N = Convert.ToInt32(Console.ReadLine());
            var maxIndex = 0;
            var max = 0;
            for (var i = 0; i < mass.Length - N; i++){
                var Sum = 0;
                for (var j = i; j < i + N; j++){
                    Sum += mass[j];
                    if (max < Sum){
                    max = Sum;
                    maxIndex = i;
                    }
                }
            }
 
 
            for (var i = maxIndex; i < maxIndex + N; i++){
                Console.WriteLine(mass[i]);
            }
        }
    }

    public class Task2
    {
        static Task2()
        {
            Console.WriteLine("\n\n\nЗадача 2: Создать массив случайных чисел, сортировать его по возрастанию, затем найти количество уникальных чисел. Вывести отсортированный массив и количество уникальных чисел.");
            Console.WriteLine("РЕШЕНИЕ:");

            int[] mass = new int[6];
            Random rand = new Random();
            for (int i = 0; i < mass.Length; i++){
                mass[i] = rand.Next(-100,100);}

            Array.Sort(mass);

            Console.WriteLine(String.Join(", ", mass));

            int uniq = 0;
            bool found = false;
            for (int i = 0; i < mass.Length; i++) {
                found = false;
 
                    for (int j = 0; j < mass.Length; j++){
                        if (i != j && mass[i] == mass[j]){
                            found = true;
                        }
                    }
 
                    if (!found) uniq++;}

            Console.WriteLine("Количество уникальных элементов: " + uniq);
        }
    }

    public class Task3
    {
        static Task3()
        {
            Console.WriteLine("\n\n\nЗадача 3: Анализировать массив целых чисел и определить число, которое встречается чаще всего. Если таких чисел несколько, вывести их все и указать, сколько раз каждое из них встречается в массиве.");
            Console.WriteLine("РЕШЕНИЕ:");

            int[] mass = [10, 56, 2, 3, 2, 1, 4, 1, 4, 2, 4, 6, 2];

            Console.WriteLine("Исходный массив: " + string.Join(", ", mass));

            int max_count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < mass.Length; j++)
                {
                    if (mass[i] == mass[j])
                    {
                        count++;
                    }
                }
                if (count > max_count){
                    max_count = count;
                }
            }

            for (int i = 0; i < mass.Length; i++)
            {
                int count = 0;
                if (Array.IndexOf(mass, mass[i]) == i)
                {
                    for (int j = 0; j < mass.Length; j++)
                    {
                        if (mass[i] == mass[j])
                        {
                            count++;
                        }
                    }
                    if (count == max_count){
                        Console.WriteLine(mass[i]);
                        Console.WriteLine("Вхождения: " + Convert.ToString(max_count));
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

            int[] mass = [1, 45, 34, 234, 57, 23];
            int K = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine(string.Join(" ", mass));
            
            
            int[] mass2 = new int[mass.Length];

            for (int i = 0; i < mass.Length; i++)
            {   
                if (i + K>= mass.Length){
                    mass2[(i + K) - mass.Length] = mass[i];
                } 
            else
                {
                    mass2[i + K] = mass[i];
                }
            }

            Console.WriteLine("Измененный массив: " + string.Join(", ", mass2));
        }
        }
    }

    public class Task5
    {
        static Task5()
        {
            Console.WriteLine("\n\n\nЗадача 5: Создать два отдельных массива целых чисел, объединить их в один и вывести числа, встречающиеся в обоих исходных массивах. В результирующем массиве каждое число должно встречаться только один раз.");
            Console.WriteLine("РЕШЕНИЕ:");

            
            int[] mass1 = [10, 3, 4, 6, 3, 5, 6];
            int[] mass2 = [7, 9, 3, 6, 7, 4, 2];

            int count = 0;

            Console.Write("Повторы: ");
            for (int i = 0; i < mass1.Length; i++) {

                for (int j = 0; j < mass2.Length; j++){
                    if (mass1[i] == mass2[j]) {
                        count++;
                        Console.Write(mass1[i] + " ");
                    }
                }
            }

            int[] b = new int[mass1.Length * 2];
            int new_index = 0;
            for (int i = 0; i < mass1.Length; i++)
            {
                if (Array.IndexOf(b, mass1[i]) == -1)
                {
                    b[new_index] = mass1[i];
                    new_index++;
                }
            }
            for (int i = 0; i < mass2.Length; i++)
            {
                if (Array.IndexOf(b, mass2[i]) == -1)
                {
                    b[new_index] = mass2[i];
                    new_index++;
                }
            }
            int[] c = new int[new_index];
            for (int i = 0; i < new_index; i++)
            {
                c[i] = b[i];
            }
            Console.WriteLine("\nОбъединённый массив: " + string.Join(", ", c));
        }
    }
}
    
