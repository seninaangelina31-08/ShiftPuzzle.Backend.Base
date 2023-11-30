namespace Tsk6;

class Class1
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int[]m = {1, 25, 37, 4, 5, 6, 7, 53,};
        for (int i=0; i<m.Length; ++i){
            if(m[i] == a){
                Console.Write("Число нашлось");
                return;
            }
        }
        Console.Write("Не нашлось");
    }
}

