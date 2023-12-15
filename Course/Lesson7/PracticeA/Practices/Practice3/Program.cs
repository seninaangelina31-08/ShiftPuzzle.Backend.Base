namespace Practice3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(reversestr("Hello"));
    }

    public static string reversestr(string word){
        char[] array_word = word.ToArray();
        if (array_word.Length / 2 <= 1){
            return string.Join("", array_word);
        }
        else{
            return array_word[^1] + reversestr(string.Join("", array_word[1..^1])) + array_word[0];
        }
    }
}
