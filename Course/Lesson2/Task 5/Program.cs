namespace Task_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро Пожаловать на наш сайт!\n"+ "Для начала заполните анкету");

        Console.WriteLine("Введите ваше ФИО (на английском):");
        string name = Console.ReadLine();

        Console.WriteLine("Расскажите немного о себе: ");
        string story = Console.ReadLine();


        Console.Write($"==========================\n ФИО учасника: {name}\n {story}");

    }
}
