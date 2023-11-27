int num = 7, myNum;

while (true)
{
    Console.Write("Угадай число: ");
    myNum = int.Parse(Console.ReadLine()!);
    if (myNum == num)
    {
        Console.WriteLine("Молодец, ты угадал!");
        break;
    }

    else if (myNum < num)
    {
        Console.WriteLine("Загаданное число больше!");
    }

    else
    {
        Console.WriteLine("Загаданное число меньше!");
    }
}


