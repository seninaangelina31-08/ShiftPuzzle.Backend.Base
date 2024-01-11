namespace Task7;

class Program
{
    static void Main(string[] args)
    {
        //dotnet new console --framework net8.0 --use-program-main
        int[] array = {100, 1000, 0, 54, -102, 9, 8, 80, 77};
        for (int i = 0; i < array.Length; ++i)
        {
            if (i%2 != 0)
            {
                Console.WriteLine(array[i]);
            }
        }
        
    }
}
