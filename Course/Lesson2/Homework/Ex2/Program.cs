namespace Ex2;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int randint = rand.Next(0, 101);
        int pop = 0;
        int a;
        while(true)
        {
            pop++;
            Console.Write("Попробуйте отгадать число: ");
            a = Convert.ToInt16(Console.ReadLine());
            if (a == randint)
            {
                Console.WriteLine($"Поздравляю! Это число {randint}. Вы справились с {pop} раза");
                break;
            }
            else if (a > randint)
            {
                Console.WriteLine("Закаганное число меньше");
            }
            else
            {
                Console.WriteLine("Закаганное число больше");
            }
        } 
    }
}
