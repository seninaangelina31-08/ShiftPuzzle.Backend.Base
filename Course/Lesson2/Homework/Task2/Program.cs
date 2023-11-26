int number = 0;
int number1 = 67;
;

Console.WriteLine("Загадано число от 0 до 100");
Console.WriteLine("Ваша задача угадать данное число. ");

while (true)
{
    number = Convert.ToInt32(Console.ReadLine());
    if (number == number1)
    {
        Console.WriteLine("Вы угадали число!");
        break;
    }
    else if (number > number1)
    {
        Console.WriteLine("Загаданное число меньше...");
    }
    else
    {
        Console.WriteLine("Загаданное число больше..."); 
    }
}