namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        string originalString = "Привет";
        string reversedString = ReverseString(originalString);
        Console.WriteLine($"Исходная строка: {originalString}");
        Console.WriteLine($"Строка в обратном порядке: {reversedString}");
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}