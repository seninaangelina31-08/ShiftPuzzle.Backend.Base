namespace Practice7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Chanoi_tower(4, "A", "B", "C"));
    }
    public static bool Chanoi_tower(int numdisc, string StartTower, string EndTower, string MiddleTower){
        if (numdisc > 1){
            Chanoi_tower(numdisc - 1, StartTower, MiddleTower, EndTower);
            Console.WriteLine($"Двигаем {numdisc} диск с {StartTower} на {EndTower}");
            Chanoi_tower(numdisc - 1, MiddleTower, EndTower, StartTower);
        }
        else{
            Console.WriteLine($"Двигаем 1 диск с {StartTower} на {EndTower}");
        }
        return true;
    }
}
