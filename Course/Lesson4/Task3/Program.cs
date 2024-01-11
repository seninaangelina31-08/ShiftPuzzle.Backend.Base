namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {50, 20, 764, 0, 9276, 5, 7, 333, 101};
        for (int i = 0; i < array.Length; ++i)
        {
            if (i == array.Length - 1)
            {
                do
                {
                    Console.WriteLine(array[i]);
                    --i;
                } while (i>=0);
                break;
            
                
            }
            
        }
        
    }
}
