namespace PracticeC;

public class Class1
{
    static void Main(string[] args)
    {
        int[] path = {4, 2, 0, 1, 2, 3, 1, 1, 0}; 

        int stepsNeeded = CalculateSteps(path); 

        if (stepsNeeded != -1)
        {
            Console.WriteLine("Минимальное количество шагов для достижения конца пути: " + stepsNeeded);
        }
        else
        {
            Console.WriteLine("Достичь конца пути невозможно");
        }
    }

    static int CalculateSteps(int[] path)
    {
        int[] minSteps = new int[path.Length]; 
        minSteps[0] = 0;

        for (int i = 1; i < path.Length; i++)
        {
            minSteps[i] = int.MaxValue; 

            for (int j = 0; j < i; j++)
            {
                if (j + path[j] >= i && minSteps[j] + 1 < minSteps[i])
                {
                    minSteps[i] = minSteps[j] + 1; 
                    break;
                }
            }
        }

        return minSteps[path.Length - 1] != int.MaxValue ? minSteps[path.Length - 1] : -1; 
    }
}
