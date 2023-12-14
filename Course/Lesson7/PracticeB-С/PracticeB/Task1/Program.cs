namespace PracticeB;

class Program
{
    public static bool Solve(int[,] maze, int x, int y)
    {
        if (x < 0 || y < 0 || x >= maze.GetLength(0) || y >= maze.GetLength(1) || maze[x, y] == 0)
        {
            return false;
        }
        if (maze[x, y] == 3)
        {
            return true;
        }

        if (maze[x, y] != 0)
        {      
            maze[x, y] = 0;
            if (Solve(maze, x + 1, y) || Solve(maze, x - 1, y) || Solve(maze,x, y + 1) || Solve(maze, x, y - 1))
            {
                return true;
            }
        
        }
        return false;
    }
    static void Main(string[] args)
    {
       int[,] maze = {
    {2, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {1, 1, 1, 1, 0, 1, 0, 1, 1, 0},
    {0, 1, 0, 1, 0, 1, 0, 1, 0, 0},
    {0, 1, 0, 1, 1, 1, 1, 1, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 1, 1},
    {0, 1, 1, 1, 0, 1, 1, 1, 1, 0},
    {0, 0, 0, 1, 0, 1, 0, 0, 1, 0},
    {0, 1, 1, 1, 1, 1, 1, 1, 1, 3},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        };
        
        Console.Write(Solve(maze, 0, 0));

    }
}
