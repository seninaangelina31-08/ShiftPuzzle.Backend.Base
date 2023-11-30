namespace L4_T3;

class Program
{
    static void Main(string[] args)
    {
        
        string[] messages = {"My", "Name", "Is", "What", "My", "Name", "Is", "Who", "TIKI-TIKI", "Slim Shady"};
        string[] rotatedMessages = new string[messages.Length];
        int k = 0;
        while (k < messages.Length)
        {
            rotatedMessages[k] = messages[messages.Length - k - 1];
            k++;
        }
        foreach (string rotMessage in rotatedMessages)
        {
            Console.WriteLine(rotMessage);
        }
    }
}
