int random = 12, inten;
Console.WriteLine("Игра 'Угадай число!'");
Console.WriteLine("Правила: Вводите числа, а мы вам будем подсказыать больше загаданое число или меньше.");
Console.WriteLine("НАЧАЛИ!");
while (true)
{
    inten = Convert.ToInt32(Console.ReadLine());
    if (inten == random)
    {
        Console.WriteLine("УРА! Ты угадал! Вот тебе приз!(Подарок: Выход из вечного цикла)");
        break;
    }
    else if (inten > random)
    {
        Console.WriteLine("Меньше.");
    }
    else
    {
        Console.WriteLine("Больше.");
    }
}