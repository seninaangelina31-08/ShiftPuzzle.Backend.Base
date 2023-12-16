namespace Task10;

class Program
{
    static void Main(string[] args)
        {
            List<int> nums = new List<int> { 1, 2, 3 };
            generate(nums);
        }

        static void generate<T>(List<T> items)
        {
            void genady(int start)
            {
                if (start == items.Count - 1)
                {
                    Console.WriteLine(string.Join(" ", items));
                    return;
                }

                for (int i = start; i < items.Count; i++)
                {
                    wap(items, start, i);
                    genady(start + 1);
                    wap(items, start, i);
                }
            }

            genady(0);
        }

        static void wap<T>(List<T> items, int w, int s)
        {
            T temp = items[w];
            items[w] = items[s];
            items[s] = temp;
        }
    }