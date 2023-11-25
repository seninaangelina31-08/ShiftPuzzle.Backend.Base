namespace PracticeD;

class Program
{
    static void Main(string[] args)
    {
        int enterCount = 0; // Переменная для подсчета нажатий Enter

        Console.WriteLine("Нажмите Enter несколько раз. Для завершения введите 'выход' и нажмите Enter.");

        string userInput = "";
        while (userInput.ToLower() != "выход")
        {
            userInput = Console.ReadLine();

            if (userInput == "")
            {
                enterCount++; // Увеличение счетчика при нажатии Enter
                Console.WriteLine($"Количество нажатий Enter: {enterCount}");
            }
        }

        Console.WriteLine("Программа завершена.");
    }
}
