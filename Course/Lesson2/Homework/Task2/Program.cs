namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        int my_num = 88;
        Console.WriteLine("Привет! Давай поиграем в битву экстрасенсов! Я загадал двузначное число, попробуй его отгадать!");
        Console.WriteLine("Итак, я загадал число... (введи число): ");
        int your_num = Convert.ToInt16(Console.ReadLine());
        if (your_num > my_num)
        {
            Console.WriteLine("Неверно! Моё число меньше твоего! Перезапусти программу и повтори попытку!");
        }

        else if (your_num < my_num)
        {
            Console.WriteLine("Неверно! Моё число больше твоего! Перезапусти программу и повтори попытку!");
        }
        else
        {
            Console.WriteLine("Правильно! Да ты настоящий экстрасенс!!!");
        }
    }
}
