using System;

namespace ShiftPuzzle.Backend.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer_var = 777;
            double double_var = 3.14159265358979323846;
            string string_var = "Это не банальный Hello World :)";
            bool bool_var = true;

            Console.Write("Значение целочисленной переменной: ");
            Console.Write(integer_var);
            Console.WriteLine(".");
            Console.Write("Значение вещественной переменной: ");
            Console.Write(double_var);
            Console.WriteLine(".");
            Console.Write("Значение строковой переменной: ");
            Console.Write(string_var);
            Console.WriteLine(".");
            Console.Write("Значение логической переменной: ");
            Console.Write(bool_var);
            Console.WriteLine(".");
        }
    }
}
