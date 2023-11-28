using System;

namespace ShiftPuzzle.Backend.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] super_array = new double[5];
            for (int i=0; i<5; i++) {
                super_array[i] = Math.Pow(i + 1, 2);
            }
        }
    }
}
