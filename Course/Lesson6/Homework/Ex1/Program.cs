namespace Ex1;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int[] arr = new int[10];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 11);
        }
        var dict = new Dictionary<int, int>();
        for(int i = 0; i < arr.Length; i++)
            {
                int rep_count = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        rep_count++;
                    }
                }
                dict.TryAdd(arr[i], rep_count);
            }
            Console.WriteLine("Массив: ");
            Console.WriteLine(String.Join(", ", arr));
            int max_count = dict.Values.Max();
            foreach( KeyValuePair<int, int> kvp in dict)
            {
                if (kvp.Value == max_count)
                    Console.WriteLine($"Чаще всего встречается число {kvp.Key}");
            }
    }
}
