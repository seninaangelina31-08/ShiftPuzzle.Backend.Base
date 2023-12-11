


// int[] nums = {222, 7, 2111, -365, -2111, 1254, 6, -666, 0, 3000, 1234567};
// for (int i = 0; i < nums.Length; i++)
// {
//     if (nums[i] < 0)
//     {
//         nums[i] = 0;
//     }
// }
//         
// foreach (int num in nums)
// {
//     Console.WriteLine(num);
// }


int[] nums = {4, 2, 0, 1, 2, 3, 1, 1, 0};
int steps = 0;
int count = 0;
while (nums[count] > 0)
{
    steps += nums[count];
    count += steps;
}

      


    // else if (nums[i] == 0) Console.WriteLine("Достичь конца пути невозможно!");
