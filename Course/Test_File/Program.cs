namespace Test_File;

class Program
{
    static void Main(string[] args)
    {

Dictionary<string, string> students = new Dictionary<string, string>();

students.Add("one", "Max");
//students.Add("two", "Mox");
foreach(var pers in students)
{
    Console.WriteLine(pers.Value);
}



    }
}
