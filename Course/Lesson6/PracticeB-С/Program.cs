namespace PracticeB_С;
class Program
{
    static void Task1(int [] array, int N){
        var maxi = 0;
        var max = 0;
        for (var i = 0; i < array.Length - N; i++){
            var sum = 0;
                for (var j = i; j < i + N; j++){
                    sum += array[j];
                    if (max < sum){
                        max = sum;
                        maxi = i;
                    }
                }
            }
    
        for (var i = maxi; i < maxi + N; i++){
            Console.WriteLine(array[i]);
            }
        }

    static void Main(string[] args)
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Task1(arr, 3);
    }
}
