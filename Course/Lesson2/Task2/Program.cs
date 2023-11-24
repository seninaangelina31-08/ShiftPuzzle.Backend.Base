namespace Task2;
class Program
/***2.Калькулятор возраста:**
Попросите пользователя ввести свой год рождения, а затем используйте переменную для вычисления и вывода его возраста.
*/
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите год рождения");
        Console.WriteLine("Возраст: " + (2023 - Int32.Parse(Console.ReadLine())) + ".");
    }
}
