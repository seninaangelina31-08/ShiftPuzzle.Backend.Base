namespace Tsk3;

class Class1
{
    static void Main(string[] args)
    {
        int[] m1 = { 1, 2, 3, 4, 5 };

        int[] m2 = new int[m1.Length];

        for (int i = m1.Length - 1; i >= 0; i--)
        {
            m2[m1.Length - i - 1] = m1[i];
        }

            Console.WriteLine(String.Join(" ", m2));
    }
}
