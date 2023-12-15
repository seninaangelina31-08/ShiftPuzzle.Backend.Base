namespace Practice6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(palindrom("abcsba"));
        Console.WriteLine(palindrom("abccba"));
    }

    public static string palindrom(string word){
        char[] array_word = word.ToArray();
        if (array_word.Length > 2){
            if (array_word[0] == array_word[^1]){
                return palindrom(string.Join("", array_word[1..^1]));
            }
            else{
                return "no palindrom";
            }
        }
        else{
            if (array_word[0] == array_word[^1]){
                return "palindrom";
            }
            else{
                return "no palindrom";
            }
        }
    }
}
