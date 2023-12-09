namespace PracticeC;
class Program
{
    static void Main(string[] args)
    {
        int[] path = { 4, 2, 0, 1, 2, 3, 1, 1, 0 };

        int res = FindMinattempts(path);
        if (res == 0)
        {
            Console.WriteLine("no possible solution");
        }
        else
        {
            Console.WriteLine($"possible to complete in {res} attempts");
        }
    }
    static int FindMinattempts(int[] path)
    {
        int result = 0;
        int priorotyIndex = 0;
        for (int i = 0; i < path.Length - 1 && path[priorotyIndex] != 0;)
        {
            int prioroty = 0;
            for (int j = 1; j <= path[i]; j++)
            {
                if (i + j < path.Length - 1)
                {
                    int priorotynNow = path[i + j] + j;
                    if (priorotynNow > prioroty)
                    {
                        prioroty = priorotynNow;
                        priorotyIndex = i + j;
                    }
                }
                else
                {
                    priorotyIndex = i + j;
                }
            }
            i = priorotyIndex;
            result++;
        }
        if (priorotyIndex < path.Length - 1)
        {
            return 0;
        }
        else 
        { 
            return result; 
        }
    }
}
