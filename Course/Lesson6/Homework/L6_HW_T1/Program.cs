namespace L6_HW_T1;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt16(Console.ReadLine());
        
        Random generator = new();
        int[] nums = new int[size];

        for (int i = 0; i < size; i++)
        {
            nums[i] = generator.Next(-10, 10);
        }

        // вывод
        string numsStr = "{";
        foreach (int num in nums)
        {
            numsStr += $"{num}, ";
        }
        Console.WriteLine(numsStr.Substring(0, numsStr.Length - 2) + "}");
        var most = (from i in nums
            group i by i into grp
            orderby grp.Count() descending
            select grp.Key).First();

        Console.WriteLine($"Чаще всего встречалось {most}");
    }
}
