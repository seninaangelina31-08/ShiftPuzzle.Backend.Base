namespace L7_T7;

class Program
{
    static void towerOfHanoi(int n, char from_rod,
                       char to_rod, char aux_rod1,
                                    char aux_rod2)
    {
        if (n == 0)
            return;
        if (n == 1) {
            Console.WriteLine("Move disk " + n +
                        " from rod " + from_rod +
                            " to rod " + to_rod);
            return;
        }
  
        towerOfHanoi(n - 2, from_rod, aux_rod1,
                               aux_rod2, to_rod);
        Console.WriteLine("Move disk " + (n - 1) 
                       + " from rod " + from_rod
                       + " to rod " + aux_rod2);
        Console.WriteLine("Move disk " + n + 
                         " from rod " + from_rod 
                         + " to rod " + to_rod);
        Console.WriteLine("Move disk " + (n - 1) 
                       + " from rod " + aux_rod2 
                         + " to rod " + to_rod);
        towerOfHanoi(n - 2, aux_rod1, to_rod, 
                            from_rod, aux_rod2);
    }
  
    public static void Main()
    {
        int n = 4;
          
        towerOfHanoi(n, 'A', 'D', 'B', 'C'); 
    }
