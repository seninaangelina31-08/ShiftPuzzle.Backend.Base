namespace Task_7;

class Program
{
    static void Main(string[] args)
    {
int[] mass = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < mass.Length; i += 2)
            {
                Console.Write(mass[i] + " ");
            }
    
            Console.ReadLine();
    }
}
