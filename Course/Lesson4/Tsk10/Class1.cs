namespace Tsk10;

class Class1
{
    static void Main(string[] args)
    {
        int[]m = {-1, -2, 3, 4, 5, 6};
        for (int i=0; i<5; ++i){
            if (m[i]<0){
                m[i]=0;
            }
        }
    Console.WriteLine(String.Join(" ",m));  
    }
}
