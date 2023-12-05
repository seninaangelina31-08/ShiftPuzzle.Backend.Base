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
            Console.WriteLine("Введите длину подмассива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            
            int[] array = { -2, 1, -3, 4, 5, -1, 1, -5, 4 }; 
             
            if (N > array.Length)
            {
                Console.WriteLine("Длина подмассива превышает длину исходного массива.");
                return;
            }
        
            int maxSum = int.MinValue; 
            int startIndex = 0; 
        
            for (int i = 0; i <= array.Length - N; i++)
            {
                int sum = 0; 
            
                for (int j = i; j < i + N; j++)
                {
                    sum += array[j];
                }
            
                if (sum > maxSum)
                {
                    maxSum = sum;
                    startIndex = i;
                }
            }
        
            for (int i = startIndex; i < startIndex + N; i++)
            {   
            Console.Write(array[i] + ",");
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
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 11);
            }

            Array.Sort(array);
            
            int y = 0;
            int n = 0;
            bool found = false;
            for(int i = 0; i < array.Length; i++)
            {
                found = false;
 
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] == array[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found) y++;
            }
 
            n = array.Length - y;
            for (int j = 0; j < array.Length; ++j){
                    Console.Write(array[j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(y);
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
            int[]arr = new int[]{1, 2, 4, 5, 2, 6, 8, 9};
            Array.Sort(arr);
            Dictionary<int,int> d = new Dictionary<int,int>();
            int c = 1;
            for(int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1]){
                    c += 1;
                }else{
                    d.Add(arr[i], c);
                }
            }
            int max = 0;
            foreach (var item in d){
                if (item.Value>max){
                    max = item.Value;
                }
            }
            foreach (var item in d){
                if (item.Value == max){
                    Console.WriteLine("Количество: "+item.Value+" Число: "+item.Key);
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
            int[] array = { 0, 1, 3, 5, 4, 6 };
            int k = 2;

            foreach (var i in array)
            {
                Console.Write(i + " ");
            }

            int[] tempArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[(i + k) % array.Length] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = tempArray[i];
            }
            Console.Write("");
            foreach (var i in array)
            {
                Console.Write(i + " ");
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
            int []arr1 = new int[]{1, 2, 3, 4, 5};
            int []arr2 = new int[]{5, 4, 6, 7, 8};
            
            int[] result = arr1.Intersect(arr2).ToArray();

            Console.WriteLine("Числа, встречающиеся в обоих массивах:");

            foreach (int number in result)
            {Console.WriteLine(number);}

            int[] array = arr1.Concat(arr2).ToArray();

            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
        }
    }
}
