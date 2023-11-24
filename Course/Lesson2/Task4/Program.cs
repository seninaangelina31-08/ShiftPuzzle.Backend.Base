namespace Task4;
class Program
{
    static void Main(string[] args)
    {
        int c = 0;
        string s = "";

        while (true)
        {   Console.Write("Введите что - то: ");
            s = Console.ReadLine();
            if (s == "")
            {
                c += 1;
            }
            else
            {
                break;
            }
        }   
        Console.WriteLine("Вы нажали Enter " + c + " раз!");
        Console.Write("Поздравляю, это ваш новый рекорд!!!!!");
    }
}
