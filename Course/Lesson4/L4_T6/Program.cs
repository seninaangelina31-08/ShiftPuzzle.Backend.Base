namespace L4_T6;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {123, 124125, 124, 15324, 123};
        int searchedElement = 123;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == searchedElement)
            {
                Console.WriteLine($"Число {searchedElement} находится под {i} индексом");
            }
        }
    }
}
