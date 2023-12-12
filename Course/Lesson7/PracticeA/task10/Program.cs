namespace task10;

class Program
/*Это единственный номер, который я переписал, но так и не разобрался как именно он работает.
Как я понимаю функция `Swap` используется для обмена двух элементов массива, но зачем это делать я не понимаю.
*/
{
    static void Main(string[] args)
    {
        string input = "Hell";
        per(input.ToCharArray(), 0);
    }
    static void per(char[] arr, int index)
    {
        if (index == arr.Length - 1)
        {
            Console.WriteLine(new string(arr));
        }
        else
        {
            for (int i = index; i < arr.Length; i++)
            {
                Swap(arr, index, i);
                per(arr, index + 1);
                Swap(arr, index, i);
            }
        }
    }
    static void Swap(char[] arr, int i, int j)
    {
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

}
