string[] strArr = new string[5];

for (int i = 0; i < strArr.Length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива: ");
    strArr[i] = Console.ReadLine()!;
}

for (int i = 0; i < strArr.Length; i++)
{
    Console.WriteLine($"{strArr[i]} ");
}