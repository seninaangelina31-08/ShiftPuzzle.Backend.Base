Console.WriteLine("Укажите первое число ");
string a = Console.ReadLine();
int number1 = int.Parse(a);

Console.WriteLine("Укажите второе число ");
string b = Console.ReadLine();
int number2 = int.Parse(b);

int result = number1 + number2;
Console.WriteLine(number1 + " + " + number2 + " = " + result);