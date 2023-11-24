namespace Task1;
class Program
/* **1.Приветствие пользователя:**
Попросите пользователя ввести свое имя, а затем выведите приветствие с использованием переменной для имени.
*/
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите имя");
        Console.WriteLine("Здравствуйте, " + Console.ReadLine() + ".");
    }
}
