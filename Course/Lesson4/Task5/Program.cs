

int counter = 0;
int[] nums = {0, 9, -2110, -888, 867, 0, 867};
foreach (int num in nums)
{
    if (num < 0)
    {
        counter++;
    }
}
Console.WriteLine(counter);