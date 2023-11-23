namespace PracticeD;

class Program
{
    static void Main(string[] args)
    {
        int c = 1;
        while (c > 0)
        {
            string EnterKey = Console.ReadLine();
            Console.WriteLine("Enter было нажато " + c + " раз");
            c++;
        }
    }
}

