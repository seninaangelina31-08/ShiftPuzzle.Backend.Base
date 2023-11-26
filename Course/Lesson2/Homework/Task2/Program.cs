namespace task2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в игру 'Угадай число!'");
        int quest = 10;

        Console.Write("Введите число: ");
        bool game = true;

        while (game) {
 
            int b = Convert.ToInt32(Console.ReadLine());

            if (quest == b) {
                Console.WriteLine("Вы угадали! Игра окончена...");
                game = false;
            } else if (quest < b) {
                Console.WriteLine("Вы не угадали, загаданное число меньше");
                Console.Write("Введите число: ");
            } else if (quest > b) {
                Console.WriteLine("Вы не угадали, загаданное число больше");
                Console.Write("Введите число: ");
            }
        }
    }
}
