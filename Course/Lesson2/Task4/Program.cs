int count = 0;
Console.WriteLine("Press Enter for amount Enter's, or Space -> Enter for exit!");
string inputEnter = Console.ReadLine();
while (inputEnter == String.Empty) 
{
    count++;
    inputEnter = Console.ReadLine();
    
}
Console.WriteLine(count);