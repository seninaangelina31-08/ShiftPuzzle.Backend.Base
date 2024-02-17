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
            //int[][] array = new int[4][];
            //int summ = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = new int[4];
            //    Console.WriteLine(array[i]);
            //}
            
            int[] array = {5, 28, -5, 9};
            int summ = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                for (int mini = 0; mini<array.Length-1; ++mini)
                {
                    summ += array[mini];
                    Console.WriteLine(mini);
                
                }
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
            int[] array = {5, 28, 5, 5, 9, 6};
            int n = 0;
            int count = 0;

            for (int i = 0; i < array.Length; ++i)
            {

                for (int sort = 0; sort < array.Length - 1; ++sort)
                {
                    if (array[sort]>array[sort+1])
                    {
                        n = array[sort + 1];
                       
                        array[sort + 1] = array[sort];
                        array[sort] = n;
                        

                    }
                    int[] ar2 = new int[6];
                    for (int j = 0; j < ar2.Length; ++j)
                    {
                        if (ar2[j] != array[i])
                        {
                        ar2[j] = array[i];
                        ar2[j] = ar2[j+1];
                        //n = ar2[j + 1];

                        //ar2[j] = array[i];
                        //ar2[j] = n;
                        }
                        Console.Write(ar2[0]);
                        

                    }
                    
                    //if (array[sort] != array[sort+1])
                        //{
                            //++ count;
                            
                            
                        //}
                }
                
                
                //foreach (int sort in array)
                //{
                    //Console.Write($"{array[i]} ");
                //}
            }
            

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

            //не выходя за пределы
        }
    }
}
