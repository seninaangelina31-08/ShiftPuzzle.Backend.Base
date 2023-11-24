// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
int random = rnd.Next();

Console.WriteLine("Enter your number: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a<random)
{
    Console.WriteLine("Your number is less");
}

else if (a>random)
{
    Console.WriteLine("Your number is more");
}

else 
{
    Console.WriteLine("Your number is right!!!!!");
}

