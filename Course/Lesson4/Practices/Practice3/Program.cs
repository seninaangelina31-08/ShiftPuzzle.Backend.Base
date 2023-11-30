namespace Practice3;
class Program
{
    static void Main(string[] args)
    {
        int[] array_reverse = {1, 2, 3, 5, 8, 13, 21};
        for (int i = 0; i < (array_reverse.Length)/2; i++){
            int re = array_reverse[i];
            array_reverse[i] = array_reverse[array_reverse.Length - i - 1];
            array_reverse[array_reverse.Length - i - 1] = re;
        }
        Console.WriteLine($"Перевернутый массив: {string.Join(",", array_reverse)}");
    }
}
