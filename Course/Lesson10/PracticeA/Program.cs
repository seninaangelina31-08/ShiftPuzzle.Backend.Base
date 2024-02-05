namespace PracticeA;
class FileOperations
{
    static void Main(string[] args)
    { 

        // чтение запись в файл test.txt

        string fileName = "Test.txt"

        using (StreamWtiter writer = new StreamWtiter(fileName))
        {
            writer.WriteLine("Hello Akshin");
        }
    }


        using (StreamReader writer = new StreamReader(fileName))
        {
            string line

            while ((line = reader.ReadLine) != null)
            {
                Console.ReadLine(line);
            }
        }
}
