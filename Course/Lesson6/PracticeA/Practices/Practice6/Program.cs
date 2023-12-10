namespace Practice6;

class Program
{
    static void Main(string[] args)
    {
        string word = "Hello";
        Console.WriteLine(Reverse(word));
    }

    public static string Reverse (string word){
        string word_ret = new string(word.Reverse().ToArray());
        return word_ret;
    }
}
