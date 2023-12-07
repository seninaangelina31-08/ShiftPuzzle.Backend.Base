namespace B;

public class Class1
{
    static int[] MaxSubarraySum(int[] nums) {
        int maxSum = int.MinValue;
        int currentSum = 0;
        int start = 0;
        int end = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            currentSum += nums[i];
            
            if (currentSum > maxSum) {
                maxSum = currentSum;
                end = i;
            }
            
            if (currentSum < 0) {
                currentSum = 0;
                start = i + 1;
            }
        }
        
        int[] subarray = new int[end - start + 1];
        Array.Copy(nums, start, subarray, 0, subarray.Length);
        
        return subarray;
    }
    
    static void Main(string[] args) {
        int[] nums = { 2, -3, 4, -1, -2, 1, 5, -3};
        int[] result = MaxSubarraySum(nums);
        
        Console.Write(string.Join(" ", result));
    }
}
