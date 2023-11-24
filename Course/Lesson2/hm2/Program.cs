namespace hm2;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int random = rnd.Next(0, 100);
        int a = Convert.ToInt32(Console.ReadLine());
        while (a != random){
            if (a > random){
                Console.WriteLine("Меньше");
                a = Convert.ToInt32(Console.ReadLine());
            } else {
                Console.WriteLine("Больше");
                a = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
