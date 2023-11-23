namespace PracticeC;
class Program
/* Напишите программу, которая принимает строку от пользователя, содержащую число, и конвертирует его в целое число. Затем увеличьте это число на 5 и выведите результат. */
{
    static void Main(string[] args)
    {
        string numberString = "3.14159";
        float number = float.Parse(numberString);
        Console.WriteLine(number);
    }
}
