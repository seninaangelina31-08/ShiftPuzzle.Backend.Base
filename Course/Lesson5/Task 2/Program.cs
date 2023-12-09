namespace Task_2;

class Program
{
    static void Main(string[] args)
    {

int[] myArray = { 0, 3, 4, 4, 5, 12, 14, 14, 121, 256, 256 };
            int uniqueElements = 0;
            bool found = false;
            for(int i = 0; i < myArray.Length; i++)
            {
                found = false;
 
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (i != j && myArray[i] == myArray[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found) uniqueElements++;
            }
 
 
            Console.WriteLine(uniqueElements);









    }
}
