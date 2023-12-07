namespace PracticeC;

class Program
{
    static void Main(string[] args)
    {
    int[] path = {4, 2, 0, 1, 2, 3, 1, 1, 0};
    int n = path.Length;
    int[] minSteps = new int[n]; 
    for (int i = 0; i < n; i++) {
        minSteps[i] = int.MaxValue; 
    }
    minSteps[0] = 0;

    for (int i = 0; i < n; i++) {
        if (path[i] != 0) 
        {
            for (int j = 1; j <= path[i] && i + j < n; j++) 
            {   
                minSteps[i + j] = Math.Min(minSteps[i + j], minSteps[i] + 1);
            }
        }
    }

    if (minSteps[n - 1] != int.MaxValue) 
    {
        Console.WriteLine("Минимальное количество шагов: " + minSteps[n - 1]);
        foreach (int el in minSteps)
        {
            Console.Write(el + " ");
        }
    } 
    else 
    {
        Console.WriteLine("Невозможно достичь конца пути.");

    }
}
}
