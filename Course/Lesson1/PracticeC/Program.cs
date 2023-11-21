namespace PracticeC;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int number))
        {
            // Увеличим число на 5
            int result = number + 5;

            // Выведем результат
            Console.WriteLine($"{userInput} + 5 = {result}");
    }
}
}