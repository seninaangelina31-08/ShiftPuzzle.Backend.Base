namespace Task4;
class Program
{
    static void Main(string[] args)
    {
        int enter_counter = 0;
        string input_string = "";

        while (true)
        {   Console.Write("Введите что - то: ");
            input_string = Console.ReadLine();
            if (input_string == "")
            {
                enter_counter += 1;
            }
            else
            {
                break;
            }
        }   
        Console.WriteLine("Вы нажали Enter " + enter_counter + " раз!");
        Console.Write("Поздравляю, это ваш новый рекорд!!!!!");
    }
}
