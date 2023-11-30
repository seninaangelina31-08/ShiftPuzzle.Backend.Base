namespace Tsk4;

class Class1
{
   static void Main(string[] args)
    {
        int[]a = new int[10];
        for (int i = 0; i<10; ++i){
            a[i] = (i + 1);
            if (a[i]%2 == 0){
                Console.Write(a[i]+" ");
            }
        }
        
    }
}
