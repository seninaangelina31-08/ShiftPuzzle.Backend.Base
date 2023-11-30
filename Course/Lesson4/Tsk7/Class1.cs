namespace Tsk7;

class Class1
{
    static void Main(string[] args)
    {
        int[]m = {1, 2, 3, 4, 5};
        for (int i=0; i<5; ++i){
            if (i%2 == 1){
                Console.Write(m[i] + " ");
            }
        }
        
    }
}
