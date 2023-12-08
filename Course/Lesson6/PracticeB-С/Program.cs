namespace PracticeB_С;
class Program
{


    static public int[] Task1(int[] arr) {
        int n = arr.Length, l = 0, r = 0, max = 0;
        int[] pref_sum = new int[n];
        pref_sum[0] = arr[0];
        for (int i = 1; i < n; i++) {
            pref_sum[i] = pref_sum[i-1]+arr[i];
        }
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < i; j++) {
                if (pref_sum[i]-pref_sum[j] > max) {
                    max = pref_sum[i]-pref_sum[j];
                    l = j;
                    r = i;
                }
            }
        }
        int[] fin = new int[r-l+1];
        for (int i = l+1; i < r+1; i++) {
            fin[i-l] = arr[i];
        }
        return fin;



    }

    static void Main(string[] args) {
        int[] arr = {1, 2, 5, -8, -6, 9, 6, 3, -4, 7};
        arr = Task1(arr);
        for (int i = 1; i < arr.Length; i++) {
            Console.Write(arr[i]+" ");
        }
    }



}
