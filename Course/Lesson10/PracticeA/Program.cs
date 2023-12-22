namespace PracticeA;
class FileOperations
{
    static void Main(string[] args)
    { 
        string[] test = {"Пробный", "Тест"};
        File.WriteAllLines("Test.txt", test);
        string[] lines = File.ReadAllLines("Test.txt");
        // чтение запись в файл test.txt
        // test
        foreach (string str in lines)
        {
            Console.WriteLine(str);
        }
    }

}
