int count, i, t;
count = 0;
Console.WriteLine("Счётчик нажатий на Enter! Для того чтобы остановиться введи любой текст.");
for (i = 0; i < 1; i = 0)
{
    if (Console.ReadLine() == ""){
        count = count + 1;
    }
    else
    {
        break;
    }
}
Console.WriteLine("Ты нажал на Enter: " + count + " раз(а).");