int[] numbers = {1, 2, 3, 4, 5};
int a = 1;
int b; 

do
{
    if (numbers[a] > numbers[0])
    {
        b = numbers[0];
        numbers[0] = numbers[a];
        numbers[a] = b; 
    }
    a++;
} while (a < numbers.Length);
Console.WriteLine(numbers[0]);