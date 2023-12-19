namespace Practice8;

class Program
{
    static void Main(string[] args)
    {
        int[] array_nums = {1, 2, 3};
        Combinations(array_nums, 0);
    }
    public static void Combinations(int[] arr, int index){
        if (index == arr.Length - 1){
            Console.WriteLine("Привет");
        }
        else{
            for (int i = index; i < arr.Length; i++){
                swap(arr, index, i);
                Combinations(arr, index + 1);
                swap(arr, index, i);
            }
        }
        Console.WriteLine(string.Join("", arr));
    }
    public static void swap(int[] arr, int i1, int i2){
        int a = arr[i1];
        int b = arr[i2];
        arr[i1] = b;
        arr[i2] = a;
    }
}

