Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"Число {number1} больше числа {number2}");
}
else if(number1 < number2)
{
    Console.WriteLine($"Число {number2} больше числа {number1}");
}
else
{
    Console.WriteLine($"Число {number1} равно числу {number2}");
}