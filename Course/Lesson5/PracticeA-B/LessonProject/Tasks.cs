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
           
            
              int[] numbers = { 2, 4, 7, 9, 2, 6, 4, -2, 1, 8 }; // пример массива чисел
                int n = 3; // длина подмассива
                int max = -10000;
                int indmaxsum = 0;

                for (int i = 0; i <= numbers.Length - n; i++)
                {
                    int sum = 0;

                    for (int j = i; j < i + n; j++)
                    {
                        sum += numbers[j];
                    }

                    if (sum > max)
                    {
                        max = sum;
                        indmaxsum = i;
                    }
                }

                int[] numb = new int[n];
                for (int i = 0; i < n; i++)
                {
                    numb[i] = numbers[indmaxsum + i];
                }
                
            Console.WriteLine("Найденный подмассив с максимальной суммой элементов:");
            Console.WriteLine(string.Join(" ", numb));
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
            
            int[] numbers={2,4,7,9,2,6,4,2,1,8};
            Array.Sort(numbers);
            var str = string.Join(" ", numbers);
            Console.WriteLine(str);
            int unik = numbers.Distinct().Count();
            Console.WriteLine(unik);
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
            
            int[] numbers={2,4,7,9,2,6,4,2,1,8};
            int[] counts = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                int k = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        k++;
                    }
                }
                counts[i] = k;
            }

            int max = counts.Max();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (counts[i] == max)
                {
                    Console.WriteLine("Число "+ numbers[i] +" встречается " +  counts[i] +" раз.");
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
            int K=3;

            int[] numbers = {1, 3, 7, 8,3,1};
            
                
            for (int i = 0; i < K; i++)
            {
                int sdv = numbers[numbers.Length - 1];

                for (int j= numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }

                numbers[0] = sdv;
            }
        
            Console.WriteLine(string.Join(" ", numbers));
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
            
        
            int[] numbers = {1, 3, 7, 8, -6, 4, -2, 12, 6};
            int[] numb = {5, 7, 8, 2, 6};
            int[] nu = numbers.Union(numb).ToArray();
            
            foreach (int i in nu)
            {
                if (numbers.Contains(i)&&numb.Contains(i))
                {
                    Console.WriteLine("Число, встречающееся в обоих массивах:"+i);
                }
            }
            Console.WriteLine(string.Join(" ", nu));
            //не выходя за пределы
        }
    }
}