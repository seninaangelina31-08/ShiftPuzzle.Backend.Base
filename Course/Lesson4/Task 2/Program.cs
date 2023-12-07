namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
int res = 0;
int[] massiv = {1,4,8,23,7,12,3};
foreach(int i in massiv)
{
    if ( res <= i)
    {res = i;}
        
        
}
Console.WriteLine(res);


    }
}
