using System;

namespace ShiftPuzzle.Backend.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 200, 300, 400, 500};
            numbers[0] = 100;
            Console.Write($"Первый элемент массива теперь - {numbers[0]}");
        }
    }
}
