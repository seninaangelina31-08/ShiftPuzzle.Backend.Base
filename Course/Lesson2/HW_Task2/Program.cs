namespace HW_Task2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Привет, я загадал случайное число от 1 до 100 включительно, попробуй угадать!)");
        Random rnd1 = new();
        int answer = rnd1.Next(1, 100);
        int userNum = -1;
        while (answer != userNum)
        {
            Console.WriteLine("Введите число, которое я загадал: ");
            userNum = Convert.ToInt16(Console.ReadLine());
            if (userNum > answer)
            {
                Console.WriteLine("Загаданное число меньше " + userNum);
            }
            else
            {
                Console.WriteLine("Загаданное число больше " + userNum);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Вы угадали! Загаданное число = " + userNum);
        
    }
}
