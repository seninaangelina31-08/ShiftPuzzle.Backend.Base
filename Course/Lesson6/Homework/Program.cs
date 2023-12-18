namespace Homework;
class Program
{
    static void Main(string[] args)
    {

    }
    public static int oftenNumber(int[] nums)
    {
        Dictionary<int, int> RecordedNums = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (RecordedNums.ContainsKey(num))
            {
                RecordedNums[num]++;
            }
            else
            {
                RecordedNums.Add(num, 0);
            }
        }
        int MaxVal = RecordedNums.Values.First();
        foreach (var i in RecordedNums)
        {
            if (i.Value > RecordedNums[MaxVal])
            {
                MaxVal = i.Key;
            }
        }
        return MaxVal;
    }

     static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int[,] transposedMatrix = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        return transposedMatrix;
    }
}
