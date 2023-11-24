// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your text: ");


string s = Console.ReadLine();
int k = s.Count(x => x == '\n');
Console.WriteLine(k);
