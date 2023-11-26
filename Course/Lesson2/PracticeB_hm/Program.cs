namespace PracticeB_hm;
class Program
{
    static void Main(string[] args)
    {
        Random rdn = new Random();
        int rd_num = rdn.Next(1, 11);
        Console.WriteLine("Введите число от 1 до 10:");
        int user_num = Convert.ToInt32(Console.ReadLine());
        while (user_num != rd_num){
            
            if (user_num < rd_num)
            {
                Console.WriteLine("Загаданное число больше");
                user_num = Convert.ToInt32(Console.ReadLine());

            }
            else if (user_num > rd_num)
            {
                Console.WriteLine("Загаданное число меньше");
                user_num = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Вы угадали, поздравляю!");
    }
}
