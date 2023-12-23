namespace Practice_C;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2,6, 2, 8 , 0 };
        recurs(numbers, 0);
    }
    //Функция Поиска Всех Уникальных Перестановок Массива**
    //Описание**: Создайте функцию, которая принимает массив уникальных целых чисел и возвращает список всех возможных 
    //уникальных перестановок этих чисел. Задача включает в себя генерацию всех комбинаций элементов массива.
    //Сложность**: Необходимо использовать рекурсию или итеративный подход с использованием стека/очереди
    // для генерации всех возможных комбинаций. Функция должна уметь обрабатывать массивы разной длины.
    static void recurs(int[] numbers, int n)
    {
        if (n == numbers.Length)
        {
            Console.WriteLine(string.Join(", ", numbers));
            return;
        }
        
        for (int i = n; i < numbers.Length; i++)
        {
            perem(numbers, n, i);
            recurs(numbers, n + 1);
            perem(numbers, n, i);
        }
    }
    
    static void perem(int[] numbers, int i, int j)
    {
        int novch = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = novch;
    }
}