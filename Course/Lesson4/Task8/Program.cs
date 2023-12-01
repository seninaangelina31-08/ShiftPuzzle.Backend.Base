

int[] nums = {4568899, 1, 412656, 1236678, 7654321, 14100, 4578936, 12876677, 55555,};
int smallest = nums[0];
int biggest = nums[0];
foreach (var num in nums)
{
    if (smallest > num)
    {
        smallest = num;
    }
    if (biggest < num)
    {
        biggest = num;
    }
}
Console.WriteLine($"Самое большое число в массиве это {biggest}");
Console.WriteLine($"Самое маленькое число в массиве это {smallest}");