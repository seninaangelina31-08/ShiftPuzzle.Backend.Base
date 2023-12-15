using System.Transactions;

namespace TaskA;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");
        List<List<int>> res = Task10([1, 2, 3, 4, 5]);
        foreach (List<int> perm in res) {
            Console.WriteLine(string.Join(", ", perm));
        }
    }

    static public int Task1(int n) {
        if (n <=1) {
            return 1;
        }
        return n*Task1(n-1);
    }

    static public int Task2(int n) {
        if (n<=1) {
            return n;
        }
        return Task2(n-1)+Task2(n-2);
    }

    static public string Task3(string s) {
        if (s.Length <= 1) {
            return s;
        }
        string reverse = Task3(s.Substring(1));
        
        return reverse + s[0];
    }

    static public int Task4(int[] arr, int ind) {
        if (ind == arr.Length) {
            return 0;
        }
        int cur = arr[ind];
        int remain = Task4(arr, ind+1);
        return cur + remain;
    }

    static public int Task5(int a, int b) {
        if (b == 0) {
            return a;
        }
        return Task5(b, a%b);
    }

    static public bool Task6(string s) {
        if (s.Length <= 1){
            return true;
        }
        if (s[0] == s[s.Length - 1])
            return Task6(s.Substring(1, s.Length - 2));

        return false;
    }

    static public void Task7(int n, char source, char aux, char dest) {
        if (n > 0) {
            Task7(n - 1, source, dest, aux);
            Console.WriteLine($"Перемещение кольца {n} с {source} на {dest}");
            Task7(n - 1, aux, source, dest);
        }
    }

    static public void Task8(List<int> set) {
        var subsets = GetSubsets(set);
        
        foreach (var subset in subsets) {
            Console.WriteLine(string.Join(", ", subset));
        }
    }
    
    static public List<List<int>> GetSubsets(List<int> set) {
        int n = set.Count;
        var subsets = new List<List<int>>();
        void GenerateSubsets(int index, List<int> currentSubset) {
            if (index == n) {
                subsets.Add(new List<int>(currentSubset));
                return;
            }
            currentSubset.Add(set[index]);
            GenerateSubsets(index + 1, currentSubset);

            currentSubset.RemoveAt(currentSubset.Count - 1);
            GenerateSubsets(index + 1, currentSubset);
        }
        GenerateSubsets(0, new List<int>());
        
        return subsets;
    }

    static public List<List<int>> Task10(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        List<int> currentPermutation = new List<int>();
        bool[] used = new bool[nums.Length];
        
        Generate(nums, currentPermutation, used, result);
        
        return result;
    }

    static public void Generate(int[] nums, List<int> currentPermutation, bool[] used, List<List<int>> result) {
        if (currentPermutation.Count == nums.Length) {
            result.Add(new List<int>(currentPermutation));
            return;
        }
        
        for (int i = 0; i < nums.Length; i++) {
            if (!used[i]) {
                currentPermutation.Add(nums[i]);
                used[i] = true;
                
                Generate(nums, currentPermutation, used, result);
                
                currentPermutation.RemoveAt(currentPermutation.Count - 1);
                used[i] = false;
            }
        }
    }

    


}
