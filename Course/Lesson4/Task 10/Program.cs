namespace Task_10;

class Program
{
    static void Main(string[] args)
    {
        int[] mass = {1,-1,3,5,-2,-9};
        foreach(int i in mass)
        {
            if (mass[i] < 0) 
            {mass[i] = 0;}
        Console.WriteLine(i);}
        
    }
}
