namespace Ex10;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {5, 15, 23, -7, 16, -74, 50, 2};
        for(int i = 0; i < arr.Length; i++)                 // Я удивлён, тут форыч не крутой, в нём нельзя менять значения в массиве
        {                                                   // Вот такую ошибку выдаёт :(
            if (arr[i] < 0)                                 // error CS1656: Невозможно присвоить "i" значение, так как он является "переменная цикла foreach".
                arr[i] = 0;
            Console.Write($"{arr[i]} ");
        }
    }
}
