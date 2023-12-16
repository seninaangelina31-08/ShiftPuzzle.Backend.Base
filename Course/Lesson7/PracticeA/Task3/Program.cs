namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        {
            Console.Write("Напиши строку:");
            string input = Console.ReadLine();
            
            string bimbambum = lol(input);
            Console.WriteLine($"Вот перевернутая строка: {bimbambum}");
        }

        static string lol(string str)
        {
            if (str.Length == 0)
                return str;
            else
                return lol(str.Substring(1)) + str[0];
        }
    }
}