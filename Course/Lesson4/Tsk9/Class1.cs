namespace Tsk9;

class Class1
{
    static void Main(string[] args)
    {
        int[] m = { 1, 2, -3, -4, 5 };
        int c = 0;
        for (int i = 0; i < m.Length; i++) {
            for (int j = 0; j < m.Length - 1; j++) {
                if (m[j] > m[j + 1]) {
                    c = m[j + 1];
                    m[j + 1] = m[j];
                    m[j] = c;
                }
            }
        }
        for (int i = 0; i < m.Length; i++)
            Console.Write(m[i] + " ");
    }
}
