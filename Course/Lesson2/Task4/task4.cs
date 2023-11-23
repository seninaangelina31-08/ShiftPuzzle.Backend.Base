namespace task4;
class Program
{
    static void Main()
    {
        int k=0;
        string a;
        while (true){
            a = Console.ReadLine();
            if (a== ""){
                k++;
            }else{
                break;
            }
        }
        Console.Write(k);
    }
}