// See https://aka.ms/new-console-template for more information

Console.Write("Введите 2 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int sum = a + b;
int dif = a - b;
int com = a * b;
int quo = a / b;

Console.Write("Сумма чисел: " + sum);
Console.WriteLine("Разность чисел: " + dif);
Console.WriteLine("Произведение чисел: " + com);
Console.WriteLine("Частное чисел: " + quo);