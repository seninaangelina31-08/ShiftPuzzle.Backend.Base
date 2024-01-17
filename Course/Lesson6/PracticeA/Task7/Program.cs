Console.Write("Как вас зовут? ");
string? name = Console.ReadLine();


int length = name.Length;
Console.WriteLine($"В имени {name} {length} символов.");