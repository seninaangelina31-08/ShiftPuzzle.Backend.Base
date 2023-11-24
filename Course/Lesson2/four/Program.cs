namespace four;

class Program
{
static void Main()
{
    int enterCount = 0;
    while (true)
    {
        Console.WriteLine("Нажмите Enter:");
        string vvod = Console.ReadLine() ?? "";  
        if (vvod == "")
        {
            enterCount++;
            Console.WriteLine("Количество нажатий на клавишу Enter: " + enterCount);
        }
        else
        {
            Console.WriteLine("Клавиша Enter не была нажата.");
        }
    }
}
}
