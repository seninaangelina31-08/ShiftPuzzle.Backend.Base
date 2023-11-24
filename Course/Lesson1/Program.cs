using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace Lesson1;
class Program
{
    static void Main(string[] args)
    {
        //Task A
        int a;
        bool b;
        long l;
        float f;

        // Task B
        int d = Int32.Parse (Console.ReadLine());
        int c = Int32.Parse (Console.ReadLine()); 

        Console.WriteLine(d+c);
        Console.WriteLine(d-c);
        Console.WriteLine(d*c);
        Console.WriteLine(d/c);

        //Task C
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine(s+5);
         
    }
}
