namespace Task4;
class Program
{
    static void Main(string[] args)
    {
        int numberClickEnter = 0;
        while(true)
        {
            Console.Write("\nYou click the Enter " + numberClickEnter + " times\n");
            Console.ReadLine();
            numberClickEnter++;
        }
    }
}
