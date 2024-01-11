namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {-0, 0, -3, 4, -2, 12, 99, -100, 8, -68, -111, 897, -21};
        Console.WriteLine("Введите число, которое Вы хотите найти в массиве: ");
        int num = Convert.ToInt16(Console.ReadLine());
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i]==num)
            {
                
                Console.WriteLine($"Да, такое число есть, оно находится в индексе под номером {i}");
            }

            else
            {
                Console.WriteLine($"Это число отсутствует в индексе под номером {i}");
            }
            
        }

    }
}
