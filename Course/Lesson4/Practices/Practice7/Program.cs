namespace Practice7;
class Program
{
    static void Main(string[] args)
    {
        int[] array_cubes = {1, 8, 27, 64, 125, 216, 343};
        Console.WriteLine("Числа на нечетных позициях:");
        for (int i = 0; i < array_cubes.Length; i++){
            if (i % 2 == 0){
                Console.WriteLine(array_cubes[i]);
            }
        }
    }
}
