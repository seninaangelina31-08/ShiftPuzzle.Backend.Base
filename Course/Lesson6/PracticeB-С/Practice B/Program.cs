namespace Practice_B;

class Program
{
    static void Main(string[] args)
        {
            int[] t1 = podmas(new int[]{ 2, 4, 7, 9, 2, 6, 4, -2, 1, 8 }, 3);
        }
    
    public static int[] podmas(int[] numbers, int n)
    {
    //*Функция Поиска Подмассива с Максимальной Суммой (Задача о Максимальной Подпоследовательности)**
    //Описание**: Напишите функцию, которая принимает массив целых чисел и возвращает подмассив с максимальной суммой элементов.
    // Это задача о максимальной подпоследовательности, требующая выявления подмассива с максимальной суммой среди всех подмассивов.
    //Сложность**: Требуется использование циклов для итерации по массиву и алгоритмический подход для вычисления максимальной суммы.
        
        // длина подмассива
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
        return numb;
    }
}
