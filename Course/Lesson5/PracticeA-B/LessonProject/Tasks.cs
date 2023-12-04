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
        int[] array = {4,9,31,5,100,20};
        int N = 3; 

        int maxSum = int.MinValue;
        int startIndex = 0;

        for (int i = 0; i < array.Length - N + 1; i++)
    {
    
    int currentSum = 0;
    for (int j = i; j < i + N; j++)
    
        {
        currentSum += array[j];
        }

    if (currentSum > maxSum)
        {
        maxSum = currentSum;
        startIndex = i;
        }
    
    }

    Console.WriteLine("Массив с максимальной суммой:");
    for (int i = startIndex; i < startIndex + N; i++)
    {
    Console.Write(array[i] + " ");
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
    Random rand = new Random();
    int[] array = new int[10];

    for (int i = 0; i < array.Length; i++)
    
    {
    array[i] = rand.Next(1, 100); 
    }

    Array.Sort(array);

    HashSet<int> uniqueNumbers = new HashSet<int>(array);

    Console.WriteLine("Отсортированный массив:");
    foreach (int number in array)
    
    {
    Console.Write(number + " ");
    }

    Console.WriteLine("\nКоличество уникальных чисел: " + uniqueNumbers.Count);
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
    int[] array = {2,5,5,6,7,2,3,5,6,7,8,2,1};

    Dictionary<int, int> counts = new Dictionary<int, int>();

    foreach (int number in array)
    {
    
    if (counts.ContainsKey(number))
    {
        counts[number]++;
    }
    
    else
    {
        counts[number] = 1;
    }
    
    }
    int maxCount = counts.Values.Max();

    Console.WriteLine("Числа, которые встречаются чаще всего:");
    foreach (var pair in counts)
    {
    
    if (pair.Value == maxCount)
    {
        Console.WriteLine("Число " + pair.Key + " встречается " + pair.Value + " раз.");
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
    int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int K = 3;

    int[] rotatedArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    
    {
    int newIndex = (i + K) % array.Length;
    rotatedArray[newIndex] = array[i];
    }

    Console.WriteLine("Исходный массив:");
    foreach (int number in array)
    
    {
    Console.Write(number + " ");
    }

    Console.WriteLine("\nИзмененный массив:");
    foreach (int number in rotatedArray)
    
    {
    Console.Write(number + " ");
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
        int[] array1 = {6, 5, 2, 1, 8};
        int[] array2 = {4, 3, 6, 7, 9};

        int[] combinedArray = array1.Concat(array2).ToArray();

        HashSet<int> uniqueNumbers = new HashSet<int>(combinedArray);

        Console.WriteLine("Уникальные числа:");
        foreach (int number in uniqueNumbers)
        
        {
        Console.Write(number + " ");
        }
        
        }
    }
}
