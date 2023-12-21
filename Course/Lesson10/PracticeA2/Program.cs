namespace PracticeA2;
class FileOperations
{
    static void Main(string[] args)
    { 
        // чтение запись в файл test.txt
        WriteFunc();
        ReadFunc();
    }

    public static void WriteFunc(){
        string[] words = new string[6];
        for (int i = 0; i < 6; i++){
            words[i] = Console.ReadLine();
        }
        File.WriteAllLines("words.txt", words);
    }
    public static void ReadFunc(){
        string[] words = File.ReadAllLines("words.txt");
        Console.WriteLine("Words in file:");
        foreach (string word in words){
            Console.WriteLine(word);
        }
    }
}
