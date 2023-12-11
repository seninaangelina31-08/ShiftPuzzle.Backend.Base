namespace PracticeC;

class Program
{
    static void Main(string[] args)
    {
    int[] path = { 4, 2, 0, 1, 2, 3, 1, 1, 0 };

    int[] minSteps = new int[path.Length];
    minSteps[0] = 0;

    for (int i = 1; i < path.Length; i++)
{
    minSteps[i] = int.MaxValue;
    for (int j = 0; j < i; j++)
    
    {
    if (j + path[j] >= i && minSteps[j] != int.MaxValue)
        {
        minSteps[i] = Math.Min(minSteps[i], minSteps[j] + 1);
        break;
        }
    }
}

        int steps = minSteps[minSteps.Length - 1] == int.MaxValue ? -1 : minSteps[minSteps.Length - 1];

        if (steps == -1)
        {
            Console.WriteLine("Достичь конца пути невозможно.");
        }
        
        else
        {
            Console.WriteLine($"Минимальное количество шагов до конца пути: {steps}");
        }
    }
}