namespace ShiftPuzzle.Backend.Base;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int number = rand.Next(1, 101);
        int chislo = 0;
        
        Console.WriteLine("Угадайте случайное число от 1 до 100:");
        while (chislo != number)
        {
            Console.Write("Попробуйте угадать число: ");
            chislo = Convert.ToInt32(Console.ReadLine());
            
            if (chislo < number)
            {
                Console.WriteLine("Загаданное число больше");
                
            }
            else if (chislo > number)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else
            {
                Console.WriteLine(" Вы угадали! Загаданное число - " + number);
            }
        }
    }
}

