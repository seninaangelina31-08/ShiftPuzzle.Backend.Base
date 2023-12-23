using System;

class Program
{
    
        static void Main(string[] args)
    {
        Console.Write("  Выделите ячейки памяти = ");
        var len = Convert.ToInt32(Console.ReadLine());
        var b = new int[len];
        for (var i = 0; i < b.Length; ++i)
        {
            Console.Write("a[{0}] = ", i);
            b[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", QuickSort(b)));
    }
    
   
   
    //метод для обмена элементов массива
            static void Swap(ref int x, ref int y)
            {
                var t = x;
                x = y;
                y = t;
            }

            //метод возвращающий индекс опорного элемента
            static int Partition(int[] numbers, int mini, int maxi)
            {
                var p = mini - 1;
                for (var i = mini; i < maxi; i++)
                {
                    if (numbers[i] < numbers[maxi])
                    {
                        p++;
                        Swap(ref numbers[p], ref numbers[i]);
                    }
                }

                p++;
                Swap(ref numbers[p], ref numbers[maxi]);
                return p;
            }

            //быстрая сортировка
            static int[] QuickSort(int[] numbers, int mini, int maxi)
            {
                if (mini >= maxi)
                {
                    return numbers;
                }

                var ind = Partition(numbers, mini, maxi);
                QuickSort(numbers, mini, ind - 1);
                QuickSort(numbers, ind + 1, maxi);

                return numbers;
            }

            static int[] QuickSort(int[] numbers)
            {
                return QuickSort(numbers, 0, numbers.Length - 1);
            }
}
