namespace task6;

class Program
{
    static void Main(string[] args)

    {
       int[] arr = { 1, 2, 3, 5, 6, 7 }; 
       Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i=0; i<arr.Length; ++i){
            if(arr[i] == a){
                Console.Write("Число найдено");
            }
        }
        Console.Write("Число не найдено");
    }
}
