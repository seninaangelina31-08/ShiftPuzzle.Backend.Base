namespace HomeworkB;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrice = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        int rows = matrice.GetUpperBound(0) + 1;
        int columns = matrice.Length/rows;
        Console.WriteLine("Оригинальный массив");
        for (int i = 0; i < rows; i++){
            for(int j = 0; j < columns; j++){
                Console.Write(matrice[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Транспонация массива");
        for (int i = 0; i < columns; i++){
            for(int j = 0; j < rows; j++){
                Console.Write(matrice[j,i]);
            }
            Console.WriteLine();
        }
     }
}
