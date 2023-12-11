namespace Task7;

class Program
{
    static void Main(string[] args)
    {
        string inputString = "Привет оло";
        char targetChar = 'о';
        int count = CountCharacters(inputString, targetChar);
        Console.WriteLine($"Количество символов '{targetChar}' в строке: {count}");
    }

    static int CountCharacters(string input, char target)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == target)
            {
                count++;
            }
        }
        return count;
    }
}