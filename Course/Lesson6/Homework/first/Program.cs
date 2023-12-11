namespace first;
class Program
{
    static void Main(string[] args)
    {
        int[]arrray = new int[]{ 10, -1, 12, 10, 89, 6 };
        Array.Sort(arrray);
        Dictionary<int,int> dict = new Dictionary<int,int>();

        int c = 1;
        for(int i = 0; i < arrray.Length - 1; i++)
        {
            if (arrray[i] == arrray[i+1]){
                c++;
            }else{
                dict.Add(arrray[i], c);
            }
        }

        int maxi = 0;
        foreach (var item in dict){
            if (item.Value > maxi){
                maxi = item.Value;
            }
        }
        foreach (var item in dict){
            if (item.Value == maxi){
                Console.WriteLine(item.Key + ": " + item.Value);
                break;
            }
        }
    }
}
