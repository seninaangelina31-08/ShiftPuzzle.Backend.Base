namespace L7_T3;

class Program
{
    public static void ReverseString(string word)
    {
        if(!string.IsNullOrEmpty(word))
        {
            char ch = word[0];
            ReverseString(word[1..]);
            Console.Write(ch);
        }
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Введите слово, которое нужно перевернуть");
        ReverseString(Console.ReadLine());
    }
}
