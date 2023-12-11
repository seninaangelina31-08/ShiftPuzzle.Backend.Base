// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        int[]mass = new int[]{ 12, 4, 4, 0, 9, 4, 3, 5, 5, 3, 4 };
            Array.Sort(mass);
            Dictionary<int,int> dict=new Dictionary<int,int>();
            int c=1;
            for(int i = 0; i < mass.Length-1; i++)
            {
                if (mass[i]==mass[i+1]){
                    c+=1;
                }else{
                    dict.Add(mass[i], c);
                }
            }
            int max=0;
            foreach (var item in dict){
                if (item.Value>max){
                    max=item.Value;
                }
            }
            foreach (var item in dict){
                if (item.Value==max){
                    Console.WriteLine("Count:"+item.Value+" Number:"+item.Key);
                    break;
                }
            }
    }
}
