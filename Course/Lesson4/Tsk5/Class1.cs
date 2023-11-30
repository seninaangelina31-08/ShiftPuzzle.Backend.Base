namespace Tsk5;

public class Class1
{
    static void Main(string[] args)
    {
        int[] m = { 1, -2, -3, 2, -1 }; 
        int count = 0; 
        for (int j = 0; j < m.Length; j++){
            if (m[j] < 0){
               count++; 
            }   
        }
        Console.WriteLine("Отрицательных чисел: " + count);
    }

}
