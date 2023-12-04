namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        int answer_end = 1;
        Dictionary<string, string> people = new Dictionary<string, string>();

        Console.WriteLine("Hi! I'm your helper!");
        Console.WriteLine("You can write here your friend's phone numbers.");
        Console.WriteLine("Say to me ur name, please.");

        string? name = Console.ReadLine();
        Console.WriteLine($"Nice to meet you, {name}");
        Console.WriteLine("");
      do
      {
        Console.WriteLine("");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("Write 'new' if you want to add new phone number.");
        Console.WriteLine("And write 'see' if you want to see existing numbers.");

        string? answer = Console.ReadLine();

        if (answer == "new") 
        {
            Console.Write("Cool! Give me your friend's name, please: ");
            string? fr_name = Console.ReadLine();

            Console.Write("So now i need the number: ");
            string? number = Console.ReadLine();

            people.Add(fr_name, number);

            Console.WriteLine("The new phone number has been successfully added.");
            Console.WriteLine("");

        }

        else if (answer == "see")
        {
            Console.WriteLine("Okay! Here is your phone book: ");
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Key}  Number: {person.Value}");
            }

            Console.WriteLine("");

        }
        
        else{
            Console.WriteLine("Sorry, I can't understand you :(");
            Console.WriteLine("");
        }

         Console.WriteLine("Do you want to do anything else?");
         Console.Write("Write 0 if you want to exit and 1 if you want to continue: ");
         answer_end = Convert.ToInt32(Console.ReadLine());
         

      }
        while (answer_end != 0);
    }
}
