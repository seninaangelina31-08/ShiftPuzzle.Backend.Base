int[] numbers = {-1, 2, -3, 4, -5};
int a = 0;

for (int i = 0; i < numbers.Length; i++) {
    if (numbers[i] < 0) {
        a++;
    }
}

Console.WriteLine(a);