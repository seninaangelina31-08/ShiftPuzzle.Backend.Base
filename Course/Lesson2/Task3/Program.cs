namespace PracticeA;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добрый день! Я вижу, Вы хотите сохранить имена и телефонные номера конкретных пользователей!");
        Console.WriteLine("У нас существует лимит количества хранения данных: на 3 имён 3 номера.");
        Console.WriteLine("Приступим! Введите имя конкретного человека: ");
        string name1 = Console.ReadLine() ?? "";
        Console.WriteLine("Введите номер телефона этого человека: ");
        string num1 = Console.ReadLine() ?? "";

        Console.WriteLine("Отлично, я запомнил... Введите имя второго человека: ");
        string name2 = Console.ReadLine() ?? "";
        Console.WriteLine("Введите номер телефона этого человека: ");
        string num2 = Console.ReadLine() ?? "";
        
        Console.WriteLine("Подходим к финишной прямой! Введите имя третьего человека: ");
        string name3 = Console.ReadLine() ?? "";
        Console.WriteLine("Введите номер телефона этого человека: ");
        string num3 = Console.ReadLine() ?? "";

        Console.WriteLine("ЗА-МЕ-ЧАТЕЛЬНО! Вот все данные, которые Вы ввели: ");
        Console.WriteLine(name1 +' '+ num1);
        Console.WriteLine(name2 +' '+ num2);
        Console.WriteLine(name3 +' '+ num3);
    }
}
