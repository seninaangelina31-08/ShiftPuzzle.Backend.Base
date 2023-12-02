namespace Task9;

class Program
{
    static void Main(string[] args)
    {
        //Реализуйте сортировку массива по возрастанию (любым методом сортировки)._
        int[] numb = {2, -4, 62, 6};
        Array.Sort(numb);
        
        var str = string.Join(" ", numb);
        Console.WriteLine(str);
    }
}
