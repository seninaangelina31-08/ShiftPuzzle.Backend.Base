namespace PracticeC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt16(Console.ReadLine());

            number = number + 5;

            Console.WriteLine("Результат: " +  number);
        }
    }
}

