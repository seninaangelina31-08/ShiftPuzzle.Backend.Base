namespace Practice7;

class Program
{
    static void Main(string[] args)
    {
        string word = "hippopotamus";
        char symbol = 'p';
        Console.WriteLine(Counter(word, symbol));
    }

    public static int Counter (string word, char symbol){
        char[] symbols = word.ToArray();
        int cntr = 0;
        for (int i = 0; i < symbols.Length; i++){
            if (symbols[i] == symbol){
                cntr++;
            }
        }
        return cntr;
    }
}
