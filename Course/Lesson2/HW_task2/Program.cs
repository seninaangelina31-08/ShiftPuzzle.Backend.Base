namespace HW_task2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, what is ur name?");
        string? name = Console.ReadLine();
        var rand = new Random();
        int number = rand.Next(100);
        int answer = 0;

        Console.WriteLine($"Nice to meet you, {name}");
        
        Console.WriteLine("Let's play the game. The rules're simple");
        Console.WriteLine("I guess the number, and you guess");
        Console.WriteLine("");

        do
        {
            Console.WriteLine("Okay. What is your answer?");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer < number)
            {
                Console.WriteLine("No, too small");
            }

            else if (answer > number)
            {
                Console.WriteLine("No, too big");
            }
            else{
                Console.WriteLine("Right!");
            }
        }
        while (number != answer);
    }
}
