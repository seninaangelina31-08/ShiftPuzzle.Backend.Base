namespace L4_HW_T2;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new();

        Console.WriteLine("Введите размер массива");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение, на которое сдвинуть массив");
        int k = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[n];
        int[] movedNums = new int[n];

        // создание массива случайно
        for (int i = 0; i < n; i++)
        {
            nums[i] = generator.Next(20);
        }

        // логика
        for (int i = 0; i < nums.Length; i++)
        {
            int index = i - k;
            if (index < 0) index += nums.Length;
            movedNums[i] = nums[index];
        }
        // вывод
        string numsStr = "{";
        foreach (int num in nums)
        {
            numsStr += $"{num}, ";
        }
        Console.WriteLine(numsStr.Substring(0, numsStr.Length - 2) + "}");
        numsStr = "{";
        foreach (int num in movedNums)
        {
            numsStr += $"{num}, ";
        }
        Console.WriteLine(numsStr.Substring(0, numsStr.Length - 2) + "}");
    }
}
