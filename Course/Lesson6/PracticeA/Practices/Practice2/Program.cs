namespace Practice2;

class Program
{
    static void Main(string[] args)
    {
        string username = Console.ReadLine();
        HiUser(username);
    }

    public static void HiUser(string username){
        Console.WriteLine("Привет, " + username);
    }
}
