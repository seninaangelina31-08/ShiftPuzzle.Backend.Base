namespace Practice6;
class Program
{
    static void Main(string[] args)
    {
        int elem = Convert.ToInt32(Console.ReadLine());
        int[] array_squares = {1, 4, 9, 16, 25, 36, 49, 64, 81, 100};
        string detector = "Числа нет в списке";
        for (int i = 0; i < array_squares.Length; i++){
            if (array_squares[i] == elem){
                detector = "Число в списке";
                break;
            }
        }
        Console.WriteLine(detector);
    }
}
