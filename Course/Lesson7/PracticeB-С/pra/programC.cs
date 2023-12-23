using System;

class Program
{
    static void Main(string[] args)
    {
        MazeSolver mazeSolver = new MazeSolver(); // создание экземпляра класса MazeSolver

        // Определение и инициализация массива arr
        byte[,] arr = new byte[,]
        {
            {1, 0, 1, 1, 1},
            {1, 0, 0, 0, 1},
            {1, 1, 1, 0, 1},
            {1, 0, 0, 0, 1},
            {1, 1, 1, 5, 1}
        };

        // Начальные координаты
        byte startY = 2;
        byte startX = 1;

        mazeSolver.arr = arr; // присвоение массива arr экземпляру класса MazeSolver

        // Вызов метода FindPath на экземпляре класса MazeSolver
        mazeSolver.FindPath(startY, startX);
    }
    public class MazeSolver
    {
        byte[,] arr; // ваш массив лабиринта

        public void FindPath(byte y, byte x)
        {
            if (arr[y, x] == 5 || (arr[y, x - 1] != 0 && arr[y, x + 1] != 0 && arr[y + 1, x] != 0 && arr[y - 1, x] != 0))
                return;

            arr[y, x] = 2;

            if (arr[y, x - 1] == 0)
                FindPath(y, x - 1);
            if (arr[y, x + 1] == 0)
                FindPath(y, x + 1);
            if (arr[y + 1, x] == 0)
                FindPath(y + 1, x);
            if (arr[y - 1, x] == 0)
                FindPath(y - 1, x);
        }
    }

    
}