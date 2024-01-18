namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        //1. *Слияние двух массивов*
        //Напишите программу, которая объединяет два массива целых чисел в один. Элементы второго массива должны следовать за элементами 
        //первого массива.

         //2. *Ротация массива*
        //Создайте программу, которая осуществляет циклическую ротацию массива на заданное количество позиций вправо.
        // Например, ротация массива [1, 2, 3, 4, 5] на две позиции даст [4, 5, 1, 2, 3].
        
        int[] numbers = {1, 3, 7, 8,3,1};
        
        int[] numb = {5, 7, 8, 2, 6};
        int[] nu = numbers.Union(numb).ToArray();
        Console.WriteLine("Объединенный массив:  "+ string.Join(" ", nu));
        Console.Write("Введите число позиций: ");
        int K =Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < K; i++)
        {
            int sdv = numbers[numbers.Length - 1];

            for (int j= numbers.Length - 1; j > 0; j--)
            {
                numbers[j] = numbers[j - 1];
            }

            numbers[0] = sdv;
        }
        var str = string.Join(" ", numbers);
        Console.WriteLine(str);
    }
}
