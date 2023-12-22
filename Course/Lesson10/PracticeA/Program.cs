namespace PracticeA;
class FileOperations
{
    static void Main(string[] args)
    { 
        Random rand = new Random();
        string[] arr = new string[5];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToString(rand.Next(0, 51));
        }
        WriteToFile(arr);
        ReadFromFileAndPrint("Test.txt");
        // чтение запись в файл test.txt
    }

    public static void WriteToFile(string[] arr)
    {
        File.WriteAllLines("Test.txt", arr);
    }

    public static void ReadFromFileAndPrint(string path)
    {
        string[] lines = File.ReadAllLines(path);
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
