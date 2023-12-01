

int[] nums = {2110, 15, 560, 15004, 2110};
int searchedElement = 2110;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == searchedElement)
    {
        Console.WriteLine($"Число {searchedElement} находится под {i} индексом");