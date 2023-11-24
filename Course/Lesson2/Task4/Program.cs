namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;

        Console.WriteLine("Привет!");
        Console.WriteLine("Готов? (да/нет)");

        string answer1 = Console.ReadLine();

        if (answer1 == "да")
        {   
            while(true)
            {
            Console.WriteLine("Нажмите на клавишу Enter");
            Console.ReadLine();

            counter++;
            Console.WriteLine("Текущее значение: " + counter);
            }
        }

        else if (answer1 == "нет")
        {
            Console.WriteLine("Хорошо. Как будешь готов, выбирай ответ: да!");
        }

        else
        {
            Console.WriteLine("Ты опечатался :( ");
        }
    }
}