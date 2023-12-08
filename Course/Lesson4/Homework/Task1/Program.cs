namespace Task1;
class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 3, 4, 5, 6, 7 };
            bool flag = true;
            int[] mergedArr = new int[arr1.Length+arr2.Length];
            for (int i = 0; i < arr1.Length; i++) {
                flag = true;
                for (int j = 0; j < mergedArr.Length; j++) {
                    mergedArr[i] = arr1[i];
                } 
            }
            for (int i = 0; i < arr2.Length; i++) {
                flag = true;
                for (int j = 0; j < mergedArr.Length; j++) {
                    mergedArr[i+arr1.Length] = arr2[i];
                }
            }
            
    }
}
