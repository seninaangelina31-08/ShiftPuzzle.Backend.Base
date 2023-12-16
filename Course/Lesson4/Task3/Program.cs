int[] numbers = {1, 2, 3, 4, 5};
int[] numbers1 = new int[numbers.Length];

for (int i = numbers.Length-1; i > -1; i--) {
    Console.WriteLine(numbers[i]);
    numbers1[numbers.Length-i-1] = numbers[i];
    }