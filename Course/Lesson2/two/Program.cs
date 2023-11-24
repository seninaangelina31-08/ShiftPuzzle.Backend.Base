namespace two;

class Program
{
static void Main()
{
Console.Write("Введите год вашего рождения: ");
int youryear= Convert.ToInt32(Console.ReadLine());

int nowyear = 2023;
int age = nowyear - youryear;

Console.WriteLine("Ваш возраст: " + age);
}
}
