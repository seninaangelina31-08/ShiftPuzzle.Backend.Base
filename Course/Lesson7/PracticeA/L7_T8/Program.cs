namespace L7_T8;

class Program
{
    static void CalcSubset(List<int> A,
                           List<List<int> > res,
                           List<int> subset, int index)
    {

        res.Add(new List<int>(subset));

        for (int i = index; i < A.Count; i++) {
            subset.Add(A[i]);

            CalcSubset(A, res, subset, i + 1);

            subset.RemoveAt(subset.Count - 1);
        }
    }
 
    static List<List<int> > Subsets(List<int> A)
    {
        List<int> subset = new List<int>();
        List<List<int> > res = new List<List<int> >();
        int index = 0;
        CalcSubset(A, res, subset, index);
        return res;
    }
 
    static void Main(string[] args)
    {
        List<int> array = new List<int>{ 1, 2, 3 };
        List<List<int> > res = Subsets(array);
 
        foreach(List<int> subset in res)
        {
            Console.WriteLine(string.Join(" ", subset));
        }
    }
}
