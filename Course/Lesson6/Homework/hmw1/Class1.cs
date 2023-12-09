namespace hmw1;

public class Class1
{
    static void Main(string[] args) {
        int[] a = {1, 1, 2, 2, 3, 3, 3, 4, 4, 4, 4};
        var most = a.GroupBy(x => x).OrderByDescending(x => x.Count()).First();
        Console.WriteLine("Наиболее часто встречается {0} в количестве {1}", most.Key, most.Count());
    }
}
