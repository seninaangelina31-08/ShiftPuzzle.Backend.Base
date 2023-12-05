namespace Homework1;
class Program
{
    static void Main(string[] args)
    {
        int[] array1 = {1, 1, 2, 3, 5};
        int[] array2 = {1, 8, 27, 64, 125};

        int[] array_conc = new int[array1.Length + array2.Length];

        for (int i = 0; i < array1.Length; i++){
            array_conc[i] = array1[i];
        }
        for (int i = 0; i < array2.Length; i++){
            array_conc[i + array1.Length] = array2[i];
        }

        Console.WriteLine(string.Join(",", array_conc));
    }
}
