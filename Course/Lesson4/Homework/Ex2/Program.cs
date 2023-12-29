namespace Ex2;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int[] arr = new int[5];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 51);
        }
        Console.WriteLine(String.Join(", ", arr));
        Console.WriteLine("На сколько позиций вправо сдвинуть массив? ");
        int a = Convert.ToInt16(Console.ReadLine());
        int[] arr2 = arr.Take(arr.Length).ToArray();
        for(int i = 0; i < arr.Length; i++)
        {
            if (i+2 < arr.Length)
            {
                arr[i+2] = arr2[i];
            }
            else
            {
                arr[i-arr.Length+2] = arr2[i];
            }
        }
        Console.WriteLine(String.Join(", ", arr));
    }
}
