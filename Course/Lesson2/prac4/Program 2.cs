namespace prac4;
class Program
{
    static void Main(string[] args)
    {
        int cnt = 0;
        string a;
        
        while (true){
            a = Console.ReadLine();
            if (a == "") {
                cnt++;
            } else {
                break;
            }
        }
        Console.Write(cnt);
    }
}
