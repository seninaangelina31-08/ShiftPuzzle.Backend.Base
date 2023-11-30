namespace Task1;

class Class1
{
    public static void Main() 
    {
        int[] nums = {1, 2, 3, 4, 5};
        var sum = 0;
            for (var i = 0; i < nums.Length; i++)
            {
               sum += nums[i];
            }
            Console.WriteLine("Сумма: "+ sum);
    }
}