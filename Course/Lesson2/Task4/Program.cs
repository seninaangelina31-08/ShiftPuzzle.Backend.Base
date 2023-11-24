namespace Task4;
class Program
{
    static void Main(string[] args)
    {
        int cnt = 0;
        string s = Console.ReadLine();
        while (s =="") {
            cnt++;
            s = Console.ReadLine();
        }
        Console.WriteLine(cnt);
    }
}
